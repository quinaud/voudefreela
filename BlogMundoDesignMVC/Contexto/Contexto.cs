using System.Data.Entity;
using BlogMundoDesignMVC.EntityConfig;
using BlogMundoDesignMVC.Models;

namespace BlogMundoDesignMVC.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DefaultConnection")
        {
            
        }

        public DbSet<Profissional> Profissionais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProfissionalConfig());
        }
    }
}