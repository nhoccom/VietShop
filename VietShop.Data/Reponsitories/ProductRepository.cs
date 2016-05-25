using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietShop.Model.Models;
using VietShop.Data.Infrastructure;


namespace VietShop.Data.Reponsitories
{
    public interface IProductRepository
    {

    }
    class ProductRepository : ReponsitoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
