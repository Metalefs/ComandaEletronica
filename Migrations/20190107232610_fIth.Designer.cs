﻿// <auto-generated />
using System;
using Ia_ComandaRestaurante.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ia_ComandaRestaurante.Migrations
{
    [DbContext(typeof(Ia_ComandaRestauranteContext))]
    [Migration("20190107232610_fIth")]
    partial class fIth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cargo");

                    b.Property<string>("NomeDoFuncionario");

                    b.Property<string>("SenhaDeAcesso");

                    b.HasKey("IdFuncionario");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Img");

                    b.Property<string>("Nome");

                    b.Property<int?>("PedidoIdPedido");

                    b.Property<float>("Preco");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("PedidoIdPedido");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Mesa", b =>
                {
                    b.Property<int>("IdMesa")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Disponivel");

                    b.Property<string>("NomeDoCliente");

                    b.Property<int>("NumeroDaMesa");

                    b.Property<string>("Observacoes");

                    b.Property<int>("QuantidadeDePessoas");

                    b.HasKey("IdMesa");

                    b.ToTable("Mesa");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Estado");

                    b.Property<int?>("FuncionarioResponsavelIdFuncionario");

                    b.Property<int>("ItensCopa");

                    b.Property<int>("ItensCozinha");

                    b.Property<int?>("MesaDoPedidoIdMesa");

                    b.Property<string>("Observacoes");

                    b.Property<int>("PrazoDoPedido");

                    b.Property<float>("PrecoDoPedido");

                    b.HasKey("IdPedido");

                    b.HasIndex("FuncionarioResponsavelIdFuncionario");

                    b.HasIndex("MesaDoPedidoIdMesa");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Menu", b =>
                {
                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Pedido")
                        .WithMany("ItensDoPedido")
                        .HasForeignKey("PedidoIdPedido");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Pedido", b =>
                {
                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Funcionario", "FuncionarioResponsavel")
                        .WithMany("Pedidos")
                        .HasForeignKey("FuncionarioResponsavelIdFuncionario");

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Mesa", "MesaDoPedido")
                        .WithMany()
                        .HasForeignKey("MesaDoPedidoIdMesa");
                });
#pragma warning restore 612, 618
        }
    }
}
