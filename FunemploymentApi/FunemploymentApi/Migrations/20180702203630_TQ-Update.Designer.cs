﻿// <auto-generated />
using FunemploymentApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FunemploymentApi.Migrations
{
    [DbContext(typeof(FunemploymentDBContext))]
    [Migration("20180702203630_TQ-Update")]
    partial class TQUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FunemploymentApi.Models.BehaviorQuestion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.HasKey("ID");

                    b.ToTable("BehaviorQuestions");
                });

            modelBuilder.Entity("FunemploymentApi.Models.TechnicalQuestion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Difficulty");

                    b.Property<string>("Input");

                    b.Property<string>("Output");

                    b.Property<string>("ProblemDomain");

                    b.HasKey("ID");

                    b.ToTable("TechnicalQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
