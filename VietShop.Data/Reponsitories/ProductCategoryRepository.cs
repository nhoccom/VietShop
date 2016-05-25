using System.Collections.Generic;
using System.Linq;
using VietShop.Data.Infrastructure;
using VietShop.Model.Models;

namespace VietShop.Data.Reponsitories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategoryRepository> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : ReponsitoryBase<ProductCategory>
    {
        public ProductCategoryRepository(DBFatory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}