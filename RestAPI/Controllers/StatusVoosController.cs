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
    public class StatusVoosController : ApiController
    {
        public List<StatusVooDTO> Get()
        {
            using (VoosContext context = new VoosContext())
            {
                List<StatusVooDTO> statusVoos = context.StatusVoos
                    .Select(a => new StatusVooDTO
                    {
                        StatusVooID = a.StatusVooID,
                        Descricao = a.Nome
                    }).ToList();

                return statusVoos;
            }
        }

        public StatusVooDTO Get(int id)
        {
            using (VoosContext context = new VoosContext())
            {
                StatusVooDTO statusVoo = context.StatusVoos.Where(a => a.StatusVooID == id)
                    .Select(a => new StatusVooDTO
                    {
                        StatusVooID = a.StatusVooID,
                        Descricao = a.Nome
                    }).FirstOrDefault();

                if (statusVoo == null)
                {
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
                }

                return statusVoo;
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
