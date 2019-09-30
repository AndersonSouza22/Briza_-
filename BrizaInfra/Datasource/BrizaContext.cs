using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DomainBriza;
using BrizaInfra.Configurations;
namespace BrizaInfra.Datasource
{
    public class BrizaContext : DbContext
    {
        public BrizaContext(DbContextOptions<BrizaContext> options) : base(options)
        {
        }
        public DbSet<DadosBriza> DadosBriza { get; set; }
        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new DadosBrizaConfigurations());

           modelBuilder.Entity<DadosBriza>().ToTable("Dados_Briza","dbo");

            modelBuilder.Entity<DadosBriza>().
                Property(d => d.Nome).
                IsRequired().HasColumnName("Nome").HasMaxLength(100);

            modelBuilder.Entity<DadosBriza>().HasKey(d => d.Id);
            modelBuilder.Entity<DadosBriza>().Property(d => d.Id).HasColumnName("Id")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<DadosBriza>().
             Property(d => d.Email).
             IsRequired().HasColumnName("Email").HasMaxLength(100);

                modelBuilder.Entity<DadosBriza>().
           Property(d => d.DataCadastro).
           IsRequired().HasColumnName("DataCadastro");
        }
    }
}
