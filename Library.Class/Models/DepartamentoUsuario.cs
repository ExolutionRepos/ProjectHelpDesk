using Library.Class.Models;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{
    [Table("TBL_DEPARTAMENTOUSUARIO")]

    public class DepartamentoUsuario : Notifiable
    {
        [Key]
        public int CodigoDepartamentoUsuario { get; private set; }

        public int CodigoDepartamento { get; private set; }

        public int CodigoUsuario { get; private set; }

        public DepartamentoUsuario(int codigodepartamentousuario, int codigodepartamento, int codigousuario)
        {
            this.CodigoDepartamentoUsuario = codigodepartamentousuario;
            this.CodigoDepartamento = codigodepartamento;
            this.CodigoUsuario = codigousuario;

        }

    }
}
