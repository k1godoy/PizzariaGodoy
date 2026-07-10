using Microsoft.JSInterop;
using Pizzaria_Godoy.Data;
using Pizzaria_Godoy.Repository;
using Pizzaria_Godoy.Services.Extensions;

namespace Pizzaria_Godoy.Components.Pages.Product_Pages
{
    public partial class ProductList
    {
        private bool IsProcessing { get; set; } = true;
        private IEnumerable<Product> Product { get; set; } = new List<Product>();
        private int DeleteProductID { get; set; } = 0;
        protected override async Task OnInitializedAsync()
        {

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {

                await LoadProduct();
                IsProcessing = false;
                StateHasChanged();

            }
            //return base.OnAfterRenderAsync(firstRender);
        }

        private async Task LoadProduct()
        {

            Product = await _productRepository.GetAllAsync();
            //Carregar categorias
        }

        private void HandleDelete(int id)
        {

            DeleteProductID = id;
            _JS.InvokeVoidAsync("ShowConfirmationModal");

        }
        private async Task ConfirmDelete_Click(bool isConfirmed)
        {
            IsProcessing = true;
            await _JS.InvokeVoidAsync("HideConfirmationModal");
            if (isConfirmed && DeleteProductID != 0)
            {
                var result = await _productRepository.DeleteAsync(DeleteProductID);
                if (result)
                    _JS.ToastrSuccess("Categoria deletada");
                else
                    _JS.ToastrError("Erro encontrado enquanto estava deletando");

                await LoadProduct();
            }
            DeleteProductID = 0;
            IsProcessing = false;
        }
    }
}