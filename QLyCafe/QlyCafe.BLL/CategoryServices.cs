using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyCafe.DAL;

namespace QlyCafe.BLL
{
    public class CategoryServices
    {
        private QlyCafe_Entities db_Context;
        public CategoryServices()
        {
            db_Context = new QlyCafe_Entities();
        }
        //lay danh sach category
        public List<Category> GetCategories()
        {
            return db_Context.Category
                .Where(n => n.IsDeleted == null || n.IsDeleted == false)
                .ToList();
        }
        
        public List<Category> GetCategoriesDeleted()
        {
            return db_Context.Category
                .Where(n => n.IsDeleted != null && n.IsDeleted == true)
                .ToList();
        }

        public Category GetCategoryByID(int id)
        {
            return db_Context.Category.Find(id);
        }

        //them category
        public void CreateCategory(Category category)
        {
            if (db_Context.Category.Any(n => n.ID == category.ID) == false)
            {
                db_Context.Category.Add(category);
                db_Context.SaveChanges();
            }
        }

        //Thay doi category
        public void UpdateCategory(Category category)
        {
            var existingCategory = db_Context.Category.Find(category.ID);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name;
                db_Context.Entry(existingCategory).State
                    = System.Data.Entity.EntityState.Modified;
                db_Context.SaveChanges();
            }
        }

        //Xoa category
        public bool CheckDelete_Category(Category category)
        {
            return db_Context.Product
                .Any(n => n.CategoryID == category.ID
                && (n.IsDeleted == null || n.IsDeleted == false));
        }

        public void DeleteCategory(int id)
        {
            var existingCategory = db_Context.Category.Find(id);
            if (existingCategory != null)
            {
                using (var transaction = db_Context.Database.BeginTransaction())
                {
                    try
                    {
                        existingCategory.IsDeleted = true;
                        db_Context.Entry(existingCategory).State
                            = System.Data.Entity.EntityState.Modified;
                        db_Context.SaveChanges();

                        List<Product> list_Product = db_Context.Product
                            .Where(n => n.CategoryID == id
                            && (n.IsDeleted == null || n.IsDeleted == false))
                            .ToList();
                        foreach (var product in list_Product)
                        {
                            product.IsDeleted = true;
                            db_Context.Entry(product).State
                                = System.Data.Entity.EntityState.Modified;
                            db_Context.SaveChanges();
                        }
                            transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        public void RestoreCategory(int id)
        {
            var existingCategory = db_Context.Category.Find(id);
            if (existingCategory != null)
            {
                existingCategory.IsDeleted = false;
                db_Context.Entry(existingCategory).State
                    = System.Data.Entity.EntityState.Modified;
                db_Context.SaveChanges();
            }
        }
    }
}
