using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface IOrderRepository
    {
    }

    public class OrderRepository : ReponsitoryBase<OrderRepository>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}