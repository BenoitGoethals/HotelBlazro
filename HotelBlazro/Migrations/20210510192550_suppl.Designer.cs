﻿// <auto-generated />
using System;
using HotelBlazro.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelBlazro.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20210510192550_suppl")]
    partial class suppl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("HotelBlazro.Data.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.Property<int>("Persons")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("Price");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("RoomNumber");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelBlazro.Data.Supplement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Description");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("Price");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<bool>("Selected")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Selected");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Supplements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Koffie Machine",
                            Price = 10,
                            Selected = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "WAS Machine",
                            Price = 10,
                            Selected = false
                        });
                });

            modelBuilder.Entity("HotelBlazro.Data.Supplement", b =>
                {
                    b.HasOne("HotelBlazro.Data.Room", null)
                        .WithMany("Supplements")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("HotelBlazro.Data.Room", b =>
                {
                    b.Navigation("Supplements");
                });
#pragma warning restore 612, 618
        }
    }
}
