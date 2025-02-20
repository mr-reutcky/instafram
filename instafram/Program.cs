using instafram.BLL;
using instafram.Models;
using instafram.DAL;
using Microsoft.EntityFrameworkCore;

namespace instafram {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Register DbContext with the connection string from appsettings.json
            builder.Services.AddDbContext<InstaframContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Register Repositories and Services
            builder.Services.AddTransient<UserRepository>();
            builder.Services.AddTransient<PostRepository>();
            builder.Services.AddTransient<CommentRepository>();
            builder.Services.AddTransient<StoryRepository>();
            builder.Services.AddTransient<FollowRepository>();
            builder.Services.AddTransient<DmRepository>();
            builder.Services.AddTransient<LikeRepository>();
            builder.Services.AddTransient<StoryLikeRepository>();

            builder.Services.AddTransient<UserService>();
            builder.Services.AddTransient<PostService>();
            builder.Services.AddTransient<CommentService>();
            builder.Services.AddTransient<StoryService>();
            builder.Services.AddTransient<FollowService>();
            builder.Services.AddTransient<DmService>();
            builder.Services.AddTransient<LikeService>();
            builder.Services.AddTransient<StoryLikeService>();

            // Add services to the container (MVC)
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (!app.Environment.IsDevelopment()) {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
