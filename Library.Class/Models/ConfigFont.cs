using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{
    [Table("TBL_CONFIGURACAOFONTE")]
    public class ConfigFont
    {
        [Key]
        public int Codigo_ConfigFont { get; private set; }

        //FontFamily
        public string Fonte { get; private set; }

        public float Tamanho { get; private set; }

        public ICollection<Usuarios> Usuario { get; private set; }

        protected ConfigFont()
        {
            Usuario = new HashSet<Usuarios>();
        }

        public ConfigFont(string fonte, float tamanho)
        {
            this.Fonte = fonte;
            this.Tamanho = tamanho;

        }

        public void AlterarConfigFont(string fonte, float tamanho)
        {
            this.Fonte = fonte;
            this.Tamanho = tamanho;

        }
    }
}
