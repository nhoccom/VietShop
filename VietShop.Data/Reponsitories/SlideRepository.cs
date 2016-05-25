using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface ISliderepository
    {
    }

    public class SlideRepository : ReponsitoryBase<SlideRepository>, ISliderepository
    {
        public SlideRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}