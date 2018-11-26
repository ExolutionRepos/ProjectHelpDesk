using Library.Class.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using UI.Business.Interfaces.Repositories;
using UI.Business.Interfaces.Services;

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
        public DbSet<Log> Logs { get; set; }


        public void SALVAR()
        {
            var a = "";
            try
            {
                this.SaveChanges();
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



        //public override int SaveChanges()
        //{
        //    // Detecta as alterações existentes na instância corrente do DbContext.
        //    this.ChangeTracker.DetectChanges();
        //    // Identifica as entidades que devem gerar registros em log.
        //    var entries = DetectEntries();
        //    // Cria lista para armazenamento temporário dos registros em log.
        //    List<Log> logs = new List<Log>(entries.Count());

        //    // Varre as entidades que devem gerar registros em log.
        //    foreach (var entry in entries)
        //    {
        //        // Cria novo registro de log.
        //        Log newLog = GetLog(entry);
                
        //        if (newLog != null)
        //            logs.Add(newLog);
        //    }
        //    // Adiciona os registros de log na fonte de dados.
        //    foreach (var item in logs)
        //    {
        //        this.Entry(item).State = EntityState.Added;
        //    }
        //    // Persiste as informações na fonte de dados.
        //    return base.SaveChanges();
        //}

        /// <summary>
        /// Identifica quais entidades devem ser gerar registros de log.
        /// </summary>
        private IEnumerable<DbEntityEntry> DetectEntries()
        {
            return ChangeTracker.Entries().Where(e => (e.State == EntityState.Modified ||
                                                        e.State == EntityState.Added ||
                                                        e.State == EntityState.Deleted) &&
                                                        e.Entity.GetType() != typeof(Log));
        }

        /// <summary>
        /// Cria os registros de log.
        /// </summary>
        private Log GetLog(DbEntityEntry entry)
        {

            Log returnValue = null;

            if (entry.State == EntityState.Added)
            {
                returnValue = GetInsertLog(entry);
            }
            else if (entry.State == EntityState.Modified)
            {
                returnValue = GetUpdateLog(entry);
            }
            else if (entry.State == EntityState.Deleted)
            {
                returnValue = GetDeleteLog(entry);
            }

            return returnValue;
        }

        private Log GetInsertLog(DbEntityEntry entry)
        {

            return Log.CreateInsertLog(entry.Entity);
        }

        private Log GetDeleteLog(DbEntityEntry entry)
        {

            return Log.CreateDeleteLog(entry.Entity);
        }

        private Log GetUpdateLog(DbEntityEntry entry)
        {

            object originalValue = null;

            if (entry.OriginalValues != null)
                originalValue = entry.OriginalValues.ToObject();
            else
                originalValue = entry.GetDatabaseValues().ToObject();

            return Log.CreateUpdateLog(originalValue, entry.Entity);
        }

    }
}
