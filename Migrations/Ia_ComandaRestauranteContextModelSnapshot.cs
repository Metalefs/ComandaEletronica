﻿// <auto-generated />
using System;
using Ia_ComandaRestaurante.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ia_ComandaRestaurante.Migrations
{
    [DbContext(typeof(Ia_ComandaRestauranteContext))]
    partial class Ia_ComandaRestauranteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Copa", b =>
                {
                    b.Property<int>("idPedido")
                        .ValueGeneratedOnAdd();

                    b.HasKey("idPedido");

                    b.ToTable("Copa");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Cozinha", b =>
                {
                    b.Property<int>("idPedido")
                        .ValueGeneratedOnAdd();

                    b.HasKey("idPedido");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Img");

                    b.Property<string>("Nome");

                    b.Property<int?>("PedidoIdPedido");

                    b.Property<int?>("PedidoIdPedido1");

                    b.Property<int?>("PedidoIdPedido2");

                    b.Property<float>("Preco");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("PedidoIdPedido");

                    b.HasIndex("PedidoIdPedido1");

                    b.HasIndex("PedidoIdPedido2");

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

                    b.Property<int>("CopaidPedido");

                    b.Property<int?>("CozinhaidPedido");

                    b.Property<int>("Estado");

                    b.Property<int?>("FuncionarioResponsavelIdFuncionario");

                    b.Property<int?>("MesaDoPedidoIdMesa");

                    b.Property<string>("Observacoes");

                    b.Property<string>("PrazoDoPedido");

                    b.Property<float>("PrecoDoPedido");

                    b.Property<int>("SomaItensCopa");

                    b.Property<int>("SomaItensCozinha");

                    b.HasKey("IdPedido");

                    b.HasIndex("CopaidPedido");

                    b.HasIndex("CozinhaidPedido");

                    b.HasIndex("FuncionarioResponsavelIdFuncionario");

                    b.HasIndex("MesaDoPedidoIdMesa");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Menu", b =>
                {
                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Pedido")
                        .WithMany("ItensCopa")
                        .HasForeignKey("PedidoIdPedido");

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Pedido")
                        .WithMany("ItensCozinha")
                        .HasForeignKey("PedidoIdPedido1");

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Pedido")
                        .WithMany("ItensDoPedido")
                        .HasForeignKey("PedidoIdPedido2");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Pedido", b =>
                {
                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Copa")
                        .WithMany("PedidosCopa")
                        .HasForeignKey("CopaidPedido")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Cozinha")
                        .WithMany("PedidosCozinha")
                        .HasForeignKey("CozinhaidPedido");

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
