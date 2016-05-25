using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface ISystemConfigRepository
    {
    }

    public class SystemConfigRepository : ReponsitoryBase<SystemConfigRepository>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}