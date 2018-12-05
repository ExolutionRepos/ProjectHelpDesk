using Library.Class.Enum;
using System;

namespace UI.Web.Models
{
    public class ClassGRID
    {
        public string CodigoChamado { get; set; }
        public string Descricao { get;  set; }
        public string Observacao { get;  set; }
        public EnumStatusChamado.StatusChamado Status { get;  set; }
        public DateTime? DataFinalizacao { get;  set; }
    }
}