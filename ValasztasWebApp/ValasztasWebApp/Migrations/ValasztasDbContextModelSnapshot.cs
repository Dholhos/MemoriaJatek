﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ValasztasWebApp.Models;

#nullable disable

namespace ValasztasWebApp.Migrations
{
    [DbContext(typeof(ValasztasDbContext))]
    partial class ValasztasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ValasztasWebApp.Models.Jelolt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kerulet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PartrovidNev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SzavazatokSzama")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PartrovidNev");

                    b.ToTable("Jelolt");
                });

            modelBuilder.Entity("ValasztasWebApp.Models.Part", b =>
                {
                    b.Property<string>("rovidNev")
                        .HasColumnType("TEXT");

                    b.Property<string>("hosszudNev")
                        .HasColumnType("TEXT");

                    b.HasKey("rovidNev");

                    b.ToTable("Partok");
                });

            modelBuilder.Entity("ValasztasWebApp.Models.Jelolt", b =>
                {
                    b.HasOne("ValasztasWebApp.Models.Part", "Part")
                        .WithMany("Jeloltek")
                        .HasForeignKey("PartrovidNev")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Part");
                });

            modelBuilder.Entity("ValasztasWebApp.Models.Part", b =>
                {
                    b.Navigation("Jeloltek");
                });
#pragma warning restore 612, 618
        }
    }
}
