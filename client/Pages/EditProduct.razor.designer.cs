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
    public partial class EditProductComponent : ComponentBase
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

        [Parameter]
        public dynamic ProductID { get; set; }

        bool _hasChanges;
        protected bool hasChanges
        {
            get
            {
                return _hasChanges;
            }
            set
            {
                if (!object.Equals(_hasChanges, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "hasChanges", NewValue = value, OldValue = _hasChanges };
                    _hasChanges = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if (!object.Equals(_canEdit, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "canEdit", NewValue = value, OldValue = _canEdit };
                    _canEdit = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Novorfay.Models.ConData.Product _product;
        protected Novorfay.Models.ConData.Product product
        {
            get
            {
                return _product;
            }
            set
            {
                if (!object.Equals(_product, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "product", NewValue = value, OldValue = _product };
                    _product = value;
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
            hasChanges = false;

            canEdit = true;

            var conDataGetProductByProductIdResult = await ConData.GetProductByProductId(productId:ProductID);
            product = conDataGetProductByProductIdResult;

            canEdit = conDataGetProductByProductIdResult != null;

            var conDataGetProductCategoriesResult = await ConData.GetProductCategories();
            getProductCategoriesResult = conDataGetProductCategoriesResult.Value.AsODataEnumerable();
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            await this.Load();
        }

        protected async System.Threading.Tasks.Task Form0Submit(Novorfay.Models.ConData.Product args)
        {
            try
            {
                var conDataUpdateProductResult = await ConData.UpdateProduct(productId:ProductID, product:product);
                if (conDataUpdateProductResult.StatusCode != System.Net.HttpStatusCode.PreconditionFailed) {
                  DialogService.Close(product);
                }

                hasChanges = conDataUpdateProductResult.StatusCode == System.Net.HttpStatusCode.PreconditionFailed;
            }
            catch (System.Exception conDataUpdateProductException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update Product" });
            }
        }

        protected async System.Threading.Tasks.Task Button4Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
