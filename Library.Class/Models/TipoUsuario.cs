using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using static Library.Class.Enum.EnumTipoUsuario;

namespace Library.Class.Models
{
    [Table("TBL_TIPOUSUARIO")]

    public class TipoUsuarios : Notifiable
    {
        [Key]
        public int CodigoTipoUsuario { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public ICollection<Usuarios> Usuario { get; private set; }

        public TipoUsuarios(int codigotipousuario, string descricao, string nome)
        {
            this.CodigoTipoUsuario = codigotipousuario;
            this.Descricao = descricao;
            this.Nome = nome;
            Usuario = new HashSet<Usuarios>();
            
        }

        protected TipoUsuarios()
        {
            Usuario = new HashSet<Usuarios>();
        }
    }
}
