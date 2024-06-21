﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository.Context;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(ContextAppDB))]
    [Migration("20240620222454_MigracionInicial")]
    partial class MigracionInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Repository.Data.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("celular")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("id_banco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("cliente", null, t =>
                        {
                            t.HasCheckConstraint("CK_cliente_apellido_MinLength", "LENGTH(apellido) >= 3");

                            t.HasCheckConstraint("CK_cliente_celular_MinLength", "LENGTH(celular) >= 0");

                            t.HasCheckConstraint("CK_cliente_celular_RegularExpression", "celular ~ '^[0-9]+$'");

                            t.HasCheckConstraint("CK_cliente_documento_MinLength", "LENGTH(documento) >= 3");

                            t.HasCheckConstraint("CK_cliente_nombre_MinLength", "LENGTH(nombre) >= 3");
                        });
                });

            modelBuilder.Entity("Repository.Data.FacturaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("fecha_hora")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("id_cliente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nro_factura")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sucursal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("total")
                        .HasColumnType("numeric");

                    b.Property<decimal>("total_iva")
                        .HasColumnType("numeric");

                    b.Property<decimal>("total_iva10")
                        .HasColumnType("numeric");

                    b.Property<decimal>("total_iva5")
                        .HasColumnType("numeric");

                    b.Property<string>("total_letras")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("factura", null, t =>
                        {
                            t.HasCheckConstraint("CK_factura_nro_factura_RegularExpression", "nro_factura ~ '^[0-9]{3}-[0-9]{3}-[0-9]{6}$'");

                            t.HasCheckConstraint("CK_factura_total_letras_MinLength", "LENGTH(total_letras) >= 6");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
