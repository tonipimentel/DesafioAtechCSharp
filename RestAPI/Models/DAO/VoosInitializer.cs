using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RestAPI.Models;

namespace RestAPI.Models.DAO
{
    public class VoosInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<VoosContext>
    {
        protected override void Seed(VoosContext context)
        {
            var estados = new List<Estado>
            {
                new Estado{EstadoID = 1, Sigla="AC", Nome = "Acre"},
                new Estado{EstadoID = 2, Sigla="AL", Nome = "Alagoas"},
                new Estado{EstadoID = 3, Sigla="AM", Nome = "Amazonas"},
                new Estado{EstadoID = 4, Sigla="AP", Nome = "Amapá"},
                new Estado{EstadoID = 5, Sigla="BA", Nome = "Bahia"},
                new Estado{EstadoID = 6, Sigla="CE", Nome = "Ceará"},
                new Estado{EstadoID = 7, Sigla="DF", Nome = "Distrito Federal"},
                new Estado{EstadoID = 8, Sigla="ES", Nome = "Espírito Santo"},
                new Estado{EstadoID = 9, Sigla="GO", Nome = "Goiás"},
                new Estado{EstadoID = 10, Sigla="MA", Nome = "Maranhão"},
                new Estado{EstadoID = 11, Sigla="MG", Nome = "Minas Gerais"},
                new Estado{EstadoID = 12, Sigla="MS", Nome = "Mato Grosso do Sul"},
                new Estado{EstadoID = 13, Sigla="MT", Nome = "Mato Grosso"},
                new Estado{EstadoID = 14, Sigla="PA", Nome = "Para"},
                new Estado{EstadoID = 15, Sigla="PB", Nome = "Paraíba"},
                new Estado{EstadoID = 16, Sigla="PE", Nome = "Pernambuco"},
                new Estado{EstadoID = 17, Sigla="PI", Nome = "Piauí"},
                new Estado{EstadoID = 18, Sigla="PR", Nome = "Paraná"},
                new Estado{EstadoID = 19, Sigla="RJ", Nome = "Rio de Janeiro"},
                new Estado{EstadoID = 20, Sigla="RN", Nome = "Rio Grande do Norte"},
                new Estado{EstadoID = 21, Sigla="RO", Nome = "Rondônia"},
                new Estado{EstadoID = 22, Sigla="RR", Nome = "Roraima"},
                new Estado{EstadoID = 23, Sigla="RS", Nome = "Rio Grande do Sul"},
                new Estado{EstadoID = 24, Sigla="SC", Nome = "Santa Catarina"},
                new Estado{EstadoID = 25, Sigla="SE", Nome = "Sergipe"},
                new Estado{EstadoID = 26, Sigla="SP", Nome = "São Paulo"},
                new Estado{EstadoID = 27, Sigla="TO", Nome = "Tocantins"}
            };
            estados.ForEach(e => context.Estados.Add(e));
            context.SaveChanges();

            var cidades = new List<Cidade>
            {
                new Cidade{CidadeID = 1, EstadoID = 19, Nome = "Rio de Janeiro"},
                new Cidade{CidadeID = 2, EstadoID = 26, Nome = "São Paulo"}
            };
            cidades.ForEach(c => context.Cidades.Add(c));
            context.SaveChanges();

            var aviaos = new List<Aviao>
            {
                new Aviao{AviaoID = 1, Modelo = "Airbus 1"},
                new Aviao{AviaoID = 2, Modelo = "Boeing 1"}
            };
            aviaos.ForEach(a => context.Aviaos.Add(a));
            context.SaveChanges();

            var statusVoos = new List<StatusVoo>
            {
                new StatusVoo{StatusVooID = 1, Nome = "Estacionado"},
                new StatusVoo{StatusVooID = 2, Nome = "Voando"}
            };
            statusVoos.ForEach(sv => context.StatusVoos.Add(sv));
            context.SaveChanges();

            var voos = new List<Voo>
            {
                new Voo{VooID = 1, CidadeDestinoID = 1, Partida = new TimeSpan(12, 55, 00), CidadeOrigemID = 2, Chegada = new TimeSpan(13, 50, 00), StatusVooID = 1, AviaoID = 1 },
                new Voo{VooID = 2, CidadeDestinoID = 2, Partida = new TimeSpan(12, 55, 00), CidadeOrigemID = 1, Chegada = new TimeSpan(13, 50, 00), StatusVooID = 1, AviaoID = 2 },
                new Voo{VooID = 3, CidadeDestinoID = 2, Partida = new TimeSpan(14, 50, 00), CidadeOrigemID = 1, Chegada = new TimeSpan(15, 45, 00), StatusVooID = 1, AviaoID = 1 },
                new Voo{VooID = 4, CidadeDestinoID = 1, Partida = new TimeSpan(14, 50, 00), CidadeOrigemID = 2, Chegada = new TimeSpan(15, 45, 00), StatusVooID = 1, AviaoID = 2 },
                new Voo{VooID = 5, CidadeDestinoID = 1, Partida = new TimeSpan(16, 45, 00), CidadeOrigemID = 2, Chegada = new TimeSpan(17, 40, 00), StatusVooID = 1, AviaoID = 1 },
                new Voo{VooID = 6, CidadeDestinoID = 2, Partida = new TimeSpan(16, 45, 00), CidadeOrigemID = 1, Chegada = new TimeSpan(17, 40, 00), StatusVooID = 1, AviaoID = 2 },
                new Voo{VooID = 7, CidadeDestinoID = 2, Partida = new TimeSpan(18, 40, 00), CidadeOrigemID = 1, Chegada = new TimeSpan(19, 35, 00), StatusVooID = 2, AviaoID = 1 },
                new Voo{VooID = 8, CidadeDestinoID = 1, Partida = new TimeSpan(18, 40, 00), CidadeOrigemID = 2, Chegada = new TimeSpan(19, 35, 00), StatusVooID = 2, AviaoID = 2 }
            };
            voos.ForEach(v => context.Voos.Add(v));
            context.SaveChanges();
        }
    }
}