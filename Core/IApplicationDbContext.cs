using AngularClient.Models;
using AngularClient.Models.Identity;
using Microsoft.EntityFrameworkCore;


namespace AngularClient.Core
{
    public interface IApplicationDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Subtitle> Subtitles { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<Word> Words { get; set; }
        DbSet<Remarque> Remarques { get; set; }
        //DbSet<Question> Questions { get; set; }
        DbSet<Video> Videos { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        //DbSet<Ticket> Tickets { get; set; }
        //DbSet<CoinType> CoinTypes { get; set; }
        DbSet<Customer> Customers { get; set; }
    }
}