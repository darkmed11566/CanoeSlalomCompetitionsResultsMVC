﻿// <auto-generated />
using System;
using CanoeSlalomCompetitionsResults.EfStaff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CanoeSlalomCompetitionsResults.Migrations
{
    [DbContext(typeof(WebContext))]
    [Migration("20221120093013_AddCompetition")]
    partial class AddCompetition
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CanoeSlalomCompetitionsResults.EfStaff.DbModels.Competition", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CompetitionEndtData")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompetitionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CompetitionStartData")
                        .HasColumnType("datetime2");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("Rating")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });
#pragma warning restore 612, 618
        }
    }
}
