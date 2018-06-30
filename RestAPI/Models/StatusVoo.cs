using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models
{
    public partial class StatusVoo
    {
        [Key]
        public int StatusVooID { get; set; }
        public String Nome { get; set; }
    }
}