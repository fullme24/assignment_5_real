﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assignment_5_real.Models;

namespace assignment_5_real.Migrations
{
    [DbContext(typeof(LibrosDbContext))]
    partial class LibrosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12");

            modelBuilder.Entity("assignment_5_real.Models.Libro", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BAuthorFirst")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BAuthorLast")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BAuthorMid")
                        .HasColumnType("TEXT");

                    b.Property<string>("BCategory")
                        .HasColumnType("TEXT");

                    b.Property<string>("BClassification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("BPageNumber")
                        .HasColumnType("INTEGER");

                    b.Property<double>("BPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("BPublisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookID");

                    b.ToTable("Libros");
                });
#pragma warning restore 612, 618
        }
    }
}
