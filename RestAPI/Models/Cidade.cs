using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models
{
    public partial class Cidade
    {
        [Key]
        public int CidadeID { get; set; }
        public String Nome { get; set; }
        public int EstadoID { get; set; }

        public virtual Estado Estado { get; set; }
    }
}