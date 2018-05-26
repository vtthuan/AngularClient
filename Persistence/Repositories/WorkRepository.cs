using AngularClient.Core;
using AngularClient.Core.Repositories;
using AngularClient.Models;
using System.Linq;
namespace AngularClient.Persistence.Repositories
{
    public class WordRepository : IWordRepository
    {
        private readonly IApplicationDbContext _context;
        public WordRepository(IApplicationDbContext context)
        {
            _context = context;
        }
        public Word Get(string word)
        {
            return _context.Words.FirstOrDefault(w => w.Text == word);
        }
    }
}