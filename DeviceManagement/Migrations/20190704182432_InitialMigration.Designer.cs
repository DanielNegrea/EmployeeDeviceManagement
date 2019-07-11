﻿// <auto-generated />
using DeviceManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeviceManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190704182432_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeviceManagement.Models.Device", b =>
                {
                    b.Property<int>("DeviceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Name");

                    b.Property<string>("OperatingSystem");

                    b.Property<double>("OsVersion");

                    b.Property<string>("Processor");

                    b.Property<string>("RamAmount");

                    b.Property<string>("Type");

                    b.HasKey("DeviceID");

                    b.ToTable("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}