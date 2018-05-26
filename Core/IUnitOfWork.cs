using AngularClient.Core.Repositories;

namespace AngularClient.Core
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IRemarqueRepository RemarqueRepository { get; }
        IVideoRepository VideoRepository { get; }
        ISubtitleRepository SubtitleRepository { get; }
        ILanguageRepository LanguageRepository { get; }
        IWordRepository WordRepository { get; }
        ITransactionRepository TransactionRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        void Complete();
    }
}