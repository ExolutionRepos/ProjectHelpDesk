using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Class
{
    [Table("TBL_ENDERECO_NOVO_LIGACAO")]
    public class Enderecos : Notifiable
    {
        [Key]
        public int CodigoEndereco { get; private set; }

        public string Rua { get; private set; }

        public virtual Usuarios Usuario { get; private set; }

        public Enderecos(int codigoendereco, string rua)
        {
            this.CodigoEndereco = codigoendereco;
            this.Rua = rua;
        }
    }
}
