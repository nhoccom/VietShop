using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface IPageRepository
    {
    }

    public class PageRepository : ReponsitoryBase<PageRepository>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}