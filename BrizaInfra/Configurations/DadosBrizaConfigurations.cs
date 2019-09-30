using DomainBriza;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrizaInfra.Configurations
{
   public class DadosBrizaConfigurations : IEntityTypeConfiguration<DadosBriza>
    {
       
        public void Configure(EntityTypeBuilder<DadosBriza> modelBuilder)
        {

            //modelBuilder.
            //  ToTable("Dados_Briza");

            modelBuilder.ToTable("Dados_Briza");

            modelBuilder.
                Property(d => d.Nome).
                IsRequired().HasColumnName("Nome").HasMaxLength(100);

            modelBuilder.HasKey(d => d.Id);
            modelBuilder.Property(d => d.Id).HasColumnName("Id")
                .ValueGeneratedOnAdd();

            modelBuilder.
             Property(d => d.Email).
             IsRequired().HasColumnName("Email").HasMaxLength(100);

            modelBuilder.
           Property(d => d.DataCadastro).
           IsRequired().HasColumnName("DataCadastro");
        }
    }
}
