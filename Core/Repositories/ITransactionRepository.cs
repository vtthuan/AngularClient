using AngularClient.Models;
using System.Collections.Generic;
namespace AngularClient.Core.Repositories
{
    public interface ITransactionRepository
    {
        IList<Transaction> Get(string userId, int videoId);
        Transaction GetByToken(string guid);
        void Add(Transaction transaction);
    }
}