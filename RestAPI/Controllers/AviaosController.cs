using RestAPI.Models;
using RestAPI.Models.DAO;
using RestAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPI.Controllers
{
    public class AviaosController : ApiController
    {
        public List<AviaoDTO> Get()
        {
            using (VoosContext context = new VoosContext())
            {
                List<AviaoDTO> aviaos = context.Aviaos
                    .Select(a => new AviaoDTO
                    {
                        AviaoID = a.AviaoID,
                        Modelo = a.Modelo
                    }).ToList();

                return aviaos;
            }
        }

        public AviaoDTO Get(int id)
        {
            using (VoosContext context = new VoosContext())
            {
                AviaoDTO aviao = context.Aviaos.Where(a => a.AviaoID == id)
                    .Select(a => new AviaoDTO
                    {
                        AviaoID = a.AviaoID,
                        Modelo = a.Modelo
                    }).FirstOrDefault();

                if (aviao == null)
                {
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
                }

                return aviao;
            }
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
