using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace openAPI.Models;

public partial class Hkcontext : DbContext
{
    public Hkcontext()
    {
    }

    public Hkcontext(DbContextOptions<Hkcontext> options)
        : base(options)
    {
    }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Data> Datas { get; set; }

    public virtual DbSet<Embedding> Embeddings { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Qahistory> Qahistories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasIndex(e => e.MemberId, "IX_Applications_MemberId");

            entity.HasOne(d => d.Member).WithMany(p => p.Applications).HasForeignKey(d => d.MemberId);
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Chats_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.Chats).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Data>(entity =>
        {
            entity.HasIndex(e => e.ApplicationId, "IX_Datas_ApplicationId");

            entity.HasOne(d => d.Application).WithMany(p => p.Data).HasForeignKey(d => d.ApplicationId);
        });

        modelBuilder.Entity<Embedding>(entity =>
        {
            entity.HasKey(e => e.Index);

            entity.ToTable("Embedding");

            entity.HasIndex(e => e.DataId, "IX_Embedding_DataId");

            entity.Property(e => e.Qa).HasColumnName("QA");
            entity.Property(e => e.Index).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Data).WithMany(p => p.Embeddings).HasForeignKey(d => d.DataId);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.ToTable("Member");

            entity.Property(e => e.Apikey).HasColumnName("APIKey");
        });

        modelBuilder.Entity<Qahistory>(entity =>
        {
            entity.ToTable("QAHistory");

            entity.HasIndex(e => e.ChatId, "IX_QAHistory_ChatId");

            entity.Property(e => e.QahistoryId).HasColumnName("QAHistoryId");
            entity.Property(e => e.QahistoryA).HasColumnName("QAHistoryA");
            entity.Property(e => e.QahistoryQ).HasColumnName("QAHistoryQ");
            entity.Property(e => e.QahistoryVectors).HasColumnName("QAHistoryVectors");

            entity.HasOne(d => d.Chat).WithMany(p => p.Qahistories).HasForeignKey(d => d.ChatId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.ApplicationId, "IX_Users_ApplicationId");

            entity.HasOne(d => d.Application).WithMany(p => p.Users).HasForeignKey(d => d.ApplicationId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
