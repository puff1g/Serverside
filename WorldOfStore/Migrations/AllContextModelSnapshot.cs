﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldOfStore.Models;

namespace WorldOfStore.Migrations
{
    [DbContext(typeof(AllContext))]
    partial class AllContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorldOfStore.Models.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("KundeID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("OrderId1");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WorldOfStore.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pris")
                        .HasColumnType("int");

                    b.Property<long?>("ProductID1")
                        .HasColumnType("bigint");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductID1");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WorldOfStore.Models.ProductVariant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Difficulty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long?>("ProductVariantId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProductVariantId");

                    b.ToTable("ProductVariant");
                });

            modelBuilder.Entity("WorldOfStore.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserId1")
                        .HasColumnType("bigint");

                    b.Property<string>("UserMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WorldOfStore.Models.Order", b =>
                {
                    b.HasOne("WorldOfStore.Models.Order", null)
                        .WithMany("Orders")
                        .HasForeignKey("OrderId1");
                });

            modelBuilder.Entity("WorldOfStore.Models.Product", b =>
                {
                    b.HasOne("WorldOfStore.Models.Product", null)
                        .WithMany("Products")
                        .HasForeignKey("ProductID1");
                });

            modelBuilder.Entity("WorldOfStore.Models.ProductVariant", b =>
                {
                    b.HasOne("WorldOfStore.Models.ProductVariant", null)
                        .WithMany("ProductVariants")
                        .HasForeignKey("ProductVariantId");
                });

            modelBuilder.Entity("WorldOfStore.Models.User", b =>
                {
                    b.HasOne("WorldOfStore.Models.User", null)
                        .WithMany("Users")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}
