using Pizzaria_Godoy.Data;
using Pizzaria_Godoy.Repository;

namespace Pizzaria_Godoy.Components.Pages.Category_Pages
{
    public partial class CategoryList
    {
        private bool IsProcessing { get; set; } = true;
        private IEnumerable<Category> Categories { get; set; } = new List<Category>();

        protected override async Task OnInitializedAsync()
        {
          
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                IsProcessing = true;
                await LoadCategories();
                IsProcessing = false;
                StateHasChanged();
                
            }
            //return base.OnAfterRenderAsync(firstRender);
        }

        private async Task LoadCategories()
        {

            Categories = await _categoryRepository.GetAllAsync();
            //Carregar categorias
        }
    }
}
