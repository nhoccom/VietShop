using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface IProductTagRepository
    {

    }
    public class ProductTagRepository : ReponsitoryBase<ProductTagRepository>,IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}