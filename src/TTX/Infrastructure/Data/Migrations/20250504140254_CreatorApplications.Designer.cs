﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TTX.Infrastructure.Data;

#nullable disable

namespace TTX.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250504140254_CreatorApplications")]
    partial class CreatorApplications
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TTX.Models.Creator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("avatar_url")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasColumnOrder(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasColumnOrder(1);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("slug")
                        .HasColumnOrder(2);

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ticker")
                        .HasColumnOrder(3);

                    b.Property<string>("TwitchId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("twitch_id")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at")
                        .HasColumnOrder(11);

                    b.Property<long>("Value")
                        .HasColumnType("bigint")
                        .HasColumnName("value")
                        .HasColumnOrder(6);

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.HasIndex("Ticker")
                        .IsUnique();

                    b.HasIndex("TwitchId")
                        .IsUnique();

                    b.ToTable("creators", "public");
                });

            modelBuilder.Entity("TTX.Models.CreatorApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasColumnOrder(5);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status")
                        .HasColumnOrder(4);

                    b.Property<int>("SubmitterId")
                        .HasColumnType("integer")
                        .HasColumnName("submitter_id")
                        .HasColumnOrder(1);

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ticker")
                        .HasColumnOrder(3);

                    b.Property<string>("TwitchId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("twitch_id")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at")
                        .HasColumnOrder(6);

                    b.HasKey("Id");

                    b.HasIndex("SubmitterId");

                    b.ToTable("creator_applications", "public");
                });

            modelBuilder.Entity("TTX.Models.LootBox", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasColumnOrder(3);

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer")
                        .HasColumnName("player_id")
                        .HasColumnOrder(1);

                    b.Property<int?>("ResultId")
                        .HasColumnType("integer")
                        .HasColumnName("result_id")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ResultId");

                    b.ToTable("loot_boxes", "public");
                });

            modelBuilder.Entity("TTX.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("avatar_url")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasColumnOrder(8);

                    b.Property<long>("Credits")
                        .HasColumnType("bigint")
                        .HasColumnName("credits")
                        .HasColumnOrder(5);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasColumnOrder(1);

                    b.Property<long>("Portfolio")
                        .HasColumnType("bigint")
                        .HasColumnName("portfolio")
                        .HasColumnOrder(6);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("slug")
                        .HasColumnOrder(2);

                    b.Property<string>("TwitchId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("twitch_id")
                        .HasColumnOrder(3);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type")
                        .HasColumnOrder(7);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at")
                        .HasColumnOrder(9);

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.HasIndex("TwitchId")
                        .IsUnique();

                    b.HasIndex("Type");

                    b.ToTable("players", "public");
                });

            modelBuilder.Entity("TTX.Models.PortfolioSnapshot", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("integer")
                        .HasColumnName("player_id")
                        .HasColumnOrder(0);

                    b.Property<DateTimeOffset>("Time")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("time")
                        .HasColumnOrder(3);

                    b.Property<long>("Value")
                        .HasColumnType("bigint")
                        .HasColumnName("value")
                        .HasColumnOrder(2);

                    b.HasIndex("PlayerId", "Time");

                    b.ToTable("player_portfolios", "public");
                });

            modelBuilder.Entity("TTX.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("action")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasColumnOrder(6);

                    b.Property<int>("CreatorId")
                        .HasColumnType("integer")
                        .HasColumnName("creator_id")
                        .HasColumnOrder(5);

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer")
                        .HasColumnName("player_id")
                        .HasColumnOrder(4);

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at")
                        .HasColumnOrder(7);

                    b.Property<long>("Value")
                        .HasColumnType("bigint")
                        .HasColumnName("value")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("PlayerId");

                    b.ToTable("transactions", "public");
                });

            modelBuilder.Entity("TTX.Models.Vote", b =>
                {
                    b.Property<int>("CreatorId")
                        .HasColumnType("integer")
                        .HasColumnName("creator_id")
                        .HasColumnOrder(0);

                    b.Property<DateTimeOffset>("Time")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("time")
                        .HasColumnOrder(2);

                    b.Property<long>("Value")
                        .HasColumnType("bigint")
                        .HasColumnName("value")
                        .HasColumnOrder(1);

                    b.HasIndex("CreatorId", "Time");

                    b.ToTable("votes", "public");
                });

            modelBuilder.Entity("TTX.Models.Creator", b =>
                {
                    b.OwnsOne("TTX.Models.StreamStatus", "StreamStatus", b1 =>
                        {
                            b1.Property<int>("CreatorId")
                                .HasColumnType("integer");

                            b1.Property<DateTimeOffset?>("EndedAt")
                                .HasColumnType("timestamp with time zone")
                                .HasColumnName("stream_ended_at")
                                .HasColumnOrder(9);

                            b1.Property<bool>("IsLive")
                                .HasColumnType("boolean")
                                .HasColumnName("stream_is_live")
                                .HasColumnOrder(7);

                            b1.Property<DateTimeOffset?>("StartedAt")
                                .HasColumnType("timestamp with time zone")
                                .HasColumnName("stream_started_at")
                                .HasColumnOrder(8);

                            b1.HasKey("CreatorId");

                            b1.ToTable("creators", "public");

                            b1.WithOwner()
                                .HasForeignKey("CreatorId");
                        });

                    b.Navigation("StreamStatus")
                        .IsRequired();
                });

            modelBuilder.Entity("TTX.Models.CreatorApplication", b =>
                {
                    b.HasOne("TTX.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("SubmitterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TTX.Models.LootBox", b =>
                {
                    b.HasOne("TTX.Models.Player", "Player")
                        .WithMany("LootBoxes")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TTX.Models.Creator", "Result")
                        .WithMany()
                        .HasForeignKey("ResultId");

                    b.Navigation("Player");

                    b.Navigation("Result");
                });

            modelBuilder.Entity("TTX.Models.PortfolioSnapshot", b =>
                {
                    b.HasOne("TTX.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("TTX.Models.Transaction", b =>
                {
                    b.HasOne("TTX.Models.Creator", "Creator")
                        .WithMany("Transactions")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TTX.Models.Player", "Player")
                        .WithMany("Transactions")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("TTX.Models.Vote", b =>
                {
                    b.HasOne("TTX.Models.Creator", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("TTX.Models.Creator", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("TTX.Models.Player", b =>
                {
                    b.Navigation("LootBoxes");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
