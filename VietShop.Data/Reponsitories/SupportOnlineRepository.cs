using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface ISupportOnlineRepository
    {
    }

    public class SupportOnlineRepository : ReponsitoryBase<SupportOnlineRepository>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}