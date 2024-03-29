﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prod.Models;

namespace api27.Migrations
{
    [DbContext(typeof(Proyecto))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Prod.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<int>("ProductoId");

                    b.HasKey("CategoriaId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Prod.Models.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<int?>("CategoriaId");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Precio");

                    b.Property<string>("Title");

                    b.HasKey("ProductoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Prod.Models.Categoria", b =>
                {
                    b.HasOne("Prod.Models.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prod.Models.Producto", b =>
                {
                    b.HasOne("Prod.Models.Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId");
                });
#pragma warning restore 612, 618
        }
    }
}
