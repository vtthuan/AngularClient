using AngularClient.Core;
using AngularClient.Core.Repositories;
using AngularClient.Models;
using System.Collections.Generic;
using System.Linq;

namespace AngularClient.Persistence.Repositories
{
    public class RemarqueRepository : IRemarqueRepository
    {
        private readonly IApplicationDbContext _context;

        public RemarqueRepository(IApplicationDbContext context)
        {
            this._context = context;
        }

        public void Add(Remarque r)
        {
            _context.Remarques.Add(r);
        }

        public IEnumerable<Remarque> GetAllRemarques(Video video, Language language)
        {
            return _context.Remarques.Where(r => r.VideoId == video.Id && r.NativeLanguageId == language.Id);            
        }
    }
}