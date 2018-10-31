using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Class.Enum.EnumPerfil;

namespace Library.Class.Models
{
    [Table("TBL_PERFIS")]
    public class Perfis : Notifiable
    {
        [Key]
        public TipoPerfils CodigoPerfil { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public ICollection<Logins> Login { get; private set; }

        public Perfis(TipoPerfils codigoperfil,string descricao, string nome)
        {
            this.CodigoPerfil = codigoperfil;
            this.Descricao = descricao;
            this.Nome = nome;

            Login = new HashSet<Logins>();
        }

        protected Perfis()
        {

        }
    }
}

