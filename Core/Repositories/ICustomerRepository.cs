using AngularClient.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularClient.Core.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(string userId);
    }
}
