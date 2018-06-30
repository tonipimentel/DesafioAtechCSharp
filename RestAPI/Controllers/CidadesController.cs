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
    public class CidadesController : ApiController
    {
        public List<CidadeDTO> Get()
        {
            using (VoosContext context = new VoosContext())
            {
                List<CidadeDTO> cidades = context.Cidades
                    .Select(a => new CidadeDTO
                    {
                        CidadeID = a.CidadeID,
                        Nome = a.Nome,
                        Estado = a.Estado.Nome,
                    }).ToList();

                return cidades;
            }
        }

        public CidadeDTO Get(int id)
        {
            using (VoosContext context = new VoosContext())
            {
                CidadeDTO cidade = context.Cidades.Where(a => a.CidadeID == id)
                    .Select(a => new CidadeDTO
                    {
                        CidadeID = a.CidadeID,
                        Nome = a.Nome,
                        Estado = a.Estado.Nome
                    }).FirstOrDefault();

                if (cidade == null)
                {
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
                }

                return cidade;
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
