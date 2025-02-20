using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace instafram.Models;

public partial class InstaframContext : DbContext
{
    public InstaframContext()
    {
    }

    public InstaframContext(DbContextOptions<InstaframContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Dm> Dms { get; set; }

    public virtual DbSet<Follow> Follows { get; set; }

    public virtual DbSet<Like> Likes { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Story> Stories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SAMUELS_LAPTOP\\SQLEXPRESS;Database=instafram;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__comment__C3B4DFCA1A5F0E04");

            entity.ToTable("comment");

            entity.Property(e => e.Comment1)
                .HasMaxLength(500)
                .HasColumnName("Comment");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Post).WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__comment__PostId__73BA3083");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__comment__UserId__74AE54BC");
        });

        modelBuilder.Entity<Dm>(entity =>
        {
            entity.HasKey(e => e.Dmid).HasName("PK__DM__28BFED41014DED8F");

            entity.ToTable("DM");

            entity.Property(e => e.Dmid).HasColumnName("DMId");
            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Recipient).WithMany(p => p.DmRecipients)
                .HasForeignKey(d => d.RecipientId)
                .HasConstraintName("FK__DM__RecipientId__04E4BC85");

            entity.HasOne(d => d.Sender).WithMany(p => p.DmSenders)
                .HasForeignKey(d => d.SenderId)
                .HasConstraintName("FK__DM__SenderId__03F0984C");
        });

        modelBuilder.Entity<Follow>(entity =>
        {
            entity.HasKey(e => e.FollowId).HasName("PK__follow__2CE810AE7C142535");

            entity.ToTable("follow");

            entity.HasIndex(e => new { e.FollowerId, e.FolloweeId }, "unique_follow").IsUnique();

            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Followee).WithMany(p => p.FollowFollowees)
                .HasForeignKey(d => d.FolloweeId)
                .HasConstraintName("FK__follow__Followee__7A672E12");

            entity.HasOne(d => d.Follower).WithMany(p => p.FollowFollowers)
                .HasForeignKey(d => d.FollowerId)
                .HasConstraintName("FK__follow__Follower__797309D9");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasKey(e => e.LikeId).HasName("PK__likes__A2922C140FD9979E");

            entity.ToTable("likes");

            entity.HasIndex(e => new { e.UserId, e.PostId }, "unique_like").IsUnique();

            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Post).WithMany(p => p.LikesNavigation)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__likes__PostId__0A9D95DB");

            entity.HasOne(d => d.User).WithMany(p => p.Likes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__likes__UserId__09A971A2");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__post__AA12601839A2BC9B");

            entity.ToTable("post");

            entity.Property(e => e.Caption).HasMaxLength(500);
            entity.Property(e => e.Likes).HasDefaultValue(0);
            entity.Property(e => e.Picture).HasMaxLength(255);
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Views).HasDefaultValue(0);

            entity.HasOne(d => d.User).WithMany(p => p.Posts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__post__UserId__6FE99F9F");
        });

        modelBuilder.Entity<Story>(entity =>
        {
            entity.HasKey(e => e.StoryId).HasName("PK__story__3E82C048B5BDEFE5");

            entity.ToTable("story");

            entity.Property(e => e.ExpirationTime).HasColumnType("datetime");
            entity.Property(e => e.Likes).HasDefaultValue(0);
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Views).HasDefaultValue(0);

            entity.HasOne(d => d.User).WithMany(p => p.Stories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__story__UserId__00200768");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__1788CC4C40204E7E");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "UQ__users__536C85E499B52DDA").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__users__A9D10534B2DC2DD1").IsUnique();

            entity.Property(e => e.Bio).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.ProfilePic).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
