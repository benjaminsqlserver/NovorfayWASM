using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Novorfay.Models.ConData;
using Microsoft.AspNetCore.Identity;
using Novorfay.Models;
using Novorfay.Client.Pages;

namespace Novorfay.Pages
{
    public partial class ProductCategoriesComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }

        [Inject]
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        protected ConDataService ConData { get; set; }
        protected RadzenDataGrid<Novorfay.Models.ConData.ProductCategory> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Novorfay.Models.ConData.ProductCategory> _getProductCategoriesResult;
        protected IEnumerable<Novorfay.Models.ConData.ProductCategory> getProductCategoriesResult
        {
            get
            {
                return _getProductCategoriesResult;
            }
            set
            {
                if (!object.Equals(_getProductCategoriesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getProductCategoriesResult", NewValue = value, OldValue = _getProductCategoriesResult };
                    _getProductCategoriesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getProductCategoriesCount;
        protected int getProductCategoriesCount
        {
            get
            {
                return _getProductCategoriesCount;
            }
            set
            {
                if (!object.Equals(_getProductCategoriesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getProductCategoriesCount", NewValue = value, OldValue = _getProductCategoriesCount };
                    _getProductCategoriesCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Security.InitializeAsync(AuthenticationStateProvider);
            if (!Security.IsAuthenticated())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }
        }
        protected async System.Threading.Tasks.Task Load()
        {
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddProductCategory>("Add Product Category", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var conDataGetProductCategoriesResult = await ConData.GetProductCategories(filter:$@"(contains(CategoryName,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getProductCategoriesResult = conDataGetProductCategoriesResult.Value.AsODataEnumerable();

                getProductCategoriesCount = conDataGetProductCategoriesResult.Count;
            }
            catch (System.Exception conDataGetProductCategoriesException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load ProductCategories" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Novorfay.Models.ConData.ProductCategory args)
        {
            var dialogResult = await DialogService.OpenAsync<EditProductCategory>("Edit Product Category", new Dictionary<string, object>() { {"CategoryID", args.CategoryID} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var conDataDeleteProductCategoryResult = await ConData.DeleteProductCategory(categoryId:data.CategoryID);
                    if (conDataDeleteProductCategoryResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception conDataDeleteProductCategoryException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete ProductCategory" });
            }
        }
    }
}
