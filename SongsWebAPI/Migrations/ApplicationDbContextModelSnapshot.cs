﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SongsWebAPI.Data;

#nullable disable

namespace SongsWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SongsWebAPI.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "Remnant 2 OST",
                            Artist = "Rob Westwood",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "You Shall Rise (feat. Merethe Soltvedt)"
                        },
                        new
                        {
                            Id = 2,
                            Album = "Death Stranding OST",
                            Artist = "Ludvig Forssell",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "BB's Theme (from Death Stranding)"
                        },
                        new
                        {
                            Id = 3,
                            Album = "Doom Eternal OST",
                            Artist = "Mick Gordon",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "BFG Division 2020 (Fortress of Doom Combat Theme)"
                        },
                        new
                        {
                            Id = 4,
                            Album = "Warhammer 40,000: Darktide OST",
                            Artist = "Jesper Kyd",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Disposal Unit (Imperium Mix)"
                        },
                        new
                        {
                            Id = 5,
                            Album = "Remnant 2 OST",
                            Artist = "Rob Westwood",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Annihilation"
                        },
                        new
                        {
                            Id = 6,
                            Album = "Remnant 2 OST",
                            Artist = "Rob Westwood",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sha'Hala: Guardian of N'Erud (Physical)"
                        },
                        new
                        {
                            Id = 7,
                            Album = "Remnant 2 OST",
                            Artist = "Rob Westwood",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sha'Hala: Guardian of N'Erud (Spectral)"
                        },
                        new
                        {
                            Id = 8,
                            Album = "Remnant 2 OST",
                            Artist = "Rob Westwood",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Shades of Root (Cancer)"
                        },
                        new
                        {
                            Id = 9,
                            Album = "Where the Water Tastes Like Wine OST",
                            Artist = "Ryan Ike",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Vagrant Song (Deep South)"
                        },
                        new
                        {
                            Id = 10,
                            Album = "The Sinners Songbook (From: Hunt: Showdown)",
                            Artist = "Port Sulphur Band",
                            Genre = "Game OST",
                            Likes = 0,
                            ReleaseDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rise Up Dead Man"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
