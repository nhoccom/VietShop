using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface ITagRepository
    {
    }

    public class TagRepository : ReponsitoryBase<TagRepository>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}