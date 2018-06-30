using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models.DTO
{
    public class VooDTO
    {
        public int VooID { get; set; }
        public String StatusVoo { get; set; }
        public String Aviao { get; set; }
        public TimeSpan Partida { get; set; }
        public TimeSpan Chegada { get; set; }
        public String CidadeOrigem { get; set; }
        public String CidadeDestino { get; set; }
    }
}