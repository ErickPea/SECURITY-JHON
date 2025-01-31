﻿// <auto-generated />
using System;
using Entity.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entity.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240804153816_actualizacion")]
    partial class actualizacion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.Model.Security.Modulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_by")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_by")
                        .HasColumnType("datetime2");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("state")
                        .HasColumnType("bit");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_by")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("modulo");
                });

            modelBuilder.Entity("Entity.Model.Security.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_by")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_by")
                        .HasColumnType("datetime2");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha_de_nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primer_apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primer_nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segundo_apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segundo_nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_de_documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_by")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("Entity.Model.Security.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_by")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_by")
                        .HasColumnType("datetime2");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_by")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("rol");
                });

            modelBuilder.Entity("Entity.Model.Security.Rol_Vista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_by")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_by")
                        .HasColumnType("datetime2");

                    b.Property<int>("rolId")
                        .HasColumnType("int");

                    b.Property<int>("rol_id")
                        .HasColumnType("int");

                    b.Property<bool>("state")
                        .HasColumnType("bit");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_by")
                        .HasColumnType("datetime2");

                    b.Property<int>("vistaId")
                        .HasColumnType("int");

                    b.Property<int>("vista_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("rolId");

                    b.HasIndex("vistaId");

                    b.ToTable("rol_vista");
                });

            modelBuilder.Entity("Entity.Model.Security.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_by")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_by")
                        .HasColumnType("datetime2");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<string>("nombre_de_usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personaId")
                        .HasColumnType("int");

                    b.Property<int>("persona_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_by")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("personaId");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("Entity.Model.Security.Usuario_rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_by")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_by")
                        .HasColumnType("datetime2");

                    b.Property<int>("rolId")
                        .HasColumnType("int");

                    b.Property<int>("rol_id")
                        .HasColumnType("int");

                    b.Property<bool>("state")
                        .HasColumnType("bit");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_by")
                        .HasColumnType("datetime2");

                    b.Property<int>("usuarioId")
                        .HasColumnType("int");

                    b.Property<int>("usuario_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("rolId");

                    b.HasIndex("usuarioId");

                    b.ToTable("usuario_rol");
                });

            modelBuilder.Entity("Entity.Model.Security.Vista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_by")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_by")
                        .HasColumnType("datetime2");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("moduloId")
                        .HasColumnType("int");

                    b.Property<int>("modulo_id")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ruta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("state")
                        .HasColumnType("bit");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_by")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("moduloId");

                    b.ToTable("vistas");
                });

            modelBuilder.Entity("Entity.Model.Security.Rol_Vista", b =>
                {
                    b.HasOne("Entity.Model.Security.Rol", "rol")
                        .WithMany()
                        .HasForeignKey("rolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Model.Security.Vista", "vista")
                        .WithMany()
                        .HasForeignKey("vistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("rol");

                    b.Navigation("vista");
                });

            modelBuilder.Entity("Entity.Model.Security.Usuario", b =>
                {
                    b.HasOne("Entity.Model.Security.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("persona");
                });

            modelBuilder.Entity("Entity.Model.Security.Usuario_rol", b =>
                {
                    b.HasOne("Entity.Model.Security.Rol", "rol")
                        .WithMany()
                        .HasForeignKey("rolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Model.Security.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("rol");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Entity.Model.Security.Vista", b =>
                {
                    b.HasOne("Entity.Model.Security.Modulo", "modulo")
                        .WithMany()
                        .HasForeignKey("moduloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("modulo");
                });
#pragma warning restore 612, 618
        }
    }
}
