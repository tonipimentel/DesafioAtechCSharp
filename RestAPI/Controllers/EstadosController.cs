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
    public class EstadosController : ApiController
    {
        public List<EstadoDTO> Get()
        {
            using (VoosContext context = new VoosContext())
            {
                List<EstadoDTO> estados = context.Estados
                    .Select(a => new EstadoDTO
                    {
                        EstadoID = a.EstadoID,
                        Nome = a.Nome,
                        Sigla = a.Sigla
                    }).ToList();

                return estados;
            }
        }

        public EstadoDTO Get(int id)
        {
            using (VoosContext context = new VoosContext())
            {
                EstadoDTO estado = context.Estados.Where(a => a.EstadoID == id)
                    .Select(a => new EstadoDTO
                    {
                        EstadoID = a.EstadoID,
                        Nome = a.Nome,
                        Sigla = a.Sigla
                    }).FirstOrDefault();

                if (estado == null)
                {
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
                }

                return estado;
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
