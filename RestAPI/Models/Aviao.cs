using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models
{
    public partial class Aviao
    {
        [Key]
        public int AviaoID { get; set; }
        public String Modelo { get; set; }
    }
}