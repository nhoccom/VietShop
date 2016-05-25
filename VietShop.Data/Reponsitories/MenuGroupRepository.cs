using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface IMenuGroupRepository
    {
    }

    public class MenuGroupRepository : ReponsitoryBase<MenuGroupRepository>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}