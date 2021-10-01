using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDal.GetListWithCategory();
        }

        public Blog GetID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogByID(int id)
        {
            return blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetList()
        {
            return blogDal.GetListAll();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
