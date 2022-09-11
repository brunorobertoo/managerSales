﻿// <auto-generated />
using System;
using ManagerSalesApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManagerSalesApi.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ManagerSalesApi.Models.Opportunity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Opportunities");
                });

            modelBuilder.Entity("ManagerSalesApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Region")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ManagerSalesApi.Models.Opportunity", b =>
                {
                    b.HasOne("ManagerSalesApi.Models.User", "user")
                        .WithMany("opportunities")
                        .HasForeignKey("userId");

                    b.Navigation("user");
                });

            modelBuilder.Entity("ManagerSalesApi.Models.User", b =>
                {
                    b.Navigation("opportunities");
                });
#pragma warning restore 612, 618
        }
    }
}
