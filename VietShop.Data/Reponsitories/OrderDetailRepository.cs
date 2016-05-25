using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface IOrderDetailRepository
    {

    }
    public class OrderDetailRepository : ReponsitoryBase<OrderDetailRepository>,IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}