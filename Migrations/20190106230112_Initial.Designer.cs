﻿// <auto-generated />
using Ia_ComandaRestaurante.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ia_ComandaRestaurante.Migrations
{
    [DbContext(typeof(Ia_ComandaRestauranteContext))]
    [Migration("20190106230112_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Ia_ComandaRestaurante.Models.ViewModels.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Img");

                    b.Property<string>("Nome");

                    b.Property<float>("Preco");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });
#pragma warning restore 612, 618
        }
    }
}
