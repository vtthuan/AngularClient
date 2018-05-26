using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularClient.Models;

namespace AngularClient.Core.Repositories
{
    public interface IWordRepository
    {
        Word Get(string word);
    }
}
