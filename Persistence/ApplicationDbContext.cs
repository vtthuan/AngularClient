using AngularClient.Core;
using AngularClient.Models;
using AngularClient.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AngularClient.Persistence
{
    public class ApplicationDbContext :  IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Subtitle> Subtitles { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<MediaInfo> MediaProvider { get; set; }
        public DbSet<Language> Languages { get; set; }
        //public DbSet<Question> Questions { get; set; }
        public DbSet<Remarque> Remarques { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        //public DbSet<Ticket> Tickets { get; set; }
        //public DbSet<CoinType> CoinTypes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<YoutubeMediaInfo>().HasBaseType<MediaInfo>();
            builder.Entity<DailyMotionMediaInfo>().HasBaseType<MediaInfo>();
            base.OnModelCreating(builder);
        }

        //public override int SaveChanges()
        //{
        //    AddTimestamps();
        //    return base.SaveChanges();
        //}

        //public override async Task<int> SaveChangesAsync()
        //{
        //    AddTimestamps();
        //    return await base.SaveChangesAsync();
        //}

        //private void AddTimestamps()
        //{
        //    var entities = ChangeTracker.Entries().Where(x => x.Entity is UpdatableEntity
        //        && (x.State == EntityState.Added || x.State == EntityState.Modified));

        //    var userId = !string.IsNullOrEmpty(HttpContext.Current?.User?.Identity?.GetUserId())
        //        ? HttpContext.Current.User.Identity.GetUserId()
        //        : null;

        //    foreach (var entity in entities)
        //    {
        //        if (entity.State == EntityState.Added)
        //        {
        //            ((UpdatableEntity)entity.Entity).CreatedOn = DateTime.UtcNow;
        //            ((UpdatableEntity)entity.Entity).UserId = userId;
        //        }

        //        ((UpdatableEntity)entity.Entity).LastModificationOn = DateTime.UtcNow;
        //        ((UpdatableEntity)entity.Entity).UserId = userId;
        //    }
        //}
    }
}

