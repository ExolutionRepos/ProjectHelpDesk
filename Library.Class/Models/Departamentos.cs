using Library.Class.Models;
using prmToolkit.NotificationPattern;
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

        public int CodigoEndereco { get; private set; }

        public virtual Enderecos Endereco { get; private set; }

        public virtual DepartamentoUsuario DepartamentoUsuario { get; private set; }

        public Departamentos()
        {
                
        }

        public Departamentos(string descricao, 
            string nome, Enderecos endereco)
        {
            this.Descricao = descricao;
            this.CodigoEndereco = endereco.CodigoEndereco;
            this.Nome = nome;

            AddNotifications(Endereco);
        }

        public void AlterarDepartamentos(int codigodepartamento, string descricao,
            string nome, Enderecos endereco)
        {
            this.CodigoDepartamento = codigodepartamento;
            this.Descricao = descricao;
            this.CodigoEndereco = endereco.CodigoEndereco;
            this.Nome = nome;

            AddNotifications(Endereco);
        }
    }
}
