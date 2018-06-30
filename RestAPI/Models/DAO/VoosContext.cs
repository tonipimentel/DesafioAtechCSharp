using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RestAPI.Models.DAO
{
    public class VoosContext : DbContext
    {
        public VoosContext() : base("name=VoosContext")
        {
        }

        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Aviao> Aviaos { get; set; }
        public virtual DbSet<StatusVoo> StatusVoos { get; set; }
        public virtual DbSet<Voo> Voos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
