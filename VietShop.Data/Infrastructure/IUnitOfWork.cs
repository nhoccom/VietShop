namespace VietShop.Data.Infrastructure
{
    internal interface IUnitOfWork
    {
        void Commit();
    }
}