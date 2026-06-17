using Pizzaria_Godoy.Data;

namespace Pizzaria_Godoy.Components.Pages.Category_Pages
{
    public partial class CategoryList
    {
        private bool IsProcessing { get; set; } = false;
        private IEnumerable<Category> Categories { get; set; } = new List<Category>();

        protected override async Task OnInitializedAsync()
        {
            IsProcessing = true;
            await Task.Yield();
            LoadCategories();
            IsProcessing = false;
        }

        private void LoadCategories()
        {

            Thread.Sleep(5000);
            Categories = _categoryRepository.GetAll();
            //Carregar categorias
        }
    }
}
