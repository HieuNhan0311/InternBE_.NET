using XuongMay.Contract.Repositories.IUOW;

namespace XuongMay.Contract.Repositories.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : class;
        void Save();
        Task SaveAsync();
        void BeginTransaction();
        void CommitTransaction();
        void RollBack();
        ICategoryRepository Categories { get; }
        Task<int> CompleteAsync();
    }

}
