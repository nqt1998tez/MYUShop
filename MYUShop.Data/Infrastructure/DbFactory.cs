using MYUShop.Data;

namespace MYUShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MYUShopDbContext dbContext;

        public MYUShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MYUShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}