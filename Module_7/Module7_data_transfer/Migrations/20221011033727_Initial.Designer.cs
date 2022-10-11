﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module7_data_transfer.Models;

#nullable disable

namespace Module7_data_transfer.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20221011033727_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Module7_data_transfer.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryID = "outdoor",
                            Name = "OutDoor"
                        });
                });

            modelBuilder.Entity("Module7_data_transfer.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FlagImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameID");

                    b.ToTable("Countrys");

                    b.HasData(
                        new
                        {
                            CountryID = "can",
                            CategoryID = "indoor",
                            FlagImage = "images/canadian_flag.png",
                            GameID = "winter-olympics",
                            Name = "Canada"
                        },
                        new
                        {
                            CountryID = "swe",
                            CategoryID = "indoor",
                            FlagImage = "images/swedish_flag.png",
                            GameID = "winter-olympics",
                            Name = "Sweden"
                        },
                        new
                        {
                            CountryID = "gb",
                            CategoryID = "indoor",
                            FlagImage = "images/british_flag.png",
                            GameID = "winter-olympics",
                            Name = "Great Britain"
                        },
                        new
                        {
                            CountryID = "jam",
                            CategoryID = "outdoor",
                            FlagImage = "images/jamaican_flag.png",
                            GameID = "winter-olympics",
                            Name = "Jamaica"
                        },
                        new
                        {
                            CountryID = "ita",
                            CategoryID = "outdoor",
                            FlagImage = "images/italian_flag.png",
                            GameID = "winter-olympics",
                            Name = "Italy"
                        },
                        new
                        {
                            CountryID = "jap",
                            CategoryID = "outdoor",
                            FlagImage = "images/japanese_flag.png",
                            GameID = "winter-olympics",
                            Name = "Japan"
                        },
                        new
                        {
                            CountryID = "ger",
                            CategoryID = "indoor",
                            FlagImage = "images/german_flag.png",
                            GameID = "summer-olympics",
                            Name = "Germany"
                        },
                        new
                        {
                            CountryID = "chi",
                            CategoryID = "indoor",
                            FlagImage = "images/chinese_flag.png",
                            GameID = "summer-olympics",
                            Name = "China"
                        },
                        new
                        {
                            CountryID = "mex",
                            CategoryID = "indoor",
                            FlagImage = "images/mexican_flag.png",
                            GameID = "summer-olympics",
                            Name = "Mexico"
                        },
                        new
                        {
                            CountryID = "bra",
                            CategoryID = "outdoor",
                            FlagImage = "images/brazillian_flag.png",
                            GameID = "summer-olympics",
                            Name = "Brazil"
                        },
                        new
                        {
                            CountryID = "net",
                            CategoryID = "outdoor",
                            FlagImage = "images/netherlands_flag.png",
                            GameID = "summer-olympics",
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryID = "usa",
                            CategoryID = "outdoor",
                            FlagImage = "images/usa_flag.png",
                            GameID = "summer-olympics",
                            Name = "USA"
                        },
                        new
                        {
                            CountryID = "thai",
                            CategoryID = "indoor",
                            FlagImage = "images/thai_flag.png",
                            GameID = "parlympics",
                            Name = "Thailand"
                        },
                        new
                        {
                            CountryID = "uru",
                            CategoryID = "indoor",
                            FlagImage = "images/uruguay_flag.png",
                            GameID = "parlympics",
                            Name = "Uruguay"
                        },
                        new
                        {
                            CountryID = "ukr",
                            CategoryID = "indoor",
                            FlagImage = "images/ukrain_flag.png",
                            GameID = "parlympics",
                            Name = "Ukrain"
                        },
                        new
                        {
                            CountryID = "aus",
                            CategoryID = "outdoor",
                            FlagImage = "images/australian_flag.png",
                            GameID = "parlympics",
                            Name = "Australia"
                        },
                        new
                        {
                            CountryID = "pak",
                            CategoryID = "outdoor",
                            FlagImage = "images/pakistan_flag.png",
                            GameID = "parlympics",
                            Name = "Pakistan"
                        },
                        new
                        {
                            CountryID = "zim",
                            CategoryID = "outdoor",
                            FlagImage = "images/zimbabwe_flag.png",
                            GameID = "parlympics",
                            Name = "Zimbabwe"
                        },
                        new
                        {
                            CountryID = "fra",
                            CategoryID = "indoor",
                            FlagImage = "images/french_flag.png",
                            GameID = "youth-olympics",
                            Name = "France"
                        },
                        new
                        {
                            CountryID = "cyp",
                            CategoryID = "indoor",
                            FlagImage = "images/cyprus_flag.png",
                            GameID = "youth-olympics",
                            Name = "Cyprus"
                        },
                        new
                        {
                            CountryID = "rus",
                            CategoryID = "indoor",
                            FlagImage = "images/russian_flag.png",
                            GameID = "youth-olympics",
                            Name = "Russia"
                        },
                        new
                        {
                            CountryID = "fin",
                            CategoryID = "outdoor",
                            FlagImage = "images/finnish_flag.png",
                            GameID = "youth-olympics",
                            Name = "Finland"
                        },
                        new
                        {
                            CountryID = "slov",
                            CategoryID = "outdoor",
                            FlagImage = "images/slovakian_flag.png",
                            GameID = "youth-olympics",
                            Name = "Slovakia"
                        },
                        new
                        {
                            CountryID = "por",
                            CategoryID = "outdoor",
                            FlagImage = "images/portugese_flag.png",
                            GameID = "youth-olympics",
                            Name = "Portugal"
                        });
                });

            modelBuilder.Entity("Module7_data_transfer.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "winter-olympics",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "summer-olympics",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "parlympics",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "Youth-olympics",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("Module7_data_transfer.Models.Country", b =>
                {
                    b.HasOne("Module7_data_transfer.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module7_data_transfer.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");

                    b.Navigation("Category");

                    b.Navigation("Game");
                });
#pragma warning restore 612, 618
        }
    }
}
