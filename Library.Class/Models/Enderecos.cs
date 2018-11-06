using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{
    [Table("TBL_ENDERECO")]
    public class Enderecos : Notifiable
    {
        [Key]
        public int CodigoEndereco { get; private set; }

        public string Rua { get; private set; }

        public string Bairro { get; private set; }

        public string CEP { get; private set; }

        public string Cidade { get; private set; }

        public string UF { get; private set; }

        //public string Complemento { get; private set; }

        public int? Numero { get; private set; }

        public ICollection<Usuarios> Usuario { get; private set; }
        
        public Enderecos(string rua, string bairro, string cep, string cidade, int? numero, string uf
            //, string complemento
            )
        {
            this.Rua = rua;
            this.Bairro = bairro;
            this.CEP = cep;
            this.Cidade = cidade;
            this.Numero = numero;
            this.UF = uf;
            //this.Complemento = complemento;

            Usuario = new HashSet<Usuarios>();
            Validar();
        }

        public Enderecos AlterarEnderecos(string rua, string bairro, string cep, string cidade, int? numero, string uf, Usuarios usuario
           //, string complemento
           )
        {
            Usuario = new HashSet<Usuarios>();

            this.Rua = rua;
            this.Bairro = bairro;
            this.CEP = cep;
            this.Cidade = cidade;
            this.Numero = numero;
            this.UF = uf;
            //this.Complemento = complemento;

            this.Usuario.Add(usuario);
            
            Validar();

            return this;
        }


        protected void Validar()
        {

            new AddNotifications<Enderecos>(this)
        .IfNullOrInvalidLength(x => x.Rua, 5, 50, Resources.Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Endereço", "5", "50"));

        }

        protected Enderecos()
        {
            Usuario = new HashSet<Usuarios>();
        }

    }
}
