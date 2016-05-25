using VietShop.Data.Infrastructure;
using VietShop.Model.Models;

namespace VietShop.Data.Reponsitories
{
    public interface IPostCategoryRepository
    {
    }

    public class PostCategoryRepository : ReponsitoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}