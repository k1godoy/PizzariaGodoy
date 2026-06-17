using Pizzaria_Godoy.Data;

namespace Pizzaria_Godoy.Repository.IRespository
{
    public interface ICategoryRepository
{
        public Category Create(Category obj);
        public Category Update(Category obj);
        public bool Delete(int id);
        public Category Get(int id);
        public IEnumerable<Category> GetAll();

    }
}
