using Pizzaria_Godoy.Repository.IRespository;
using Pizzaria_Godoy.Data;

namespace Pizzaria_Godoy.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Category Create(Category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return obj;
        }
        public Category Update(Category obj)
        {
            // objFromDb = Objeto vindo do banco de dados o u representa pegar uma categoria por vez
            var objFromDb = _db.Categories.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb is not null)
            {
                objFromDb.Name = obj.Name;
                _db.Categories.Update(objFromDb);

                return objFromDb;
            }
            return obj;
        }
        public bool Delete(int id)
        {
            var obj = _db.Categories.FirstOrDefault(u => u.Id == id);
            if (obj != null)
            {
                _db.Categories.Remove(obj);
                return _db.SaveChanges() > 0;
            }
            return false;
        }
        public Category Get(int id)
        {
            var obj = _db.Categories.FirstOrDefault(u => u.Id == id);
            if (obj != null)
            {
                return new Category();
            }
            return obj;
        }
        public IEnumerable<Category> GetAll()
        {
            return _db.Categories.ToList();
        }

    }

}

