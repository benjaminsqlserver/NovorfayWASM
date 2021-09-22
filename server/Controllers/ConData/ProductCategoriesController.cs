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

  [ODataRoutePrefix("odata/ConData/ProductCategories")]
  [Route("mvc/odata/ConData/ProductCategories")]
  public partial class ProductCategoriesController : ODataController
  {
    private Data.ConDataContext context;

    public ProductCategoriesController(Data.ConDataContext context)
    {
      this.context = context;
    }
    // GET /odata/ConData/ProductCategories
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.ConData.ProductCategory> GetProductCategories()
    {
      var items = this.context.ProductCategories.AsQueryable<Models.ConData.ProductCategory>();
      this.OnProductCategoriesRead(ref items);

      return items;
    }

    partial void OnProductCategoriesRead(ref IQueryable<Models.ConData.ProductCategory> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{CategoryID}")]
    public SingleResult<ProductCategory> GetProductCategory(int key)
    {
        var items = this.context.ProductCategories.Where(i=>i.CategoryID == key);
        return SingleResult.Create(items);
    }
    partial void OnProductCategoryDeleted(Models.ConData.ProductCategory item);
    partial void OnAfterProductCategoryDeleted(Models.ConData.ProductCategory item);

    [HttpDelete("{CategoryID}")]
    public IActionResult DeleteProductCategory(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.ProductCategories
                .Where(i => i.CategoryID == key)
                .Include(i => i.Products)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.ConData.ProductCategory>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnProductCategoryDeleted(item);
            this.context.ProductCategories.Remove(item);
            this.context.SaveChanges();
            this.OnAfterProductCategoryDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnProductCategoryUpdated(Models.ConData.ProductCategory item);
    partial void OnAfterProductCategoryUpdated(Models.ConData.ProductCategory item);

    [HttpPut("{CategoryID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutProductCategory(int key, [FromBody]Models.ConData.ProductCategory newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.ProductCategories
                .Where(i => i.CategoryID == key)
                .Include(i => i.Products)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.ConData.ProductCategory>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnProductCategoryUpdated(newItem);
            this.context.ProductCategories.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.ProductCategories.Where(i => i.CategoryID == key);
            this.OnAfterProductCategoryUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{CategoryID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchProductCategory(int key, [FromBody]Delta<Models.ConData.ProductCategory> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.ProductCategories.Where(i => i.CategoryID == key);

            items = EntityPatch.ApplyTo<Models.ConData.ProductCategory>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnProductCategoryUpdated(item);
            this.context.ProductCategories.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.ProductCategories.Where(i => i.CategoryID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnProductCategoryCreated(Models.ConData.ProductCategory item);
    partial void OnAfterProductCategoryCreated(Models.ConData.ProductCategory item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.ConData.ProductCategory item)
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

            this.OnProductCategoryCreated(item);
            this.context.ProductCategories.Add(item);
            this.context.SaveChanges();

            return Created($"odata/ConData/ProductCategories/{item.CategoryID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
