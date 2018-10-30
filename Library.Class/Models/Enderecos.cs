using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{
    [Table("TBL_ENDERECO_NOVO_LIGACAO")]
    public class Enderecos : Notifiable
    {
        [Key]
        public int CodigoEndereco { get; private set; }

        public string Rua { get; private set; }
        
        public Enderecos(string rua)
        {
            //this.CodigoEndereco = codigoendereco;
            this.Rua = rua;

            new AddNotifications<Enderecos>(this)
        .IfNullOrInvalidLength(x => x.Rua, 5, 50, Resources.Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Endereço", "5", "50"));

        }

        public Enderecos(int CodigoEndereco)
        {
            //this.CodigoEndereco = codigoendereco;
            //this.Rua = rua;

            new AddNotifications<Enderecos>(this)
        .IfNullOrInvalidLength(x => x.Rua, 5, 50, Resources.Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Endereço", "5", "50"));

        }

        protected Enderecos() { }

    }
}
