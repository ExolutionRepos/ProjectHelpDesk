using Library.Class.Models;
using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{
    [Table("TBL_DEPARTAMENTOS")]
    public class Departamentos : Notifiable
    {
        [Key]
        public int? CodigoDepartamento { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public ICollection<Usuarios> Usuario { get; private set; }

        public ICollection<Chamados> Chamado { get; private set; }

        public Departamentos(string descricao, string nome)
        {
            this.Descricao = descricao;
            this.Nome = nome;

            //Usuario = new HashSet<Usuarios>();
            //Chamado = new HashSet<Chamados>();

            Validar();

        }

        public Departamentos AlterarDepartamento(string descricao, string nome)
        {
            this.Descricao = descricao;
            this.Nome = nome;

            Validar();

            return this;
        }

        private void Validar()
        {
            new AddNotifications<Departamentos>(this)
                .IfNullOrEmpty(Descricao, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Descricao"))
                .IfNullOrEmpty(Nome, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Tipo "));
        }


        protected Departamentos()
        {
            Chamado = new HashSet<Chamados>();
            Usuario = new HashSet<Usuarios>();
        }
    }
}
