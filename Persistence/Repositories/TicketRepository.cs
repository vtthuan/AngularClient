using RTF.Core;
using RTF.Core.Models;
using RTF.Core.Repositories;
using System.Data.Entity;
using System.Linq;

namespace RTF.Persistence.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly IApplicationDbContext _unit;
        public TicketRepository(IApplicationDbContext unit)
        {
            _unit = unit;
        }

        private IQueryable<Ticket> Base()
        {
            return _unit.Tickets.Include(x => x.Coin);
        }

        public void Add(Ticket t)
        {
            _unit.Tickets.Add(t);
        }

        public Ticket GetByPaypalReference(string paypalReference)
        {
            return Base().FirstOrDefault(t => t.PaypalReference == paypalReference);
        }
    }
}