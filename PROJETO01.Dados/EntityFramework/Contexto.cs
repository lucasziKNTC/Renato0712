using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace PROJETO01.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data source = 201.62.57.93; 
                                     Database = dbLAB2_2020; 
                                     User ID = 201.62.57.93; 
                                     Password = 040161";
            optionsBuilder.UseSqlServer(conn);
        }

        //Nome das Classes que representarão o Banco de Dados
        public DbSet<Estado> Estado { get; set; }
        
        public DbSet<Cidade> Cidade { get; set; }

        public DbSet<Cadastro> Cadastro { get; set; }

        public DbSet<Corrida> Corrida { get; set; }


        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>()
                .ToTable("Estado")
                .HasKey("UF");

            modelBuilder.Entity<Estado>()
                .Property("UF")
                .HasColumnName("Sigla_Est")
                .HasColumnType("char(2)")
                .IsRequired();

            modelBuilder.Entity<Estado>()
                .Property("Nome")
                .HasColumnName("Nome_Est")
                .HasColumnType("varchar(100)")
                .IsRequired();



            modelBuilder.Entity<Cidade>()
             .Property("CidadeId")
             .HasColumnName("Nome_Est")
             .HasColumnType("int")
             .IsRequired();

            modelBuilder.Entity<Cidade>()
             .Property("Nome")
             .HasColumnName("Nome_Est")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Cidade>()
                .ToTable("Nome")
                .HasKey("UF");


            modelBuilder.Entity<Cadastro>()
             .Property("Nome")
             .HasColumnName("Nome_Est")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property("Endereço")
             .HasColumnName("Nome_Est")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property("Cpf")
             .HasColumnName("Nome_Est")
             .HasColumnType("char(11)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property("Cep")
             .HasColumnName("Nome_Est")
             .HasColumnType("char(8)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property("Numero")
             .HasColumnName("Nome_Est")
             .HasColumnType("int)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property("Bairro")
             .HasColumnName("Nome_Est")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property("Complemento")
             .HasColumnName("Nome_Est")
             .HasColumnType("varchar(50)")
             .IsRequired();


            modelBuilder.Entity<Corrida>()
             .Property("CodMotorista")
             .HasColumnName("Nome_Est")
             .HasColumnType("int")
             .IsRequired();

            modelBuilder.Entity<Corrida>()
             .Property("CodPassageiro")
             .HasColumnName("Nome_Est")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Corrida>()
                .ToTable("EstadoId")
                .HasKey("UF");

            modelBuilder.Entity<Corrida>()
            .Property("Cidade")
            .HasColumnName("Nome_Est")
            .HasColumnType("varchar(100)")
            .IsRequired();

            modelBuilder.Entity<Corrida>()
            .Property("Avaliacao")
            .HasColumnName("Nome_Est")
            .HasColumnType("varchar(100)")
            .IsRequired();



            base.OnModelCreating(modelBuilder);
        }
    }
}
