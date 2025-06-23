using DAL.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Data
{
    public class Context : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
            //modelBuilder.ApplySoftDeleteQueryFilter();
        }

    }
    public static class ContextHelper
    {
        public static void ApplySoftDeleteQueryFilter(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
                {
                    // Explicitly specify the delegate type using Expression<Func<T, bool>>
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var propertyAccess = Expression.Property(parameter, "IsDeleted");
                    var notDeleted = Expression.Not(propertyAccess);
                    var lambda = Expression.Lambda(notDeleted, parameter);

                    modelBuilder.Entity(entityType.ClrType).HasQueryFilter((LambdaExpression) lambda);
                }
            }
        }
    }
}
