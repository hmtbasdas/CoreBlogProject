using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
    }
}
