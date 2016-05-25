using VietShop.Data.Infrastructure;

namespace VietShop.Data.Reponsitories
{
    public interface IPostTagrepository
    {

    }
    public class PostTagRepository:ReponsitoryBase<PostTagRepository>,IPostTagrepository
    {
        public PostTagRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}