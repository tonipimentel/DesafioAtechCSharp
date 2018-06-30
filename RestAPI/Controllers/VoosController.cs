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
    public class VoosController : ApiController
    {
        public List<VooDTO> Get()
        {
            using (VoosContext context = new VoosContext())
            {
                List<VooDTO> voos = (from v in context.Voos
                                     join sv in context.StatusVoos
                                     on v.StatusVooID equals sv.StatusVooID
                                     join a in context.Aviaos
                                     on v.AviaoID equals a.AviaoID
                                     join co in context.Cidades
                                     on v.CidadeOrigemID equals co.CidadeID
                                     join eo in context.Estados
                                     on co.EstadoID equals eo.EstadoID
                                     join cd in context.Cidades
                                     on v.CidadeDestinoID equals cd.CidadeID
                                     join ed in context.Estados
                                     on cd.EstadoID equals ed.EstadoID
                                     select new VooDTO
                                     {
                                         VooID = v.VooID,
                                         StatusVoo = sv.Nome,
                                         Aviao = a.Modelo,
                                         Partida = v.Partida,
                                         Chegada = v.Chegada,
                                         CidadeOrigem = co.Nome + " - " + eo.Sigla,
                                         CidadeDestino = cd.Nome + " - " + ed.Sigla
                                     }).ToList();

                return voos;
            }
        }

        public VooDTO Get(int id)
        {
            using (VoosContext context = new VoosContext())
            {
                VooDTO voo = (from v in context.Voos
                              join sv in context.StatusVoos
                              on v.StatusVooID equals sv.StatusVooID
                              join a in context.Aviaos
                              on v.AviaoID equals a.AviaoID
                              join co in context.Cidades
                              on v.CidadeOrigemID equals co.CidadeID
                              join eo in context.Estados
                              on co.EstadoID equals eo.EstadoID
                              join cd in context.Cidades
                              on v.CidadeDestinoID equals cd.CidadeID
                              join ed in context.Estados
                              on cd.EstadoID equals ed.EstadoID
                              where v.VooID == id
                              select new VooDTO
                              {
                                  VooID = v.VooID,
                                  StatusVoo = sv.Nome,
                                  Aviao = a.Modelo,
                                  Partida = v.Partida,
                                  Chegada = v.Chegada,
                                  CidadeOrigem = co.Nome + " - " + eo.Sigla,
                                  CidadeDestino = cd.Nome + " - " + ed.Sigla
                              }).FirstOrDefault();

                if (voo == null)
                {
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
                }

                return voo;
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
