using AngularClient.Models;
using System.Collections.Generic;

namespace AngularClient.Core.Repositories
{
    public interface IRemarqueRepository
    {
        IEnumerable<Remarque> GetAllRemarques(Video video, Language language);
        void Add(Remarque r);

    }
}