using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{
    [Table("TBL_PRODUTOS")]
    class Produtos
    {
        [Key]
        public int CodigoProduto { get; private set; }

        public DateTime DataCompra { get; private set; }

        public DateTime DataFabricacao { get; private set; }

        public string Descricao { get; private set; }

        public string Marca { get; private set; }

        public string Modelo { get; private set; }

        public string Nome { get; private set; }


        public Produtos(int CodigoProduto, DateTime DataCompra, DateTime DataFabricacao, string Descricao, string Marca,
            string Modelo, string nome)
        {
            this.CodigoProduto = CodigoProduto;
            this.DataCompra = DataCompra;
            this.DataFabricacao = DataFabricacao;
            this.Descricao = Descricao;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Nome = Nome;



        }
    }
}