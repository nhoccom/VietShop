namespace VietShop.Data.Infrastructure
{
    public class UnitOfWord : IUnitOfWork
    {
        private readonly IDbFactory dbFatory;
        private VietShopDBContext dbContext;

        public UnitOfWord(IDbFactory dbFatory)
        {
            this.dbFatory = dbFatory;
        }

        public VietShopDBContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFatory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}