using AngularClient.Core;
using AngularClient.Core.Repositories;
using AngularClient.Models;
using System.Collections.Generic;
using System.Linq;

namespace AngularClient.Persistence.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly IApplicationDbContext _context;

        public LanguageRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public Language Get(int id)
        {
            return _context.Languages.FirstOrDefault(x => x.Id == id);
        }

        public Language Get(string code)
        {
            return _context.Languages.FirstOrDefault(x => x.Code == code);
        }

        public IEnumerable<Language> GetAllLanguages()
        {
            return _context.Languages;
        }

    }
}