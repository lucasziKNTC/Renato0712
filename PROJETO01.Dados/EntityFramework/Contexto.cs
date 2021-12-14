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
                                    Database = BD040161; 
                                    User ID = RA040161;
                                    Password = 040161";

            optionsBuilder.UseSqlServer(conn);
        }

        //Nome das Classes que representarão o Banco de Dados
        public DbSet<Estado> Estado { get; set; }

        public DbSet<Cidade> Cidade { get; set; }

        public DbSet<Cadastro> Cadastro { get; set; }

        public DbSet<Corrida> Corrida { get; set; }

        public DbSet<Motorista> Motorista { get; set; }


        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>()
                .ToTable("Estado")
                .HasKey("UF");

            modelBuilder.Entity<Estado>()
                .Property(p => p.UF)
                .HasColumnName("uf")
                .HasColumnType("char(2)")
                .IsRequired();

            modelBuilder.Entity<Estado>()
                .Property("Nome")
                .HasColumnName("nome")
                .HasColumnType("varchar(200)")
                .IsRequired();
            //--------------------------------------------------
            modelBuilder.Entity<Cidade>()
             .Property(p => p.CidadeID)
             .HasColumnName("cidadeId")
             .HasColumnType("int")
             .IsRequired();

            modelBuilder.Entity<Cidade>()
             .Property(p => p.Nome)
             .HasColumnName("Nome")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Cidade>()
           .Property(p => p.UF)
           .HasColumnName("UF")
           .HasColumnType("char(2)")
           .IsRequired();
            //--------------------------------------------------

            modelBuilder.Entity<Cadastro>()
                .ToTable("CadastroDePessoa")
                .HasKey("PessoaId");

            modelBuilder.Entity<Cadastro>()
             .Property(p => p.PessoaId)
             .HasColumnName("PessoaId")
             .HasColumnType("int")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property(p => p.Nome)
             .HasColumnName("Nome")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property(p => p.Cpf)
             .HasColumnName("Cpf")
             .HasColumnType("char(11)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
            .Property(p => p.Cep)
            .HasColumnName("Cep")
            .HasColumnType("char(8)");

            modelBuilder.Entity<Cadastro>()
            .Property(p => p.Numero)
            .HasColumnName("Numero")
            .HasColumnType("int")
            .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property(p => p.Bairro)
             .HasColumnName("Bairro")
             .HasColumnType("varchar(50)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property(p => p.Complemento)
             .HasColumnName("Complemento")
             .HasColumnType("varchar(12)")
             .IsRequired();

            modelBuilder.Entity<Cadastro>()
             .Property(p => p.CidadeID)
             .HasColumnName("CidadeID")
             .HasColumnType("int")
             .IsRequired();

            //


            modelBuilder.Entity<Corrida>()
            .ToTable("SolicitaçãoCorrida")
            .HasKey("IdSolicitacao");


            modelBuilder.Entity<Corrida>()
            .Property(p => p.IdSolicitacao)
            .HasColumnName("IdSolicitação")
            .HasColumnType("int")
            .IsRequired();

            modelBuilder.Entity<Corrida>()
           .Property(p => p.PessoaId)
           .HasColumnName("PessoaId")
           .HasColumnType("int")
           .IsRequired();




            modelBuilder.Entity<Corrida>()
            .Property(p => p.MotoristaId)
             .HasColumnName("MotoristaId")
             .HasColumnType("int")
             .IsRequired();

            modelBuilder.Entity<Corrida>()
             .Property(p => p.Avaliacao)
            .HasColumnName("Avaliaco")
            .HasColumnType("varchar(100)")
            .IsRequired();

            modelBuilder.Entity<Corrida>()
          .Property("CidadeId")
          .HasColumnName("CidadeId")
          .HasColumnType("int")
          .IsRequired();



            //

            modelBuilder.Entity<Motorista>()
           .Property(p => p.MotoristaId)
           .HasColumnName("MotoristaId")
           .HasColumnType("int")
           .IsRequired();

            modelBuilder.Entity<Motorista>()
        .Property(p => p.Nome)
        .HasColumnName("Nome")
        .HasColumnType("varchar(100)")
        .IsRequired();



            modelBuilder.Entity<Motorista>()
        .Property(p => p.CidadeId)
        .HasColumnName("CidadeId")
        .HasColumnType("int")
        .IsRequired();

            modelBuilder.Entity<Motorista>()
        .Property(p => p.Sexo)
        .HasColumnName("Sexo")
        .HasColumnType("char(1)")
        .IsRequired();

            modelBuilder.Entity<Motorista>()
        .Property(p => p.Telefone)
        .HasColumnName("Telefone")
        .HasColumnType("int")
        .IsRequired();

            //


            base.OnModelCreating(modelBuilder);
        }
    }
}
