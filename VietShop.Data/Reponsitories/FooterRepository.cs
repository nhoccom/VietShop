using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface IFooterRepository
    {
    }

    public class FooterRepository : ReponsitoryBase<FooterRepository>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}