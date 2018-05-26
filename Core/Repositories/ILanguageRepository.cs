using System.Collections.Generic;
using AngularClient.Models;
namespace AngularClient.Core.Repositories
{
    public interface ILanguageRepository
    {
        Language Get(int id);
        Language Get(string code);
        IEnumerable<Language> GetAllLanguages();
    }
}
