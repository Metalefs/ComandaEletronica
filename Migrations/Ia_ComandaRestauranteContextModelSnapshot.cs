﻿// <auto-generated />
using System;
using Ia_ComandaRestaurante.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComandaEletronica.Migrations
{
    [DbContext(typeof(Ia_ComandaRestauranteContext))]
    partial class Ia_ComandaRestauranteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Copa", b =>
                {
                    b.Property<int>("IdCopa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMenu")
                        .HasColumnType("int");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.Property<int?>("MenuIdMenu")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasColumnType("longtext");

                    b.Property<int?>("PedidoIdPedido")
                        .HasColumnType("int");

                    b.HasKey("IdCopa");

                    b.HasIndex("MenuIdMenu");

                    b.HasIndex("PedidoIdPedido");

                    b.ToTable("Copa");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Cozinha", b =>
                {
                    b.Property<int>("IdCozinha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMenu")
                        .HasColumnType("int");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.Property<int?>("MenuIdMenu")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasColumnType("longtext");

                    b.Property<int?>("PedidoIdPedido")
                        .HasColumnType("int");

                    b.HasKey("IdCozinha");

                    b.HasIndex("MenuIdMenu");

                    b.HasIndex("PedidoIdPedido");

                    b.ToTable("Cozinha");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .HasColumnType("longtext");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoFuncionario")
                        .HasColumnType("longtext");

                    b.Property<string>("SenhaDeAcesso")
                        .HasColumnType("longtext");

                    b.HasKey("IdFuncionario");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Menu", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Complexidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Img")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<float>("Preco")
                        .HasColumnType("float");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext");

                    b.HasKey("IdMenu");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Mesa", b =>
                {
                    b.Property<int>("IdMesa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Disponibilidade")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoCliente")
                        .HasColumnType("longtext");

                    b.Property<int>("NumeroDaMesa")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasColumnType("longtext");

                    b.Property<int>("QuantidadeDePessoas")
                        .HasColumnType("int");

                    b.HasKey("IdMesa");

                    b.ToTable("Mesa");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int?>("FuncionarioIdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("IdMenu")
                        .HasColumnType("int");

                    b.Property<int>("IdMesa")
                        .HasColumnType("int");

                    b.Property<int?>("MenuIdMenu")
                        .HasColumnType("int");

                    b.Property<int?>("MesaDoPedidoIdMesa")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoFuncionario")
                        .HasColumnType("longtext");

                    b.Property<string>("Observacoes")
                        .HasColumnType("longtext");

                    b.Property<string>("PrazoDoPedido")
                        .HasColumnType("longtext");

                    b.Property<float>("PrecoDoPedido")
                        .HasColumnType("float");

                    b.Property<string>("TipoDoPedido")
                        .HasColumnType("longtext");

                    b.HasKey("IdPedido");

                    b.HasIndex("FuncionarioIdFuncionario");

                    b.HasIndex("MenuIdMenu");

                    b.HasIndex("MesaDoPedidoIdMesa");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Copa", b =>
                {
                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuIdMenu");

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoIdPedido");

                    b.Navigation("Menu");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Cozinha", b =>
                {
                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuIdMenu");

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoIdPedido");

                    b.Navigation("Menu");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Pedido", b =>
                {
                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Funcionario", "Funcionario")
                        .WithMany("Pedidos")
                        .HasForeignKey("FuncionarioIdFuncionario");

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuIdMenu");

                    b.HasOne("Ia_ComandaRestaurante.Models.ViewModels.Mesa", "MesaDoPedido")
                        .WithMany()
                        .HasForeignKey("MesaDoPedidoIdMesa");

                    b.Navigation("Funcionario");

                    b.Navigation("Menu");

                    b.Navigation("MesaDoPedido");
                });

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Funcionario", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
