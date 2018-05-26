using AngularClient.Core;
using AngularClient.Core.Repositories;
using AngularClient.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AngularClient.Persistence.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IApplicationDbContext _context;
        public TransactionRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        private IQueryable<Transaction> Base()
        {
            return _context.Transactions
                .Include(t => t.Steps)
                .Include(t => t.Video)
                .Include(t => t.Video.MediaInfo)
                .Include(t => t.Video.Remarques)
                .Include(t => t.Video.Remarques.Select(r => r.NativeLanguage));
        }
        public IList<Transaction> Get(string userId, int videoId)
        {
            return Base()
                .Where(x => x.UserId == userId && x.VideoId == videoId).ToList();
        }

        public Transaction GetByToken(string guid)
        {
            return Base()
                .FirstOrDefault(x => x.Token == guid);
        }

        public void Add(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
        }

        //IEnumerable<Transaction> GetByUser(string userId);
        //Transaction Get(int id);
    }
}