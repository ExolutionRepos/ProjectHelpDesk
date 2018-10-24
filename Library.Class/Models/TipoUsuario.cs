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
        public TipoUsuario CodigoTipoUsuario { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }
        

        public TipoUsuarios(TipoUsuario codigotipousuario, string descricao, string nome)
        {
            this.CodigoTipoUsuario = codigotipousuario;
            this.Descricao = descricao;
            this.Nome = nome;

            new AddNotifications<TipoUsuarios>(this)
                .IfEnumInvalid(codigotipousuario, Message.X0_INVALIDA.ToFormat("Tipo usuario"));
        }

    }
}
