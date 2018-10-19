using Library.Class.Class;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UI.Business.Persistence
{
    class BaseContext : DbContext
    {

        public BaseContext(string connectionString) : base(connectionString)
        {

        }

        public IDbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DbContext>(null);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
