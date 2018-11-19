using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Class.Enum.EnumPerfil;

namespace Library.Class.Models
{
    [Table("TBL_PERFIS")]
    public class Perfis : Notifiable
    {
        //Enum TipoPerfils
        [Key]
        public int CodigoPerfil { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public ICollection<Logins> Login { get; private set; }

        public Perfis(string descricao, string nome)
        {
            this.Descricao = descricao;
            this.Nome = nome;

            Validar();

            Login = new HashSet<Logins>();
        }

        public Perfis AlterarPerfil(string descricao, string nome)
        {
            this.Descricao = descricao;
            this.Nome = nome;

            Login = new HashSet<Logins>();

            Validar();
            return this;
        }

        private void Validar()
        {
            new AddNotifications<Perfis>(this)
                .IfNullOrEmpty(Descricao, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Descricao"))
                .IfNullOrEmpty(Nome, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Tipo "));
        }

        protected Perfis()
        {
            Login = new HashSet<Logins>();
        }
    }
}

