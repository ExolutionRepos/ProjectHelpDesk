using prmToolkit.NotificationPattern;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{
    [Table("TBL_CONFIGURACAOFONTE")]
    public class ConfigFont : Notifiable
    {
        [Key]
        public int Codigo_ConfigFont { get; private set; }

        //FontFamily
        public string Fonte { get; private set; }

        public float Tamanho { get; private set; }

        public int CodigoUsuario { get; private set; }
        [ForeignKey("CodigoUsuario")]
        public virtual Usuarios Usuario { get; private set; }

        public ConfigFont(string fonte, float tamanho)
        {
            this.Fonte = fonte;
            this.Tamanho = tamanho;

            Validar();
        }


        public ConfigFont AlterarConfigFont(string fonte, float tamanho)
        {
            this.Fonte = fonte;
            this.Tamanho = tamanho;

            Validar();

            return this;
        }

        private void Validar()
        {

        }

        protected ConfigFont()
        {

        }

        
    }
}
