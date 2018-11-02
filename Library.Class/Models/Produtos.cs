using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Class.Enum.EnumMarca;
using static Library.Class.Enum.EnumModelo;

namespace Library.Class.Models
{
    [Table("TBL_PRODUTOS")]
    public class Produtos : Notifiable
    {
        [Key]
        public int CodigoProduto { get; private set; }
        
        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public DateTime? DataCompra { get; private set; }

        public DateTime? DataFabricacao { get; private set; }

        public Marcas Marca { get; private set; }

        public Modelos Modelo { get; private set; }

        public Produtos(DateTime ? datacompra, DateTime ? datafabricacao,string descricao, Marcas marca,
            Modelos modelo, string nome)
        {
            this.DataCompra = datacompra;
            this.DataFabricacao = datafabricacao;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Nome = nome;

            new AddNotifications<Produtos>(this)
                .IfEnumInvalid(y => y.Marca, Message.X0_INVALIDA.ToFormat("Marca"))
                .IfEnumInvalid(y => y.Modelo, Message.X0_INVALIDA.ToFormat("Modelo"))
                .IfNotDate(y => y.DataFabricacao.ToString(), Message.X0_INVALIDA.ToFormat("Data de fabricação"))
                .IfNotDate(y => y.DataCompra.ToString(), Message.X0_INVALIDA.ToFormat("Data de compra"));
        }

        public void AlterarProdutos(int codigoproduto, DateTime? datacompra, DateTime? datafabricacao, string descricao, Marcas marca,
            Modelos modelo, string nome)
        {

            this.CodigoProduto = codigoproduto;
            this.DataCompra = datacompra;
            this.DataFabricacao = datafabricacao;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Nome = nome;

            new AddNotifications<Produtos>(this)
                .IfEnumInvalid(y => y.Marca, Message.X0_INVALIDA.ToFormat("Marca"))
                .IfEnumInvalid(y => y.Modelo, Message.X0_INVALIDA.ToFormat("Modelo"))
                .IfNullOrEmpty(x => x.CodigoProduto.ToString(), Message.X0_NAO_INFORMADO.ToFormat("Celular"))
                .IfNotDate(y => y.DataFabricacao.ToString(), Message.X0_INVALIDA.ToFormat("Data de fabricação"))
                .IfNotDate(y => y.DataCompra.ToString(), Message.X0_INVALIDA.ToFormat("Data de compra"));
            
        }

        protected Produtos()
        {

        }
    }
}