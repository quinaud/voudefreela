using System.Data.Entity.ModelConfiguration;
using BlogMundoDesignMVC.Models;

namespace BlogMundoDesignMVC.EntityConfig
{
    public class ProfissionalConfig : EntityTypeConfiguration<Profissional>
    {
        public ProfissionalConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar");


            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(c => c.Idade)
                .IsRequired();

            Property(c => c.Sexo)
                .IsRequired();

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(c => c.Bairro)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(c => c.Cidade)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(c => c.Estado)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnType("varchar");

            Property(c => c.PossuiExperiencia)
                .IsOptional();

            Property(c => c.TipoExperiencia)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(c => c.LocalExperiencia)
                .IsOptional()
                .HasMaxLength(400)
                .HasColumnType("varchar");


            ToTable("Profissionais");
        }
    }
}