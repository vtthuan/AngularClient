using AngularClient.Core;
using AngularClient.Core.Repositories;
using AngularClient.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AngularClient.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IApplicationDbContext _context;

        public CategoryRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategories(bool actif = true)
        {
            return Base()
                .Where(x => x.Actif == actif);            
        }

        private IQueryable<Category> Base()
        {
            return _context.Categories
                .Include(x => x.Videos.Select(p => p.MediaInfo))
                .Include(x => x.Videos.Select(p => p.User));
        }

        public Category GetCategory(string name, bool actif = true)
        {
            return Base()
                .FirstOrDefault(x => x.Actif == actif && x.Name== name);
        }
        public Category GetCategory(int? id, bool actif = true)
        {
            return Base()
                .FirstOrDefault(x => x.Actif == actif && x.Id==id );
        }

    }
}