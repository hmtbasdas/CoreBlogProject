using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
