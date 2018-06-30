using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models.DTO
{
    public class StatusVooDTO
    {
        public int StatusVooID { get; set; }
        public String Descricao { get; set; }
    }
}