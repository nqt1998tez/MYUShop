using MYUShop.Data.Infrastructure;
using MYUShop.Model.Models;

namespace MYUShop.Data.Repositories
{
    public interface IColorRepository : IRepository<Color>
    {
    }

    public class ColorRepository : RepositoryBase<Color>, IColorRepository
    {
        public ColorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}