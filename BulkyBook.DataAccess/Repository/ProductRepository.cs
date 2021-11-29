using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDBContext _db;

        public ProductRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.Description = obj.Description;    
                objFromDb.Price = obj.Price;    
                objFromDb.CategoryId = obj.CategoryId;  
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price100 = obj.Price100; 
                objFromDb.Price50 = obj.Price50;
                objFromDb.Author = obj.Author;
                objFromDb.CoverTypeId = obj.CoverTypeId;              
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
