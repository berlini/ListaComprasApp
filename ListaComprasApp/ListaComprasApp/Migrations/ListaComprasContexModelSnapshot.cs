using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ListaComprasApp.Repositories;

namespace ListaComprasApp.Migrations
{
    [DbContext(typeof(ListaComprasContex))]
    partial class ListaComprasContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("ListaComprasApp.Entities.Item", b =>
                {
                    b.Property<string>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Concluido");

                    b.Property<string>("ListaComprasListaId");

                    b.Property<string>("Nome");

                    b.Property<string>("Observacao");

                    b.Property<int>("Quantidade");

                    b.HasKey("ItemId");

                    b.HasIndex("ListaComprasListaId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ListaComprasApp.Entities.ListaCompras", b =>
                {
                    b.Property<string>("ListaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<bool>("Finalizado");

                    b.Property<string>("Observacao");

                    b.Property<string>("Titulo");

                    b.HasKey("ListaId");

                    b.ToTable("ListasCompras");
                });

            modelBuilder.Entity("ListaComprasApp.Entities.Item", b =>
                {
                    b.HasOne("ListaComprasApp.Entities.ListaCompras")
                        .WithMany("Items")
                        .HasForeignKey("ListaComprasListaId");
                });
        }
    }
}
