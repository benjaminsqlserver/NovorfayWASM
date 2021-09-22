using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.OData.Query;



namespace Novorfay.Controllers.ConData
{
  using Models;
  using Data;
  using Models.ConData;

  [ODataRoutePrefix("odata/ConData/Products")]
  [Route("mvc/odata/ConData/Products")]
  public partial class ProductsController : ODataController
  {
    private Data.ConDataContext context;

    public ProductsController(Data.ConDataContext context)
    {
      this.context = context;
    }
    // GET /odata/ConData/Products
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.ConData.Product> GetProducts()
    {
      var items = this.context.Products.AsQueryable<Models.ConData.Product>();
      this.OnProductsRead(ref items);

      return items;
    }

    partial void OnProductsRead(ref IQueryable<Models.ConData.Product> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{ProductID}")]
    public SingleResult<Product> GetProduct(Int64 key)
    {
        var items = this.context.Products.Where(i=>i.ProductID == key);
        return SingleResult.Create(items);
    }
    partial void OnProductDeleted(Models.ConData.Product item);
    partial void OnAfterProductDeleted(Models.ConData.Product item);

    [HttpDelete("{ProductID}")]
    public IActionResult DeleteProduct(Int64 key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.Products
                .Where(i => i.ProductID == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.ConData.Product>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnProductDeleted(item);
            this.context.Products.Remove(item);
            this.context.SaveChanges();
            this.OnAfterProductDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnProductUpdated(Models.ConData.Product item);
    partial void OnAfterProductUpdated(Models.ConData.Product item);

    [HttpPut("{ProductID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutProduct(Int64 key, [FromBody]Models.ConData.Product newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Products
                .Where(i => i.ProductID == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.ConData.Product>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnProductUpdated(newItem);
            this.context.Products.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Products.Where(i => i.ProductID == key);
            Request.QueryString = Request.QueryString.Add("$expand", "ProductCategory");
            this.OnAfterProductUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{ProductID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchProduct(Int64 key, [FromBody]Delta<Models.ConData.Product> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Products.Where(i => i.ProductID == key);

            items = EntityPatch.ApplyTo<Models.ConData.Product>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnProductUpdated(item);
            this.context.Products.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Products.Where(i => i.ProductID == key);
            Request.QueryString = Request.QueryString.Add("$expand", "ProductCategory");
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnProductCreated(Models.ConData.Product item);
    partial void OnAfterProductCreated(Models.ConData.Product item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.ConData.Product item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnProductCreated(item);
            this.context.Products.Add(item);
            this.context.SaveChanges();

            var key = item.ProductID;

            var itemToReturn = this.context.Products.Where(i => i.ProductID == key);

            Request.QueryString = Request.QueryString.Add("$expand", "ProductCategory");

            this.OnAfterProductCreated(item);

            return new ObjectResult(SingleResult.Create(itemToReturn))
            {
                StatusCode = 201
            };
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
