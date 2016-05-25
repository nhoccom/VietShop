namespace VietShop.Data.Infrastructure
{
    public class DBFatory : Disposable, IDbFactory
    {
        private VietShopDBContext dbContext;

        public VietShopDBContext Init()
        {
            return dbContext ?? (dbContext = new VietShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}