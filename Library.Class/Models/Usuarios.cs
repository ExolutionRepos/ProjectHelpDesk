using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Class.Enum.EnumSexo;

namespace Library.Class.Models
{
    [Table("TBL_USUARIOS_NOVO_LIGACAO")]
    public class Usuarios : Notifiable
    {
        [Key]
        public int CodigoUsuario { get; private set; }

        public string Nome { get; private set; }

        public DateTime ? DataNascimento { get; private set; }

        public string Email { get; private set; }

        public string CPF { get; private set; }

        public Sexo Sexo { get; private set; }

        public string Telefone { get; private set; }

        public string Celular { get; private set; }


        public int CodigoEndereco { get; private set; }

        [ForeignKey("CodigoEndereco")]
        public virtual Enderecos Endereco { get; private set; }

        //public virtual Logins Logins { get; private set; }

        public Usuarios(string nome, DateTime? datanascimento, string email, string cpf, Sexo sexo,
            string telefone, string celular
            , Enderecos endereco
            )
        {
            this.Nome = nome;
            this.DataNascimento = datanascimento;
            this.Email = email;
            this.CPF = cpf;
            this.Sexo = sexo;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Endereco = endereco;
            
                new AddNotifications<Usuarios>(this)
            .IfNullOrInvalidLength(x => x.Nome, 5, 50, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Nome do usuarios", "5", "50"))
            .IfNotEmail(x => x.Email, Message.X0_INVALIDO.ToFormat("Email informado"))
            .IfNullOrEmpty(x => x.Celular, Message.X0_NAO_INFORMADO.ToFormat("Celular"))
            .IfNotCpf(x => x.CPF, Message.X0_INVALIDO.ToFormat("CPF"))
            .IfNullOrInvalidLength(x => x.Telefone, 8, 11, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Telefone 1", "8", "11"))
            .IfNullOrInvalidLength(x => x.Celular, 8, 11, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Telefone 2", "8", "11"))
            .IfNotDate(x => x.DataNascimento.Value.ToString(), Message.X0_INVALIDA.ToFormat("Data de Nascimento"));
                
            AddNotifications(endereco);
        }

        public Usuarios(int codigousuario, string nome, DateTime? datanascimento, string email, string cpf, Sexo sexo,
            string telefone, string celular
            , Enderecos endereco, int codigoendereco)
        {

            this.Nome = nome;
            this.DataNascimento = datanascimento;
            this.Email = email;
            this.CPF = cpf;
            this.Sexo = sexo;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Endereco = endereco;
            //this.Endereco.CodigoEndereco = codigoendereco;

            new AddNotifications<Usuarios>(this)
        .IfNullOrInvalidLength(x => x.Nome, 5, 50, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Nome do usuarios", "5", "50"))
        .IfNotEmail(x => x.Email, Message.X0_INVALIDO.ToFormat("Email informado"))
        .IfNullOrEmpty(x => x.Celular, Message.X0_NAO_INFORMADO.ToFormat("Celular"))
        .IfNotCpf(x => x.CPF, Message.X0_INVALIDO.ToFormat("CPF"))
        .IfNullOrInvalidLength(x => x.Telefone, 8, 11, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Telefone 1", "8", "11"))
        .IfNullOrInvalidLength(x => x.Celular, 8, 11, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Telefone 2", "8", "11"))
        .IfNotDate(x => x.DataNascimento.Value.ToString(), Message.X0_INVALIDA.ToFormat("Data de Nascimento"));

            AddNotifications(endereco);
        }

        protected Usuarios()
        {
        }

    }

}
