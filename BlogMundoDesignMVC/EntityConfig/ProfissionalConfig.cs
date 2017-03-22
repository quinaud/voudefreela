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
                .IsOptional()
                .HasMaxLength(20)
                .HasColumnType("varchar");


            Property(c => c.Sobrenome)
                .IsOptional()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(c => c.Email)
                .IsOptional()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(c => c.Telefone)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(c => c.Idade)
                .IsOptional()
                .IsRequired();

            Property(c => c.Sexo)
                .IsOptional();

            Property(c => c.Logradouro)
                .IsOptional()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(c => c.Bairro)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(c => c.Cidade)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(c => c.Estado)
                .IsOptional()
                .HasMaxLength(2)
                .HasColumnType("varchar");

            Property(c => c.PossuiExperiencia)
                .IsOptional();

            //Property(c => c.TipoExperiencia)
            //    .IsOptional()
            //    .HasMaxLength(50)
            //    .HasColumnType("varchar");

            Property(c => c.ExperienciaGarcom)
                .IsOptional();

            Property(c => c.ExperienciaBarman)
                .IsOptional();

            Property(c => c.ExperienciaSeguranca)
                .IsOptional();

            Property(c => c.ExperienciaDj)
                .IsOptional();

            Property(c => c.ExperienciaCopeiro)
                .IsOptional();

            Property(c => c.ExperienciaFritadeira)
                .IsOptional();

            Property(c => c.ExperienciaHostness)
                .IsOptional();

            Property(c => c.ExperienciaMusico)
                .IsOptional();

            Property(c => c.ExperienciaCaixa)
                .IsOptional();

            Property(c => c.ExperienciaPromotorEventos)
                .IsOptional();

            Property(c => c.ExperienciaAnimadorFestas)
                .IsOptional();

            Property(c => c.ExperienciaManobrista)
                .IsOptional();

            Property(c => c.ExperienciaSevicosGerais)
                .IsOptional();

            Property(c => c.ExperienciaFotografo)
                .IsOptional();




            Property(c => c.LocalExperiencia)
                .IsOptional()
                .HasMaxLength(400)
                .HasColumnType("varchar");

            Property(c => c.EfetuouPagamento)
                .IsOptional();

            ToTable("Profissionais");
        }
    }
}