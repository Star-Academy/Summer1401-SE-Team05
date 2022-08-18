﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TopStudents;

#nullable disable

namespace TopStudents.Migrations
{
    [DbContext(typeof(PeopleContext))]
    [Migration("20220816073714_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TopStudents.Grade", b =>
                {
                    b.Property<int>("StudentNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Lesson")
                        .HasColumnType("text");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.HasKey("StudentNumber", "Lesson");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("TopStudents.Student", b =>
                {
                    b.Property<int>("StudentNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentNumber"));

                    b.Property<float>("Avg")
                        .HasColumnType("real");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StudentNumber");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
