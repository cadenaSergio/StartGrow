﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using StartGrow.Data;
using System;

namespace StartGrow.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StartGrow.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Apellido1")
                        .IsRequired();

                    b.Property<string>("Apellido2")
                        .IsRequired();

                    b.Property<int>("CodPost");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Domicilio")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Municipio")
                        .IsRequired();

                    b.Property<string>("Nacionalidad")
                        .IsRequired();

                    b.Property<string>("Nif")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PaisResidencia")
                        .IsRequired();

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Provincia")
                        .IsRequired();

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");
                });

            modelBuilder.Entity("StartGrow.Models.Areas", b =>
                {
                    b.Property<string>("AreasID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("AreasID");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("StartGrow.Models.Inversion", b =>
                {
                    b.Property<int>("InversionId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Cuota");

                    b.Property<float>("Intereses");

                    b.Property<string>("InversorId")
                        .IsRequired();

                    b.Property<int>("ProyectoId");

                    b.Property<float>("Total");

                    b.HasKey("InversionId");

                    b.HasIndex("InversorId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Inversion");
                });

            modelBuilder.Entity("StartGrow.Models.InversionRecuperada", b =>
                {
                    b.Property<int>("InversionRecuperadaId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("CantidadRecuperada");

                    b.Property<string>("Comentario")
                        .IsRequired();

                    b.Property<DateTime>("FechaRecuperacion");

                    b.Property<int>("InversionId");

                    b.Property<int>("MonederoId");

                    b.HasKey("InversionRecuperadaId");

                    b.HasIndex("InversionId");

                    b.HasIndex("MonederoId");

                    b.ToTable("InversionRecuperada");
                });

            modelBuilder.Entity("StartGrow.Models.Monedero", b =>
                {
                    b.Property<int>("MonederoId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Dinero");

                    b.Property<string>("InversorId")
                        .IsRequired();

                    b.HasKey("MonederoId");

                    b.HasIndex("InversorId");

                    b.ToTable("Monedero");
                });

            modelBuilder.Entity("StartGrow.Models.Preferencias", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreasID");

                    b.Property<string>("InversorId");

                    b.Property<string>("RatingID");

                    b.Property<string>("TiposInversionesID");

                    b.HasKey("ID");

                    b.HasIndex("AreasID");

                    b.HasIndex("InversorId");

                    b.HasIndex("RatingID");

                    b.HasIndex("TiposInversionesID");

                    b.ToTable("Preferencias");
                });

            modelBuilder.Entity("StartGrow.Models.Proyecto", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreasID");

                    b.Property<DateTime>("FechaExpiracion");

                    b.Property<float>("Importe");

                    b.Property<float>("Interes");

                    b.Property<float>("MinInversion");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("NumInversores");

                    b.Property<int>("Plazo");

                    b.Property<int>("Progreso");

                    b.Property<string>("RatingID");

                    b.HasKey("ProyectoId");

                    b.HasIndex("AreasID");

                    b.HasIndex("RatingID");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("StartGrow.Models.ProyectoAreas", b =>
                {
                    b.Property<string>("ProyectoAreasId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreasId")
                        .IsRequired();

                    b.Property<int>("ProyectoId");

                    b.HasKey("ProyectoAreasId");

                    b.HasIndex("AreasId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("ProyectoAreas");
                });

            modelBuilder.Entity("StartGrow.Models.ProyectoTiposInversiones", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProyectoId");

                    b.Property<string>("TiposInversionesId")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ProyectoId");

                    b.HasIndex("TiposInversionesId");

                    b.ToTable("ProyectoTiposInversiones");
                });

            modelBuilder.Entity("StartGrow.Models.Rating", b =>
                {
                    b.Property<string>("RatingID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("RatingID");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("StartGrow.Models.TiposInversiones", b =>
                {
                    b.Property<string>("TiposInversionesID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("TiposInversionesID");

                    b.ToTable("TiposInversiones");
                });

            modelBuilder.Entity("StartGrow.Models.Inversor", b =>
                {
                    b.HasBaseType("StartGrow.Models.ApplicationUser");


                    b.ToTable("Inversor");

                    b.HasDiscriminator().HasValue("Inversor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StartGrow.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StartGrow.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StartGrow.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StartGrow.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartGrow.Models.Inversion", b =>
                {
                    b.HasOne("StartGrow.Models.Inversor", "Inversor")
                        .WithMany("Inversiones")
                        .HasForeignKey("InversorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StartGrow.Models.Proyecto", "Proyecto")
                        .WithMany("Inversiones")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartGrow.Models.InversionRecuperada", b =>
                {
                    b.HasOne("StartGrow.Models.Inversion", "Inversion")
                        .WithMany("InversionesRecuperadas")
                        .HasForeignKey("InversionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StartGrow.Models.Monedero", "Monedero")
                        .WithMany("InversionesRecuperadas")
                        .HasForeignKey("MonederoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartGrow.Models.Monedero", b =>
                {
                    b.HasOne("StartGrow.Models.Inversor", "Inversor")
                        .WithMany()
                        .HasForeignKey("InversorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartGrow.Models.Preferencias", b =>
                {
                    b.HasOne("StartGrow.Models.Areas", "Areas")
                        .WithMany("Preferencias")
                        .HasForeignKey("AreasID");

                    b.HasOne("StartGrow.Models.Inversor", "Inversor")
                        .WithMany("Preferencias")
                        .HasForeignKey("InversorId");

                    b.HasOne("StartGrow.Models.Rating", "Rating")
                        .WithMany("Preferencias")
                        .HasForeignKey("RatingID");

                    b.HasOne("StartGrow.Models.TiposInversiones", "TiposInversiones")
                        .WithMany("Preferencias")
                        .HasForeignKey("TiposInversionesID");
                });

            modelBuilder.Entity("StartGrow.Models.Proyecto", b =>
                {
                    b.HasOne("StartGrow.Models.TiposInversiones", "Areas")
                        .WithMany()
                        .HasForeignKey("AreasID");

                    b.HasOne("StartGrow.Models.Rating", "Rating")
                        .WithMany("Proyectos")
                        .HasForeignKey("RatingID");
                });

            modelBuilder.Entity("StartGrow.Models.ProyectoAreas", b =>
                {
                    b.HasOne("StartGrow.Models.Areas", "Areas")
                        .WithMany("ProyectoAreas")
                        .HasForeignKey("AreasId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StartGrow.Models.Proyecto", "Proyecto")
                        .WithMany("ProyectoAreas")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartGrow.Models.ProyectoTiposInversiones", b =>
                {
                    b.HasOne("StartGrow.Models.Proyecto", "Proyecto")
                        .WithMany("ProyectoTiposInversiones")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StartGrow.Models.TiposInversiones", "TiposInversiones")
                        .WithMany("ProyectoTiposInversiones")
                        .HasForeignKey("TiposInversionesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
