﻿// <auto-generated />
using CampusVirtual.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CampusVirtual.Migrations
{
    [DbContext(typeof(CampusContext))]
    [Migration("20180417180031_CarrerasIni")]
    partial class CarrerasIni
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CampusVirtual.Model.Entities.Asistencia", b =>
                {
                    b.Property<int>("AsistenciaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Asistio");

                    b.Property<int?>("CursoId");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("UsuarioId");

                    b.HasKey("AsistenciaId");

                    b.HasIndex("CursoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Asistencias");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Beca", b =>
                {
                    b.Property<int>("BecaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<int>("Porcentaje");

                    b.HasKey("BecaId");

                    b.ToTable("Becas");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Carreras", b =>
                {
                    b.Property<int>("CarrerasId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Director");

                    b.Property<string>("Director1Id");

                    b.Property<string>("Nombre");

                    b.HasKey("CarrerasId");

                    b.HasIndex("Director1Id");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Nombre");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Evaluacion", b =>
                {
                    b.Property<int>("EvaluacionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CursoId");

                    b.Property<string>("Nombre");

                    b.HasKey("EvaluacionId");

                    b.HasIndex("CursoId");

                    b.ToTable("Evaluaciones");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Grupos", b =>
                {
                    b.Property<int>("GruposId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Horario");

                    b.Property<int?>("MateriaCursoId");

                    b.Property<int>("NumeroGrupo");

                    b.HasKey("GruposId");

                    b.HasIndex("MateriaCursoId");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Nota", b =>
                {
                    b.Property<int>("NotaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EvaluacionId");

                    b.Property<string>("UsuarioId");

                    b.HasKey("NotaId");

                    b.HasIndex("EvaluacionId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

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
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.UsuarioCurso", b =>
                {
                    b.Property<int>("UsuarioCursoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CursoId");

                    b.Property<string>("UsuarioId");

                    b.HasKey("UsuarioCursoId");

                    b.HasIndex("CursoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioCurso");
                });

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

            modelBuilder.Entity("CampusVirtual.Model.Entities.Asistencia", b =>
                {
                    b.HasOne("CampusVirtual.Model.Entities.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId");

                    b.HasOne("CampusVirtual.Model.Entities.Usuario", "Usuario")
                        .WithMany("Asistencias")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Carreras", b =>
                {
                    b.HasOne("CampusVirtual.Model.Entities.Usuario", "Director1")
                        .WithMany()
                        .HasForeignKey("Director1Id");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Evaluacion", b =>
                {
                    b.HasOne("CampusVirtual.Model.Entities.Curso", "Curso")
                        .WithMany("Evaluaciones")
                        .HasForeignKey("CursoId");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Grupos", b =>
                {
                    b.HasOne("CampusVirtual.Model.Entities.Curso", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaCursoId");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.Nota", b =>
                {
                    b.HasOne("CampusVirtual.Model.Entities.Evaluacion", "Evaluacion")
                        .WithMany("Notas")
                        .HasForeignKey("EvaluacionId");

                    b.HasOne("CampusVirtual.Model.Entities.Usuario", "Usuario")
                        .WithMany("Notas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("CampusVirtual.Model.Entities.UsuarioCurso", b =>
                {
                    b.HasOne("CampusVirtual.Model.Entities.Curso", "Curso")
                        .WithMany("UsuarioCursos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CampusVirtual.Model.Entities.Usuario", "Usuario")
                        .WithMany("Cursos")
                        .HasForeignKey("UsuarioId");
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
                    b.HasOne("CampusVirtual.Model.Entities.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CampusVirtual.Model.Entities.Usuario")
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

                    b.HasOne("CampusVirtual.Model.Entities.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CampusVirtual.Model.Entities.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
