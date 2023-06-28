﻿// <auto-generated />
using System;
using HK_Database.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HK_Database.Migrations
{
    [DbContext(typeof(HKContext))]
    [Migration("20230628113858_a")]
    partial class a
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HK_Database.Models.AIFile", b =>
                {
                    b.Property<string>("AIFileId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AIFilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AIFileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AIFileId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("AIFiles");

                    b.HasData(
                        new
                        {
                            AIFileId = "D001",
                            AIFilePath = "dd",
                            AIFileType = "dd",
                            ApplicationId = "A001"
                        },
                        new
                        {
                            AIFileId = "D002",
                            AIFilePath = "dd",
                            AIFileType = "dd",
                            ApplicationId = "A002"
                        });
                });

            modelBuilder.Entity("HK_Database.Models.Application", b =>
                {
                    b.Property<string>("ApplicationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parameter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationId");

                    b.HasIndex("MemberId");

                    b.ToTable("Applications");

                    b.HasData(
                        new
                        {
                            ApplicationId = "A001",
                            MemberId = "C001",
                            Model = "mm",
                            Parameter = "pp"
                        },
                        new
                        {
                            ApplicationId = "A002",
                            MemberId = "C002",
                            Model = "mm",
                            Parameter = "pp"
                        });
                });

            modelBuilder.Entity("HK_Database.Models.Chat", b =>
                {
                    b.Property<string>("ChatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ChatTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("Chats");

                    b.HasData(
                        new
                        {
                            ChatId = "C001",
                            ChatName = "Gay",
                            ChatTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(13),
                            UserId = "U001"
                        });
                });

            modelBuilder.Entity("HK_Database.Models.Embedding", b =>
                {
                    b.Property<string>("EmbeddingId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AIFileId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmbeddingAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmbeddingQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmbeddingVectors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmbeddingId");

                    b.HasIndex("AIFileId");

                    b.ToTable("Embedding");

                    b.HasData(
                        new
                        {
                            EmbeddingId = "ii",
                            AIFileId = "D001",
                            EmbeddingAnswer = "ee",
                            EmbeddingQuestion = "ee",
                            EmbeddingVectors = "ee",
                            QA = "qq"
                        });
                });

            modelBuilder.Entity("HK_Database.Models.Member", b =>
                {
                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MemberEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.ToTable("Member");

                    b.HasData(
                        new
                        {
                            MemberId = "C001",
                            MemberEmail = "althea@gmail.com",
                            MemberName = "Althea",
                            MemberPassword = "althea01"
                        },
                        new
                        {
                            MemberId = "C002",
                            MemberEmail = "jimmy@gmail.com",
                            MemberName = "Jimmy",
                            MemberPassword = "jimmy02"
                        });
                });

            modelBuilder.Entity("HK_Database.Models.QAHistory", b =>
                {
                    b.Property<string>("QAHistoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("QAHistoryA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QAHistoryQ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QAHistoryVectors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QAHistoryId");

                    b.HasIndex("ChatId");

                    b.ToTable("QAHistory");

                    b.HasData(
                        new
                        {
                            QAHistoryId = "Q001",
                            ChatId = "C001",
                            QAHistoryA = "qq",
                            QAHistoryQ = "qq",
                            QAHistoryVectors = "qq"
                        });
                });

            modelBuilder.Entity("HK_Database.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = "U001",
                            ApplicationId = "A001",
                            UserEmail = "candy@gmail.com",
                            UserName = "Candy",
                            UserPassword = "candy03"
                        });
                });

            modelBuilder.Entity("HK_Database.Models.AIFile", b =>
                {
                    b.HasOne("HK_Database.Models.Application", "Applications")
                        .WithMany("AIFiles")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Applications");
                });

            modelBuilder.Entity("HK_Database.Models.Application", b =>
                {
                    b.HasOne("HK_Database.Models.Member", "Members")
                        .WithMany("Applications")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Members");
                });

            modelBuilder.Entity("HK_Database.Models.Chat", b =>
                {
                    b.HasOne("HK_Database.Models.User", "Users")
                        .WithMany("Chats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HK_Database.Models.Embedding", b =>
                {
                    b.HasOne("HK_Database.Models.AIFile", "AIFiles")
                        .WithMany("Embeddings")
                        .HasForeignKey("AIFileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("AIFiles");
                });

            modelBuilder.Entity("HK_Database.Models.QAHistory", b =>
                {
                    b.HasOne("HK_Database.Models.Chat", "Chats")
                        .WithMany("QAHistory")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Chats");
                });

            modelBuilder.Entity("HK_Database.Models.User", b =>
                {
                    b.HasOne("HK_Database.Models.Application", "Applications")
                        .WithMany("Users")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Applications");
                });

            modelBuilder.Entity("HK_Database.Models.AIFile", b =>
                {
                    b.Navigation("Embeddings");
                });

            modelBuilder.Entity("HK_Database.Models.Application", b =>
                {
                    b.Navigation("AIFiles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HK_Database.Models.Chat", b =>
                {
                    b.Navigation("QAHistory");
                });

            modelBuilder.Entity("HK_Database.Models.Member", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("HK_Database.Models.User", b =>
                {
                    b.Navigation("Chats");
                });
#pragma warning restore 612, 618
        }
    }
}
