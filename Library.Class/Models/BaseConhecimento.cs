﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace Library.Class.Models

{
    [Table("TBL_BASECONHECIMENTO")]
    public class BaseConhecimento : Notifiable
    {
        [Key, ForeignKey("TipoChamado")]
        public int CodigoBaseConhecimento { get; private set; }

        public int CodigoTipoChamado { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public string PalavraChave { get; private set; }

        public virtual TipoChamado TipoChamado { get; private set; }


        public BaseConhecimento(int codigobaseconhecimento, int codigotipochamado, string descricao, string nome,
            string palavrachave, TipoChamado tipochamado)
        {
            this.CodigoBaseConhecimento = codigobaseconhecimento;
            this.CodigoTipoChamado = tipochamado.CodigoTipoChamado;
            this.Descricao = descricao;
            this.Nome = nome;
            this.PalavraChave = palavrachave;

            new AddNotifications<BaseConhecimento>(this)
                .IfNullOrEmpty(this.Descricao, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Descricao"))
                .IfNullOrEmpty(this.Nome, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Nome"));
        }
    }
}
