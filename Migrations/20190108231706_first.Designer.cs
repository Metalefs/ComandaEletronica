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
    [Migration("20190108231706_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Copa", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdMenu");

                    b.Property<string>("Observacoes");

                    b.HasKey("IdPedido");

                    b.ToTable("Copa");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Cozinha", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdMenu");

                    b.Property<string>("Observacoes");

                    b.HasKey("IdPedido");

                    b.ToTable("Cozinha");
                });

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
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Img");

                    b.Property<string>("Nome");

                    b.Property<float>("Preco");

                    b.Property<string>("Tipo");

                    b.HasKey("IdMenu");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Mesa", b =>
                {
                    b.Property<int>("IdMesa")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Disponibilidade");

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

                    b.Property<int?>("FuncionarioIdFuncionario");

                    b.Property<int?>("ItensDoPedidoIdMenu");

                    b.Property<int?>("MesaDoPedidoIdMesa");

                    b.Property<string>("Observacoes");

                    b.Property<string>("PrazoDoPedido");

                    b.Property<float>("PrecoDoPedido");

                    b.Property<string>("TipoDoPedido");

                    b.HasKey("IdPedido");

                    b.HasIndex("FuncionarioIdFuncionario");

                    b.HasIndex("ItensDoPedidoIdMenu");

                    b.HasIndex("MesaDoPedidoIdMesa");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Pedido", b =>
                {
                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Funcionario")
                        .WithMany("Pedidos")
                        .HasForeignKey("FuncionarioIdFuncionario");

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Menu", "ItensDoPedido")
                        .WithMany()
                        .HasForeignKey("ItensDoPedidoIdMenu");

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Mesa", "MesaDoPedido")
                        .WithMany()
                        .HasForeignKey("MesaDoPedidoIdMesa");
                });
#pragma warning restore 612, 618
        }
    }
}
