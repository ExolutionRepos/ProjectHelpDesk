using prmToolkit.NotificationPattern;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{
    [Table("TBL_PERFIS")]
    public class Perfis : Notifiable
    {
        [Key]
        public int CodigoPerfil { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }


        public Perfis(int codigoperfil, string descricao, string nome)
        {
            this.CodigoPerfil = codigoperfil;
            this.Descricao = descricao;
            this.Nome = nome;
        }
    }
}

