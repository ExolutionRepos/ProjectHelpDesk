using Library.Class.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UI.Business.Interfaces.Repositories;

namespace UI.Business.Persistence
{
    public class BaseContext : DbContext, IUnitOfWork
    {
        public BaseContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<DbContext>(null);
        }
        
        public IDbSet<Usuarios> Usuarios { get; set; }
        public IDbSet<Enderecos> Enderecos { get; set; }
        public IDbSet<TipoUsuarios> TiposUsuarios { get; set; }
        public IDbSet<Logins> Logins { get; set; }
        public IDbSet<TipoChamados> TipoChamados { get; set; }
        public IDbSet<Chamados> Chamados { get; set; }
        public IDbSet<Departamentos> Departamentos { get; set; }
        public IDbSet<Perfis> Perfis { get; set; }
        
        public void SALVAR()
        {
            var a = "";
            try
            {
                base.SaveChanges();
            }
            catch (System.Exception e)
            {
                a = e.Message;
            }
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //
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
