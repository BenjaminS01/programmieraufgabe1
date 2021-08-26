﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherApp.DbContexts;

namespace WeatherApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeatherApp.Models.Coord", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Placeid")
                        .HasColumnType("int");

                    b.Property<decimal>("lat")
                        .HasColumnType("decimal(7,4)");

                    b.Property<decimal>("lon")
                        .HasColumnType("decimal(7,4)");

                    b.HasKey("id");

                    b.HasIndex("Placeid");

                    b.ToTable("coord");
                });

            modelBuilder.Entity("WeatherApp.Models.Main", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("feels_like")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("humidity")
                        .HasColumnType("int");

                    b.Property<int>("placeId")
                        .HasColumnType("int");

                    b.Property<int>("pressure")
                        .HasColumnType("int");

                    b.Property<decimal>("temp")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("temp_max")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("temp_min")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("id");

                    b.HasIndex("placeId")
                        .IsUnique();

                    b.ToTable("main");
                });

            modelBuilder.Entity("WeatherApp.Models.Place", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("varchar(100)");

                    b.HasKey("id");

                    b.ToTable("place");
                });

            modelBuilder.Entity("WeatherApp.Models.Weather", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Placeid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("icon")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("main")
                        .HasColumnType("varchar(100)");

                    b.HasKey("id");

                    b.HasIndex("Placeid");

                    b.ToTable("weather");
                });

            modelBuilder.Entity("WeatherApp.Models.Wind", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("deg")
                        .HasColumnType("int");

                    b.Property<int>("placeId")
                        .HasColumnType("int");

                    b.Property<decimal>("speed")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("id");

                    b.HasIndex("placeId")
                        .IsUnique();

                    b.ToTable("wind");
                });

            modelBuilder.Entity("WeatherApp.Models.Coord", b =>
                {
                    b.HasOne("WeatherApp.Models.Place", null)
                        .WithMany("coords")
                        .HasForeignKey("Placeid");
                });

            modelBuilder.Entity("WeatherApp.Models.Main", b =>
                {
                    b.HasOne("WeatherApp.Models.Place", "place")
                        .WithOne("main")
                        .HasForeignKey("WeatherApp.Models.Main", "placeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("place");
                });

            modelBuilder.Entity("WeatherApp.Models.Weather", b =>
                {
                    b.HasOne("WeatherApp.Models.Place", null)
                        .WithMany("weather")
                        .HasForeignKey("Placeid");
                });

            modelBuilder.Entity("WeatherApp.Models.Wind", b =>
                {
                    b.HasOne("WeatherApp.Models.Place", "place")
                        .WithOne("wind")
                        .HasForeignKey("WeatherApp.Models.Wind", "placeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("place");
                });

            modelBuilder.Entity("WeatherApp.Models.Place", b =>
                {
                    b.Navigation("coords");

                    b.Navigation("main");

                    b.Navigation("weather");

                    b.Navigation("wind");
                });
#pragma warning restore 612, 618
        }
    }
}
