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
            //
            Database.SetInitializer<DbContext>(null);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Remove exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setar para usar varchar ou invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //Caso eu esqueça de informar o tamanho do campo ele irá colocar varchar de 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            base.OnModelCreating(modelBuilder);
        }
    }
}
