using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data;
using TheBeautyForum.Data.Configurations;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Web.Data
{
    /// <summary>
    /// Represents the database context.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the appointments.
        /// </summary>
        public DbSet<Appointment> Appointments { get; set; } = null!;

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public DbSet<Category> Categories { get; set; } = null!;

        /// <summary>
        /// Gets or sets the likes.
        /// </summary>
        public DbSet<Like> Likes { get; set; } = null!;

        /// <summary>
        /// Gets or sets the publications.
        /// </summary>
        public DbSet<Publication> Publications { get; set; } = null!;

        /// <summary>
        /// Gets or sets the ratings.
        /// </summary>
        public DbSet<Rating> Ratings { get; set; } = null!;

        /// <summary>
        /// Gets or sets the studios.
        /// </summary>
        public DbSet<Studio> Studios { get; set; } = null!;

        /// <summary>
        /// Gets or sets the studios categories.
        /// </summary>
        public DbSet<StudioCategory> StudiosCategories { get; set; } = null!;

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        public DbSet<Image> Images { get; set; } = null!;

        /// <inheritdoc/>
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

            modelBuilder.Entity<Like>(builder =>
            {
                builder.HasOne(p => p.Publication)
                .WithMany(l => l.Likes)
                .HasForeignKey(p => p.PublicationId)
                .OnDelete(DeleteBehavior.Cascade);

                builder.HasOne(u => u.User)
                .WithMany(l => l.Likes)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new StudioConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new StudioCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new RatingConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRolesConfiguration());
            modelBuilder.ApplyConfiguration(new LikeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}