using AngularClient.Core;
using AngularClient.Core.Repositories;
using AngularClient.Persistence;
using AngularClient.Persistence.Repositories;

namespace AngularClient.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public ICategoryRepository CategoryRepository { get; private set; }
        public ISubtitleRepository SubtitleRepository { get; private set; }
        public ILanguageRepository LanguageRepository { get; private set; }
        public IWordRepository WordRepository { get; private set; }
        public IVideoRepository VideoRepository { get; private set; }
        public ITransactionRepository TransactionRepository { get; private set; }
        public IRemarqueRepository RemarqueRepository { get; private set; }
        public ICustomerRepository CustomerRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CategoryRepository = new CategoryRepository(context);
            SubtitleRepository = new SubtitleRepository(context);
            LanguageRepository = new LanguageRepository(context);
            TransactionRepository = new TransactionRepository(context);
            WordRepository = new WordRepository(context);
            VideoRepository = new VideoRepository(context);
            RemarqueRepository = new RemarqueRepository(context);
            CustomerRepository = new CustomerRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}