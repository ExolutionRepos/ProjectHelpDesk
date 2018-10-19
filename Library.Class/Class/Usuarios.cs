using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Class
{
    [Table("tbl_Usuarios")]
    public class Usuarios : Notifiable
    {
        [Key]
        public int CodigoUsuario { get; private set; }

        public string Nome { get; private set; }

        public DateTime? DataNascimento { get; private set; }

        public string Email { get; private set; }

        public string RG { get; private set; }

        public Enderecos Endereco { get; private set; }

        public Enum.EnumSexo Sexo { get; private set; }

        public string Telefone { get; private set; }

        public string Celular { get; private set; }

        public Usuarios(string nome, DateTime? datanascimento, string email, string rg, Enum.EnumSexo sexo,
            string telefone, string celular, Enderecos endereco)
        {
            this.Nome = nome;
            this.DataNascimento = datanascimento;
            this.Email = email;
            this.RG = rg;
            this.Sexo = sexo;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Endereco = endereco;

            new AddNotifications<Usuarios>(this)
                .IfNullOrInvalidLength(x => x.Nome, 5, 50, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Nome do usuarios", "5", "50"))
                .IfNotEmail(x => x.Email, Message.X0_INVALIDO.ToFormat("Email informado"))
                .IfNullOrEmpty(x => x.Celular, Message.X0_NAO_INFORMADO.ToFormat("Celular"));

            AddNotifications(endereco);
        }

        
        public Usuarios(string nome)
        {
            this.Nome = nome;

            new AddNotifications<Usuarios>(this)
                .IfNullOrInvalidLength(x => x.Nome, 5, 50, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Nome do usuarios", "5", "50"));
        }


    }

}
