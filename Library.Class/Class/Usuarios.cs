using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prmToolkit.NotificationPattern;

namespace Library.Class.Class
{
    class  Usuarios : Notifiable
    {
        public int CodigoUsuario { get; private set; }
        public string Nome { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public string Email { get; private set; }
        public string RG { get; private set; }
        public Enderecos endereco { get; private set; }
        public int Sexo { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }

        public Usuarios(string nome, DateTime? DataNascimento, string Email, string RG, int Sexo,
            string Telefone, string Celular)
        {
            this.Nome = nome;
            this.DataNascimento = DataNascimento;
            this.Email = Email;
            this.RG = RG;
            this.Sexo = Sexo;
            this.Telefone = Telefone;
            this.Celular = Celular;
        }

        private void ValidarDados()
        {
            
        }
    }

}
