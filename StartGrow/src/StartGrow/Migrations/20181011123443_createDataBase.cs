﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StartGrow.Migrations
{
    public partial class createDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreasID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreasID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Apellido1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Apellido2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CodPost = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    NIF = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PaisDeResidencia = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Actividad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CIF = table.Column<int>(type: "int", maxLength: 9, nullable: true),
                    DenominacionSocial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DomicilioSocial = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaDeConstitucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MunicipioDelDomicilioSocial = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PaisDelDomicilioSocial = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ProvinciaDelDomicilioSocial = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PuestoDeTrabajo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingID);
                });

            migrationBuilder.CreateTable(
                name: "TiposInversiones",
                columns: table => new
                {
                    TiposInversionesID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposInversiones", x => x.TiposInversionesID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monedero",
                columns: table => new
                {
                    MonederoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dinero = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InversorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedero", x => x.MonederoId);
                    table.ForeignKey(
                        name: "FK_Monedero_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Monedero_AspNetUsers_InversorId",
                        column: x => x.InversorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Preferencias",
                columns: table => new
                {
                    PreferenciasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreasID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InversorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RatingID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TiposInversionesID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferencias", x => x.PreferenciasId);
                    table.ForeignKey(
                        name: "FK_Preferencias_Areas_AreasID",
                        column: x => x.AreasID,
                        principalTable: "Areas",
                        principalColumn: "AreasID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Preferencias_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Preferencias_AspNetUsers_InversorId",
                        column: x => x.InversorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Preferencias_Rating_RatingID",
                        column: x => x.RatingID,
                        principalTable: "Rating",
                        principalColumn: "RatingID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Preferencias_TiposInversiones_TiposInversionesID",
                        column: x => x.TiposInversionesID,
                        principalTable: "TiposInversiones",
                        principalColumn: "TiposInversionesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreasID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FechaExpiracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Importe = table.Column<float>(type: "real", nullable: false),
                    Interes = table.Column<float>(type: "real", nullable: false),
                    MinInversion = table.Column<float>(type: "real", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumInversores = table.Column<int>(type: "int", nullable: false),
                    Plazo = table.Column<int>(type: "int", nullable: false),
                    Progreso = table.Column<int>(type: "int", nullable: false),
                    RatingID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.ProyectoId);
                    table.ForeignKey(
                        name: "FK_Proyecto_TiposInversiones_AreasID",
                        column: x => x.AreasID,
                        principalTable: "TiposInversiones",
                        principalColumn: "TiposInversionesID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proyecto_Rating_RatingID",
                        column: x => x.RatingID,
                        principalTable: "Rating",
                        principalColumn: "RatingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inversion",
                columns: table => new
                {
                    InversionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cuota = table.Column<float>(type: "real", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Intereses = table.Column<float>(type: "real", nullable: false),
                    InversorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    TipoInversionesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inversion", x => x.InversionId);
                    table.ForeignKey(
                        name: "FK_Inversion_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inversion_AspNetUsers_InversorId",
                        column: x => x.InversorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inversion_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyecto",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inversion_TiposInversiones_TipoInversionesId",
                        column: x => x.TipoInversionesId,
                        principalTable: "TiposInversiones",
                        principalColumn: "TiposInversionesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoAreas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreasId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProyectoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoAreas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProyectoAreas_Areas_AreasId",
                        column: x => x.AreasId,
                        principalTable: "Areas",
                        principalColumn: "AreasID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoAreas_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyecto",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoTiposInversiones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    TiposInversionesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoTiposInversiones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProyectoTiposInversiones_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyecto",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoTiposInversiones_TiposInversiones_TiposInversionesId",
                        column: x => x.TiposInversionesId,
                        principalTable: "TiposInversiones",
                        principalColumn: "TiposInversionesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    SolicitudID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProyectoID = table.Column<int>(type: "int", nullable: false),
                    TrabajadorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitud", x => x.SolicitudID);
                    table.ForeignKey(
                        name: "FK_Solicitud_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_Proyecto_ProyectoID",
                        column: x => x.ProyectoID,
                        principalTable: "Proyecto",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_AspNetUsers_TrabajadorId",
                        column: x => x.TrabajadorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InversionRecuperada",
                columns: table => new
                {
                    InversionRecuperadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CantidadRecuperada = table.Column<float>(type: "real", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRecuperacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InversionId = table.Column<int>(type: "int", nullable: false),
                    MonederoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InversionRecuperada", x => x.InversionRecuperadaId);
                    table.ForeignKey(
                        name: "FK_InversionRecuperada_Inversion_InversionId",
                        column: x => x.InversionId,
                        principalTable: "Inversion",
                        principalColumn: "InversionId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_InversionRecuperada_Monedero_MonederoId",
                        column: x => x.MonederoId,
                        principalTable: "Monedero",
                        principalColumn: "MonederoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Inversion_Id",
                table: "Inversion",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Inversion_InversorId",
                table: "Inversion",
                column: "InversorId");

            migrationBuilder.CreateIndex(
                name: "IX_Inversion_ProyectoId",
                table: "Inversion",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inversion_TipoInversionesId",
                table: "Inversion",
                column: "TipoInversionesId");

            migrationBuilder.CreateIndex(
                name: "IX_InversionRecuperada_InversionId",
                table: "InversionRecuperada",
                column: "InversionId");

            migrationBuilder.CreateIndex(
                name: "IX_InversionRecuperada_MonederoId",
                table: "InversionRecuperada",
                column: "MonederoId");

            migrationBuilder.CreateIndex(
                name: "IX_Monedero_Id",
                table: "Monedero",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Monedero_InversorId",
                table: "Monedero",
                column: "InversorId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferencias_AreasID",
                table: "Preferencias",
                column: "AreasID");

            migrationBuilder.CreateIndex(
                name: "IX_Preferencias_Id",
                table: "Preferencias",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Preferencias_InversorId",
                table: "Preferencias",
                column: "InversorId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferencias_RatingID",
                table: "Preferencias",
                column: "RatingID");

            migrationBuilder.CreateIndex(
                name: "IX_Preferencias_TiposInversionesID",
                table: "Preferencias",
                column: "TiposInversionesID");

            migrationBuilder.CreateIndex(
                name: "IX_Proyecto_AreasID",
                table: "Proyecto",
                column: "AreasID");

            migrationBuilder.CreateIndex(
                name: "IX_Proyecto_RatingID",
                table: "Proyecto",
                column: "RatingID");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoAreas_AreasId",
                table: "ProyectoAreas",
                column: "AreasId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoAreas_ProyectoId",
                table: "ProyectoAreas",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoTiposInversiones_ProyectoId",
                table: "ProyectoTiposInversiones",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoTiposInversiones_TiposInversionesId",
                table: "ProyectoTiposInversiones",
                column: "TiposInversionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_Id",
                table: "Solicitud",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_ProyectoID",
                table: "Solicitud",
                column: "ProyectoID");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_TrabajadorId",
                table: "Solicitud",
                column: "TrabajadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "InversionRecuperada");

            migrationBuilder.DropTable(
                name: "Preferencias");

            migrationBuilder.DropTable(
                name: "ProyectoAreas");

            migrationBuilder.DropTable(
                name: "ProyectoTiposInversiones");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Inversion");

            migrationBuilder.DropTable(
                name: "Monedero");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Proyecto");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TiposInversiones");

            migrationBuilder.DropTable(
                name: "Rating");
        }
    }
}