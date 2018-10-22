using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{
    [Table("TBL_PERFIS")]
    class Perfis
    {
        [Key]
        public int CodigoPerfil { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }


        public Perfis(int CodigoPerfil, string Descricao, string Nome)
        {
            this.CodigoPerfil = CodigoPerfil;
            this.Descricao = Descricao;
            this.Nome = Nome;
        }
    }
}

