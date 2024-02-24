namespace CodeMePro.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository GenericRepository { get; }
        Task SaveChangesAsync();
    }

}

