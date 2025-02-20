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
            entity.HasKey(e => e.CommentId).HasName("PK__comment__C3B4DFCA5A4EEEF9");

            entity.ToTable("comment");

            entity.Property(e => e.Comment1)
                .HasMaxLength(500)
                .HasColumnName("Comment");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Post).WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__comment__PostId__5070F446");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__comment__UserId__5165187F");
        });

        modelBuilder.Entity<Dm>(entity =>
        {
            entity.HasKey(e => e.Dmid).HasName("PK__DM__28BFED415263347B");

            entity.ToTable("DM");

            entity.Property(e => e.Dmid).HasColumnName("DMId");
            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Recipient).WithMany(p => p.DmRecipients)
                .HasForeignKey(d => d.RecipientId)
                .HasConstraintName("FK__DM__RecipientId__60A75C0F");

            entity.HasOne(d => d.Sender).WithMany(p => p.DmSenders)
                .HasForeignKey(d => d.SenderId)
                .HasConstraintName("FK__DM__SenderId__5FB337D6");
        });

        modelBuilder.Entity<Follow>(entity =>
        {
            entity.HasKey(e => e.FollowId).HasName("PK__follow__2CE810AE11197087");

            entity.ToTable("follow");

            entity.HasIndex(e => new { e.FollowerId, e.FolloweeId }, "unique_follow").IsUnique();

            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Followee).WithMany(p => p.FollowFollowees)
                .HasForeignKey(d => d.FolloweeId)
                .HasConstraintName("FK__follow__Followee__571DF1D5");

            entity.HasOne(d => d.Follower).WithMany(p => p.FollowFollowers)
                .HasForeignKey(d => d.FollowerId)
                .HasConstraintName("FK__follow__Follower__5629CD9C");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasKey(e => e.LikeId).HasName("PK__likes__A2922C146E20C8E9");

            entity.ToTable("likes");

            entity.HasIndex(e => new { e.UserId, e.PostId }, "unique_like").IsUnique();

            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Post).WithMany(p => p.LikesNavigation)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__likes__PostId__66603565");

            entity.HasOne(d => d.User).WithMany(p => p.Likes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__likes__UserId__656C112C");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__post__AA1260185CCECC8C");

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
                .HasConstraintName("FK__post__UserId__4CA06362");
        });

        modelBuilder.Entity<Story>(entity =>
        {
            entity.HasKey(e => e.StoryId).HasName("PK__story__3E82C048FCE9283C");

            entity.ToTable("story");

            entity.Property(e => e.ExpirationTime).HasColumnType("datetime");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Views).HasDefaultValue(0);

            entity.HasOne(d => d.User).WithMany(p => p.Stories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__story__UserId__5BE2A6F2");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__1788CC4CB79CD3A2");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "UQ__users__536C85E4A208CC09").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__users__A9D105343FFD74A3").IsUnique();

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
