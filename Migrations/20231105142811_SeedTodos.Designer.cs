﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using seaside.api.Data;

#nullable disable

namespace seaside.api.Migrations
{
    [DbContext(typeof(SeasideContext))]
    [Migration("20231105142811_SeedTodos")]
    partial class SeedTodos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("seaside.api.Entities.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Complete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 10000,
                            Complete = false,
                            Name = "Buy Milk"
                        },
                        new
                        {
                            Id = 10001,
                            Complete = false,
                            Name = "Rake Leaves"
                        },
                        new
                        {
                            Id = 10002,
                            Complete = false,
                            Name = "Pick Up Dry Cleaning"
                        },
                        new
                        {
                            Id = 10003,
                            Complete = false,
                            Name = "Clean Grill"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
