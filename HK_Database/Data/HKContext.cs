using HK_Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace HK_Database.Data
{
    public class HKContext:DbContext
    {
        public HKContext(DbContextOptions<HKContext> options):base(options) 
        { 

        }

        public DbSet<Member> Member { get; set; }
        public DbSet<Application>Applications { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<AIFile> AIFiles { get; set; }
        public DbSet<Embedding> Embedding { get; set; }
        public DbSet<QAHistory> QAHistory { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>(options =>
            {
                options.HasOne(m => m.Members).WithMany(m => m.Applications).HasForeignKey(m => m.MemberId).OnDelete(DeleteBehavior.Cascade);//刪掉後，相關聯的資料一併刪除
            });

            modelBuilder.Entity<AIFile>(options =>
            {
                options.HasOne(a => a.Applications).WithMany(a => a.AIFiles).HasForeignKey(a => a.ApplicationId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Embedding>(options =>
            {
                options.HasOne(d => d.AIFiles).WithMany(d => d.Embeddings).HasForeignKey(d => d.AIFileId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<User>(options =>
            {
                options.HasOne(a => a.Applications).WithMany(a => a.Users).HasForeignKey(a => a.ApplicationId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Chat>(options =>
            {
                options.HasOne(u => u.Users).WithMany(u => u.Chats).HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<QAHistory>(options =>
            {
                options.HasOne(c => c.Chats).WithMany(c => c.QAHistory).HasForeignKey(c => c.ChatId).OnDelete(DeleteBehavior.Cascade);
            });

            //
            modelBuilder.Entity<Member>().HasData(
                new Member { MemberId = "C001", MemberName = "Althea", MemberEmail = "althea@gmail.com" , MemberPassword = "althea01"},
                new Member { MemberId = "C002", MemberName = "Jimmy", MemberEmail = "jimmy@gmail.com", MemberPassword = "jimmy02" }
            );

            modelBuilder.Entity<Application>().HasData(
                new Application { ApplicationId = "A001", Model = "mm", Parameter = "pp",MemberId = "C001"},
                new Application { ApplicationId = "A002", Model = "mm",Parameter = "pp",MemberId = "C002"}
            );

            modelBuilder.Entity<AIFile>().HasData(
                new AIFile { AIFileId = "D001", AIFileType = "dd", AIFilePath = "dd", ApplicationId = "A001" },
                new AIFile { AIFileId = "D002", AIFileType = "dd", AIFilePath = "dd", ApplicationId = "A002" }
            );



            modelBuilder.Entity<Embedding>().HasData(
                new Embedding { EmbeddingId="ii",EmbeddingQuestion="ee", EmbeddingAnswer = "ee",QA = "qq", EmbeddingVectors ="ee",AIFileId="D001"}

            );

            modelBuilder.Entity<Chat>().HasData(
                new Chat { ChatId = "C001",ChatTime = new DateTime(2023/05/30), ChatName = "Gay",UserId="U001"}
            );

            modelBuilder.Entity<QAHistory>().HasData(
               new QAHistory { QAHistoryId = "Q001", QAHistoryQ = "qq", QAHistoryA = "qq" , QAHistoryVectors="qq",ChatId="C001"}
            );

            modelBuilder.Entity<User>().HasData(
                new User { UserId = "U001", UserName = "Candy", UserEmail = "candy@gmail.com", UserPassword = "123456" ,ApplicationId="A001"}
               );

            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = "R001", Name = "User" },
                new Role { RoleId = "R002", Name = "Member" }
                );

            //modelBuilder.Entity<UserRoles>()
            //    .HasData(
            //    new UserRoles { UserId = "U001", RoleId = "R001" }
                
            //    );

            modelBuilder.Entity<UserRoles>()
                .HasKey(ur => new { ur.RoleId, ur.UserId });


            base.OnModelCreating(modelBuilder);
        }


    }
}
