﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebAlk_Bead.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231201200530_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("WebAlk_Bead.Data.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Airline")
                        .HasColumnType("TEXT");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FlightId");

                    b.HasIndex("FlightNumber")
                        .IsUnique();

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("WebAlk_Bead.Data.Plane", b =>
                {
                    b.Property<int>("PlaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Callsign")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("FlightId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NumberOfCrew")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NumberOfSeats")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlaneName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlaneId");

                    b.HasIndex("Callsign")
                        .IsUnique();

                    b.HasIndex("FlightId");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("WebAlk_Bead.Data.Plane", b =>
                {
                    b.HasOne("WebAlk_Bead.Data.Flight", "Flight")
                        .WithMany("Planes")
                        .HasForeignKey("FlightId");

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("WebAlk_Bead.Data.Flight", b =>
                {
                    b.Navigation("Planes");
                });
#pragma warning restore 612, 618
        }
    }
}
