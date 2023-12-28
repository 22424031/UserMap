﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserMap.Persistent;

#nullable disable

namespace UserMap.Persistent.Migrations
{
    [DbContext(typeof(UserMapContext))]
    [Migration("20231228134306_add-feedback")]
    partial class addfeedback
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UserMap.Domain.Ads", b =>
                {
                    b.Property<int>("AdsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdsAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyInfo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Feedback")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<float>("Height")
                        .HasColumnType("float");

                    b.Property<string>("IsActive")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Longt")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("SizeUnit")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UrlImagesJson")
                        .IsRequired()
                        .HasColumnType("Json");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Width")
                        .HasColumnType("float");

                    b.HasKey("AdsID");

                    b.ToTable("Ads");
                });

            modelBuilder.Entity("UserMap.Domain.ReportWarm", b =>
                {
                    b.Property<int>("ReportWarmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdsID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UrlStringJson")
                        .IsRequired()
                        .HasColumnType("Json");

                    b.Property<string>("WarmType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ReportWarmID");

                    b.ToTable("ReportWarm");
                });
#pragma warning restore 612, 618
        }
    }
}
