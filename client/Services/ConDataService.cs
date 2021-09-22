
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using Radzen;
using Novorfay.Models.ConData;

namespace Novorfay
{
    public partial class ConDataService
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;
        private readonly NavigationManager navigationManager;
        public ConDataService(NavigationManager navigationManager, HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            this.navigationManager = navigationManager;
            this.baseUri = new Uri($"{navigationManager.BaseUri}odata/ConData/");
        }

        public async System.Threading.Tasks.Task ExportProductsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportProductsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/products/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/products/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetProducts(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Product>> GetProducts(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"Products");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetProducts(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Product>>();
        }
        partial void OnCreateProduct(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Product> CreateProduct(Product product = default(Product))
        {
            var uri = new Uri(baseUri, $"Products");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            OnCreateProduct(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Product>();
        }

        public async System.Threading.Tasks.Task ExportProductCategoriesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/productcategories/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/productcategories/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportProductCategoriesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/productcategories/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/productcategories/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetProductCategories(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<ProductCategory>> GetProductCategories(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"ProductCategories");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetProductCategories(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<ProductCategory>>();
        }
        partial void OnCreateProductCategory(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ProductCategory> CreateProductCategory(ProductCategory productCategory = default(ProductCategory))
        {
            var uri = new Uri(baseUri, $"ProductCategories");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(productCategory), Encoding.UTF8, "application/json");

            OnCreateProductCategory(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ProductCategory>();
        }
        partial void OnDeleteProduct(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteProduct(Int64? productId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"Products({productId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteProduct(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetProductByProductId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Product> GetProductByProductId(Int64? productId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"Products({productId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetProductByProductId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Product>();
        }
        partial void OnUpdateProduct(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateProduct(Int64? productId = default(Int64?), Product product = default(Product))
        {
            var uri = new Uri(baseUri, $"Products({productId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", product.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            OnUpdateProduct(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteProductCategory(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteProductCategory(int? categoryId = default(int?))
        {
            var uri = new Uri(baseUri, $"ProductCategories({categoryId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteProductCategory(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetProductCategoryByCategoryId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ProductCategory> GetProductCategoryByCategoryId(int? categoryId = default(int?))
        {
            var uri = new Uri(baseUri, $"ProductCategories({categoryId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetProductCategoryByCategoryId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ProductCategory>();
        }
        partial void OnUpdateProductCategory(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateProductCategory(int? categoryId = default(int?), ProductCategory productCategory = default(ProductCategory))
        {
            var uri = new Uri(baseUri, $"ProductCategories({categoryId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", productCategory.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(productCategory), Encoding.UTF8, "application/json");

            OnUpdateProductCategory(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
    }
}
