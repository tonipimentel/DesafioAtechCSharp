using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models
{
    public partial class Voo
    {
        [Key]
        public int VooID { get; set; }
        public int StatusVooID { get; set; }
        public int AviaoID { get; set; }
        public TimeSpan Partida { get; set; }
        public TimeSpan Chegada { get; set; }
        public int CidadeOrigemID { get; set; }
        public int CidadeDestinoID { get; set; }

        public virtual StatusVoo StatusVoo { get; set; }
        public virtual Aviao Aviao { get; set; }
        public virtual Cidade CidadeOrigem { get; set; }
        public virtual Cidade CidadeDestino { get; set; }
    }
}