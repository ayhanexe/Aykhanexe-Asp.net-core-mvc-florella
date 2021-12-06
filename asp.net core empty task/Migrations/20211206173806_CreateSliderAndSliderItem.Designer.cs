﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp.net_core_empty_task.DAL;

namespace asp.net_core_empty_task.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211206173806_CreateSliderAndSliderItem")]
    partial class CreateSliderAndSliderItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("asp.net_core_empty_task.Models.Slider", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("id");

                    b.ToTable("Slider");
                });

            modelBuilder.Entity("asp.net_core_empty_task.Models.SliderItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Sliderid")
                        .HasColumnType("int");

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Sliderid");

                    b.ToTable("SliderItem");
                });

            modelBuilder.Entity("asp.net_core_empty_task.Models.SliderItem", b =>
                {
                    b.HasOne("asp.net_core_empty_task.Models.Slider", null)
                        .WithMany("sliderItems")
                        .HasForeignKey("Sliderid");
                });

            modelBuilder.Entity("asp.net_core_empty_task.Models.Slider", b =>
                {
                    b.Navigation("sliderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
