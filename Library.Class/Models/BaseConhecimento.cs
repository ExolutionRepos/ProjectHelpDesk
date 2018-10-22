using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models

{
    [Table("TBL_BASECONHECIMENTO")]
    class BaseConhecimento
    {
        [Key]
        public int CodigoBaseConhecimento { get; private set; }

        public int Chamado { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public string PalavraChave { get; private set; }


        public BaseConhecimento(int CodigoBaseConhecimento, int Chamado, string Descricao, string Nome,
            string PalavraChave)
        {
            this.CodigoBaseConhecimento = CodigoBaseConhecimento;
            this.Chamado = Chamado;
            this.Descricao = Descricao;
            this.Nome = Nome;
            this.PalavraChave = PalavraChave;

        }
    }
