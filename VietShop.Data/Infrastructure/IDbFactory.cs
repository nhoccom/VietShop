using System;

//giao tiep de khoi tao doi tuong entity
namespace VietShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        VietShopDBContext Init();
    }
}