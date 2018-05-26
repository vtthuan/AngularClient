using System;
using System.Collections.Generic;
using System.Linq;
using RTF.Core.Models;
using RTF.Core.Repositories;
using RTF.Core;

namespace RTF.Persistence.Repositories
{
    public class CoinRepository : ICoinRepository
    {
        private readonly IApplicationDbContext _context;

        public CoinRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CoinType> GetAllCoins(bool active = true)
        {
            return _context.CoinTypes.Where(x => x.Active == active);
        }
    }
}