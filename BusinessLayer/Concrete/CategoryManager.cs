using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            categoryDal.Insert(category);
        }

        public void Delete(Category category)
        {
            categoryDal.Delete(category);
        }

        public Category GetID(int id)
        {
            return categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return categoryDal.GetListAll();
        }

        public void Update(Category category)
        {
            categoryDal.Update(category);
        }
    }
}
