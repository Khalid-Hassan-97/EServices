﻿// <auto-generated />
using EServicesAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EServicesAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EServicesAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "ahmed@email.com",
                            Name = "Ahmed Ali Omer Yassir",
                            PasswordHash = "QWhtZWRAMTIz",
                            PhoneNumber = "+971112345667",
                            UserType = 2,
                            Username = "Ahmed_50"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "ali@email.com",
                            Name = "Ali Omer Yassir Ahmed",
                            PasswordHash = "QWxpQDEyMw==",
                            PhoneNumber = "+971112345667",
                            UserType = 2,
                            Username = "Ali_51"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "omer@email.com",
                            Name = "Omer Yassir Ahmed Ali",
                            PasswordHash = "T21lckAxMjM=",
                            PhoneNumber = "+971112345667",
                            UserType = 2,
                            Username = "Omer_52"
                        },
                        new
                        {
                            UserId = 4,
                            Email = "yassir@email.com",
                            Name = "Yassir Ahmed Ali Omer",
                            PasswordHash = "WWFzc2lyQDEyMw==",
                            PhoneNumber = "+971112345667",
                            UserType = 2,
                            Username = "Yassir_53"
                        },
                        new
                        {
                            UserId = 5,
                            Email = "rami@email.com",
                            Name = "Rami Ali Ammar",
                            PasswordHash = "UmFtaUAxMjM=",
                            PhoneNumber = "+971112345667",
                            UserType = 1,
                            Username = "Rami_90"
                        },
                        new
                        {
                            UserId = 6,
                            Email = "hussam@email.com",
                            Name = "Hussam Ali Ammar",
                            PasswordHash = "SHVzc2FtQDEyMw==",
                            PhoneNumber = "+971112345667",
                            UserType = 1,
                            Username = "Hussam_91"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
