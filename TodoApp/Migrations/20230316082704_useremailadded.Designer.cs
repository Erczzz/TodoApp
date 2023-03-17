﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApp.Data;

#nullable disable

namespace TodoApp.Migrations
{
    [DbContext(typeof(TodoDBContext))]
    [Migration("20230316082704_useremailadded")]
    partial class useremailadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TodoApp.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Description = "Eat Ice Cream",
                            DueDate = new DateTime(2023, 3, 17, 0, 27, 3, 980, DateTimeKind.Local).AddTicks(5410),
                            Status = false,
                            Title = "Buy Ice Cream"
                        },
                        new
                        {
                            Id = 5,
                            Description = "In Jump training",
                            DueDate = new DateTime(2023, 3, 18, 16, 27, 3, 980, DateTimeKind.Local).AddTicks(5417),
                            Status = false,
                            Title = "Learn Data Seeding"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Entity Customization",
                            DueDate = new DateTime(2023, 3, 17, 16, 27, 3, 980, DateTimeKind.Local).AddTicks(5418),
                            Status = false,
                            Title = "Learn Fluent Api"
                        });
                });

            modelBuilder.Entity("TodoApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("ntext")
                        .HasColumnName("First_Name");

                    b.HasKey("Id");

                    b.ToTable("People", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2003, 3, 16, 16, 27, 3, 980, DateTimeKind.Local).AddTicks(5315),
                            Name = "Administrator"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}