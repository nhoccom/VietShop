using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface IVisitorStasticRepository
    {

    }
    public class VisitorStasticRepository : ReponsitoryBase<VisitorStasticRepository>, IVisitorStasticRepository
    {
        public VisitorStasticRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}