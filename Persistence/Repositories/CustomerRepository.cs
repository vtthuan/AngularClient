using AngularClient.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularClient.Models.Identity;
using AngularClient.Core;

namespace AngularClient.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IApplicationDbContext _context;

        public CustomerRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        private IQueryable<Customer> Base()
        {
            return _context.Customers;
        }

        public Customer GetCustomer(string userId)
        {
            return Base()
                .FirstOrDefault(x => x.IdentityId == userId);
        }
    }
}
