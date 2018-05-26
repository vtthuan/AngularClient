using AngularClient.Models;
using System.Collections.Generic;

namespace AngularClient.Core.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories(bool actif = true);
        Category GetCategory(string name, bool actif = true);
        Category GetCategory(int? id, bool actif = true);
    }
}
