using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models.DTO
{
    public class EstadoDTO
    {
        public int EstadoID { get; set; }
        public String Nome { get; set; }
        public String Sigla { get; set; }
    }
}