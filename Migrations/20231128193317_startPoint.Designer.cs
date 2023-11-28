﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231128193317_startPoint")]
    partial class startPoint
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "Computer",
                            ProductPrice = 15000m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "Keyboard",
                            ProductPrice = 500m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "Mouse",
                            ProductPrice = 1000m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "Deck",
                            ProductPrice = 1500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
