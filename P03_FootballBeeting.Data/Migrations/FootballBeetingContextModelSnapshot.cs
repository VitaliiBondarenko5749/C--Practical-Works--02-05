﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P03_FootballBeeting.Data;

#nullable disable

namespace P03_FootballBeeting.Data.Migrations
{
    [DbContext(typeof(FootballBeetingContext))]
    partial class FootballBeetingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FootballBeeting.Data.Models.Bet", b =>
                {
                    b.Property<Guid>("BetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Prediction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BetId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Color", b =>
                {
                    b.Property<Guid>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Country", b =>
                {
                    b.Property<Guid>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Game", b =>
                {
                    b.Property<Guid>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AwayTeamBetRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AwayTeamGoals")
                        .HasColumnType("int");

                    b.Property<Guid>("AwayTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DrawBetRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HomeTeamBetRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("HomeTeamGoals")
                        .HasColumnType("int");

                    b.Property<Guid>("HomeTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Player", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsInjured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SquadNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlayerId");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.PlayerStatistic", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("MinutesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("ScoredGoals")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("PlayerStatistics");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Position", b =>
                {
                    b.Property<Guid>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Team", b =>
                {
                    b.Property<Guid>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Initials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PrimaryKitColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SecondaryKitColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TownId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TeamId");

                    b.HasIndex("PrimaryKitColorId");

                    b.HasIndex("SecondaryKitColorId");

                    b.HasIndex("TownId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Town", b =>
                {
                    b.Property<Guid>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TownId");

                    b.HasIndex("CountryId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Bet", b =>
                {
                    b.HasOne("FootballBeeting.Data.Models.Game", "Game")
                        .WithMany("Bets")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballBeeting.Data.Models.User", "User")
                        .WithMany("Bets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Game", b =>
                {
                    b.HasOne("FootballBeeting.Data.Models.Team", "AwayTeam")
                        .WithMany("AwayTeamGames")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FootballBeeting.Data.Models.Team", "HomeTeam")
                        .WithMany("HomeTeamGames")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Player", b =>
                {
                    b.HasOne("FootballBeeting.Data.Models.Position", "Position")
                        .WithMany("Players")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballBeeting.Data.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.PlayerStatistic", b =>
                {
                    b.HasOne("FootballBeeting.Data.Models.Game", "Game")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballBeeting.Data.Models.Player", "Player")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Team", b =>
                {
                    b.HasOne("FootballBeeting.Data.Models.Color", "PrimaryKitColor")
                        .WithMany("PrimaryColorTeams")
                        .HasForeignKey("PrimaryKitColorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FootballBeeting.Data.Models.Color", "SecondaryKitColor")
                        .WithMany("SecondaryColorTeams")
                        .HasForeignKey("SecondaryKitColorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FootballBeeting.Data.Models.Town", "Town")
                        .WithMany("Teams")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PrimaryKitColor");

                    b.Navigation("SecondaryKitColor");

                    b.Navigation("Town");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Town", b =>
                {
                    b.HasOne("FootballBeeting.Data.Models.Country", "Country")
                        .WithMany("Towns")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Color", b =>
                {
                    b.Navigation("PrimaryColorTeams");

                    b.Navigation("SecondaryColorTeams");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Country", b =>
                {
                    b.Navigation("Towns");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Game", b =>
                {
                    b.Navigation("Bets");

                    b.Navigation("PlayerStatistics");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Player", b =>
                {
                    b.Navigation("PlayerStatistics");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Position", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Team", b =>
                {
                    b.Navigation("AwayTeamGames");

                    b.Navigation("HomeTeamGames");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.Town", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("FootballBeeting.Data.Models.User", b =>
                {
                    b.Navigation("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}