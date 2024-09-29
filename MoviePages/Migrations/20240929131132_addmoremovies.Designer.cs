﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviePages.Data;

#nullable disable

namespace MoviePages.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20240929131132_addmoremovies")]
    partial class addmoremovies
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-rc.1.24451.1");

            modelBuilder.Entity("Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Titanic",
                            Year = 1997
                        },
                        new
                        {
                            Id = 2,
                            Name = "The Shawshank Redemption",
                            Year = 1994
                        },
                        new
                        {
                            Id = 3,
                            Name = "The Godfather",
                            Year = 1972
                        },
                        new
                        {
                            Id = 4,
                            Name = "The Dark Knight",
                            Year = 2008
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pulp Fiction",
                            Year = 1994
                        },
                        new
                        {
                            Id = 6,
                            Name = "Forrest Gump",
                            Year = 1994
                        },
                        new
                        {
                            Id = 7,
                            Name = "Inception",
                            Year = 2010
                        },
                        new
                        {
                            Id = 8,
                            Name = "Fight Club",
                            Year = 1999
                        },
                        new
                        {
                            Id = 9,
                            Name = "The Matrix",
                            Year = 1999
                        },
                        new
                        {
                            Id = 10,
                            Name = "The Lord of the Rings: The Return of the King",
                            Year = 2003
                        },
                        new
                        {
                            Id = 11,
                            Name = "Gladiator",
                            Year = 2000
                        },
                        new
                        {
                            Id = 12,
                            Name = "The Lion King",
                            Year = 1994
                        },
                        new
                        {
                            Id = 13,
                            Name = "Schindler's List",
                            Year = 1993
                        },
                        new
                        {
                            Id = 14,
                            Name = "Goodfellas",
                            Year = 1990
                        },
                        new
                        {
                            Id = 15,
                            Name = "Star Wars: Episode IV - A New Hope",
                            Year = 1977
                        },
                        new
                        {
                            Id = 16,
                            Name = "Avengers: Endgame",
                            Year = 2019
                        },
                        new
                        {
                            Id = 17,
                            Name = "Saving Private Ryan",
                            Year = 1998
                        },
                        new
                        {
                            Id = 18,
                            Name = "The Silence of the Lambs",
                            Year = 1991
                        },
                        new
                        {
                            Id = 19,
                            Name = "Jurassic Park",
                            Year = 1993
                        },
                        new
                        {
                            Id = 20,
                            Name = "The Departed",
                            Year = 2006
                        },
                        new
                        {
                            Id = 21,
                            Name = "The Prestige",
                            Year = 2006
                        },
                        new
                        {
                            Id = 22,
                            Name = "Memento",
                            Year = 2000
                        },
                        new
                        {
                            Id = 23,
                            Name = "The Green Mile",
                            Year = 1999
                        },
                        new
                        {
                            Id = 24,
                            Name = "Braveheart",
                            Year = 1995
                        },
                        new
                        {
                            Id = 25,
                            Name = "American Beauty",
                            Year = 1999
                        },
                        new
                        {
                            Id = 26,
                            Name = "The Usual Suspects",
                            Year = 1995
                        },
                        new
                        {
                            Id = 27,
                            Name = "The Avengers",
                            Year = 2012
                        },
                        new
                        {
                            Id = 28,
                            Name = "The Wolf of Wall Street",
                            Year = 2013
                        },
                        new
                        {
                            Id = 29,
                            Name = "Django Unchained",
                            Year = 2012
                        },
                        new
                        {
                            Id = 30,
                            Name = "Interstellar",
                            Year = 2014
                        });
                });
#pragma warning restore 612, 618
        }
    }
}