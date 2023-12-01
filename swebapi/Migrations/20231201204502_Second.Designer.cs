﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using swebapi.Data;

#nullable disable

namespace swebapi.Migrations
{
    [DbContext(typeof(IdentityContext))]
    [Migration("20231201204502_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5fa37031-20cb-4c33-ad0e-6f060ce60936",
                            ConcurrencyStamp = "3b798bd7-668e-43cf-b1a8-d9d4bd091614",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "eb7c22a8-8de7-4369-ba5f-c5ceda76e0bc",
                            ConcurrencyStamp = "874f4002-47fa-4a4e-82a3-72e5812f1266",
                            Name = "Usuario general",
                            NormalizedName = "USUARIO GENERAL"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3423845e-fe80-4164-8a98-163e0ae67d6c",
                            RoleId = "5fa37031-20cb-4c33-ad0e-6f060ce60936"
                        },
                        new
                        {
                            UserId = "f69f014b-7ecb-4fde-b3de-c78008d3742b",
                            RoleId = "5fa37031-20cb-4c33-ad0e-6f060ce60936"
                        },
                        new
                        {
                            UserId = "c47e9259-4043-4b56-9bc4-a4399a3e634b",
                            RoleId = "eb7c22a8-8de7-4369-ba5f-c5ceda76e0bc"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("swebapi.Models.CustomIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3423845e-fe80-4164-8a98-163e0ae67d6c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ae90c92a-ec83-4ebf-bf64-ad919cc80c30",
                            Email = "gvera@uv.mx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nombre = "Guillermo Humberto Vera Amaro",
                            NormalizedEmail = "GVERA@UV.MX",
                            NormalizedUserName = "GVERA@UV.MX",
                            PasswordHash = "AQAAAAEAACcQAAAAEGwWJ8wzi43HI3d7SWv+vMfRXMcUtyXDbIpjFgpkW5VdOaS2DknBkH9Bn6KB6cPZaQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a298d621-3de2-44f9-a8bc-fc12d63dbdb5",
                            TwoFactorEnabled = false,
                            UserName = "gvera@uv.mx"
                        },
                        new
                        {
                            Id = "f69f014b-7ecb-4fde-b3de-c78008d3742b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eebf0e0a-21d1-4dcb-9535-6bec72dadcc4",
                            Email = "sperez@uv.mx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nombre = "Saúl Pérez García",
                            NormalizedEmail = "SPEREZ@UV.MX",
                            NormalizedUserName = "SPEREZ@UV.MX",
                            PasswordHash = "AQAAAAEAACcQAAAAEJS2ivpn+IMgG9B2fxrNxEgAGAnEWXZBPkapvPiMbk55qNDP8R3Jo8wISvLG7roKFQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1d85308f-6ff4-4a2a-80e4-401cc4456212",
                            TwoFactorEnabled = false,
                            UserName = "sperez@uv.mx"
                        },
                        new
                        {
                            Id = "c47e9259-4043-4b56-9bc4-a4399a3e634b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "06f3cf17-f56b-4826-b4be-b94745d4731c",
                            Email = "gochoa@uv,mx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nombre = "Gerardo Ochoa Martínez",
                            NormalizedEmail = "GOCHOA@UV.MX",
                            NormalizedUserName = "GOCHOA@UV.MX",
                            PasswordHash = "AQAAAAEAACcQAAAAEDu4fJqblCQQmXUl0wEtP9QcKUUqAvgL7pWcB2MAjMqOJ/ovGfkGlZifqEu40YDylg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d157fdf5-6fb7-4766-accf-bcc6555a6643",
                            TwoFactorEnabled = false,
                            UserName = "gochoa@uv.mx"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("swebapi.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("swebapi.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("swebapi.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("swebapi.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
