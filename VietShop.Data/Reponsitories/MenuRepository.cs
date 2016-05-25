using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface IMenuRepository
    {
    }

    public class MenuRepository : ReponsitoryBase<MenuRepository>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFatory)
            : base(dbFatory)
        {
        }
    }
}