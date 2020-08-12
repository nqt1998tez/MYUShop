using System;

namespace MYUShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MYUShopDbContext Init();
    }
}