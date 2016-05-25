using VietShop.Data.Infrastructure;
using VietShop.Model.Models;

namespace VietShop.Data.Reponsitories
{
    public interface IPostRepository
    {
    }

    public class PostRepository : ReponsitoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}