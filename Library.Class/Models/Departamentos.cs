using Library.Class.Models;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{
    [Table("TBL_DEPARTAMENTOS")]
    public class Departamentos : Notifiable
    {
        [Key]
        public int CodigoDepartamento { get; private set; }
        
        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public ICollection<Usuarios> Usuario { get; private set; }

        public Departamentos(string descricao, string nome)
        {
            this.Descricao = descricao;
            this.Nome = nome;

            Usuario = new HashSet<Usuarios>();
        }
        
        protected Departamentos()
        {
            Usuario = new HashSet<Usuarios>();
        }
    }
}
