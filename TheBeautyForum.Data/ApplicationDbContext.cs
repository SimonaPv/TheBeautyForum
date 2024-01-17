﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Comment> Comments { get; set; } = null!;

        public DbSet<Like> Likes { get; set; } = null!;

        public DbSet<Publication> Publications { get; set; } = null!;

        public DbSet<Rating> Ratings { get; set; } = null!;

        public DbSet<Studio> Studios { get; set; } = null!;

        public DbSet<StudioCategory> StudioCategories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var timeOnlyToTimeSpanConverter = new TimeOnlyToTimeSpanConverter();

            modelBuilder.Entity<Appointment>(builder =>
            {
                builder.HasOne(u => u.User)
                    .WithMany(a => a.Appointments)
                    .HasForeignKey(fk => fk.UserId)
                    .OnDelete(DeleteBehavior.NoAction);

                builder.HasOne(s => s.Studio)
                    .WithMany(s => s.Appointments)
                    .HasForeignKey(s => s.StudioId)
                    .OnDelete(DeleteBehavior.Cascade);

                builder.HasOne(c => c.Category)
                    .WithMany(c => c.Appointments)
                    .HasForeignKey(fk => fk.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Studio>(builder =>
            {
                builder.Property(p => p.OpenTime)
                 .HasConversion(timeOnlyToTimeSpanConverter);

                builder.Property(p => p.CloseTime)
                 .HasConversion(timeOnlyToTimeSpanConverter);

                builder.HasOne(u => u.User)
                    .WithMany(s => s.Studios)
                    .HasForeignKey(fk => fk.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Rating>(builder =>
            {
                builder.HasOne(u => u.User)
                    .WithMany(r => r.Ratings)
                    .HasForeignKey(fk => fk.UserId)
                    .OnDelete(DeleteBehavior.NoAction);

                builder.HasOne(s => s.Studio)
                    .WithMany(r => r.Ratings)
                    .HasForeignKey(fk => fk.StudioId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<StudioCategory>(builder =>
            {
                builder.HasKey(pk => new { pk.StudioId, pk.CategoryId });

                builder.HasOne(s => s.Studio)
                    .WithMany(sc => sc.StudioCategories)
                    .HasForeignKey(s => s.StudioId);

                builder.HasOne(s => s.Category)
                    .WithMany(sc => sc.CategoryStudios)
                    .HasForeignKey(s => s.CategoryId);
            });

            modelBuilder.Entity<Publication>(builder =>
            {
                builder.HasOne(s => s.Studio)
                .WithMany(p => p.Publications)
                .HasForeignKey(fk => fk.StudioId)
                .OnDelete(DeleteBehavior.Cascade);

                builder.HasOne(u => u.User)
                .WithMany(p => p.Publications)
                .HasForeignKey(fk => fk.UserId)
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Comment>(builder =>
            {
                builder.HasOne(p => p.Publication)
                .WithMany(c => c.Comments)
                .HasForeignKey(fk => fk.PublicationId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Like>(builder =>
            {
                builder.HasOne(p => p.Publication)
                .WithMany(l => l.Likes)
                .HasForeignKey(p => p.PublicationId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}