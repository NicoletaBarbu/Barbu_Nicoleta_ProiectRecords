﻿// <auto-generated />
using Barbu_Nicoleta_ProiectRecords.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Barbu_Nicoleta_ProiectRecords.Migrations
{
    [DbContext(typeof(Barbu_Nicoleta_ProiectRecordsContext))]
    [Migration("20210127180235_Recordhouses")]
    partial class Recordhouses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Barbu_Nicoleta_ProiectRecords.Models.Record", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int>("PublishingYear")
                        .HasColumnType("int");

                    b.Property<int>("RecordhouseID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RecordhouseID");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("Barbu_Nicoleta_ProiectRecords.Models.Recordhouse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RecordhouseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Recordhouse");
                });

            modelBuilder.Entity("Barbu_Nicoleta_ProiectRecords.Models.Record", b =>
                {
                    b.HasOne("Barbu_Nicoleta_ProiectRecords.Models.Recordhouse", "RecordHouse")
                        .WithMany("Records")
                        .HasForeignKey("RecordhouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}