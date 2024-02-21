﻿// <auto-generated />
using JS_Tree2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JS_Tree2.Migrations
{
    [DbContext(typeof(TreeContext))]
    [Migration("20240220060931_tree")]
    partial class tree
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("JS_Tree2.Models.TreeViewNode", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("parent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("trees");
                });
#pragma warning restore 612, 618
        }
    }
}