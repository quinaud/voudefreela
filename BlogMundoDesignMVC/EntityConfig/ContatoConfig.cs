using System.Data.Entity.ModelConfiguration;
using BlogMundoDesignMVC.Models;

namespace BlogMundoDesignMVC.EntityConfig
{
    public class ContatoConfig : EntityTypeConfiguration<Contato>
    {
        public ContatoConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Telefone)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(20);

            Property(c => c.Mensagem)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(400);

            ToTable("Contatos");
        }
    }
}