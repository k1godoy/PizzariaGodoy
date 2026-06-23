using Microsoft.JSInterop;
using Pizzaria_Godoy.Data;
using Pizzaria_Godoy.Repository;
using Pizzaria_Godoy.Services.Extensions;

namespace Pizzaria_Godoy.Components.Pages.Category_Pages
{
    public partial class CategoryList
    {
        private bool IsProcessing { get; set; } = true;
        private IEnumerable<Category> Categories { get; set; } = new List<Category>();
        private int DeleteCategoryID { get; set; } = 0;
        protected override async Task OnInitializedAsync()
        {

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {

                await LoadCategory();
                IsProcessing = false;
                StateHasChanged();

            }
            //return base.OnAfterRenderAsync(firstRender);
        }

        private async Task LoadCategory()
        {

            Categories = await _categoryRepository.GetAllAsync();
            //Carregar categorias
        }

        private void HandleDelete(int id)
        {

            DeleteCategoryID = id;
            _JS.InvokeVoidAsync("ShowConfirmationModal");

        }
        private async Task ConfirmDelete_Click(bool isConfirmed)
        {
            IsProcessing = true;
            await _JS.InvokeVoidAsync("HideConfirmationModal");
            if (isConfirmed && DeleteCategoryID != 0)
            {
                var result = await _categoryRepository.DeleteAsync(DeleteCategoryID);
                if (result)
                    _JS.ToastrSuccess("Categoria deletada");
                else
                    _JS.ToastrError("Erro encontrado enquanto estava deletando");

                await LoadCategory();
            }
            DeleteCategoryID = 0;
            IsProcessing = false;
        }
    }
}