using CloudinaryDotNet;
using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Appointment;
using TheBeautyForum.Services.Category;
using TheBeautyForum.Services.Home;
using TheBeautyForum.Services.Images;
using TheBeautyForum.Services.Like;
using TheBeautyForum.Services.Publication;
using TheBeautyForum.Services.Rating;
using TheBeautyForum.Services.Studios;
using TheBeautyForum.Services.Users;
using TheBeautyForum.Web.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");
builder.Services
    .AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
    });
builder.Services
    .AddDatabaseDeveloperPageExceptionFilter();

builder.Services
    .AddDefaultIdentity<User>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
})
    .AddRoles<Role>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services
    .AddControllersWithViews();
builder.WebHost.UseStaticWebAssets();

builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IStudioService, StudioService>();
builder.Services.AddScoped<IPublicationService, PublicationService>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ILikeService, LikeService>();
ConfigureCloudinaryService(builder.Services, builder.Configuration);

builder.Services.AddResponseCaching();


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("https://localhost:7000")
                .AllowAnyHeader()
                .WithMethods("GET", "POST", "PUT")
                .AllowCredentials();
        });
});

var app = builder.Build();

app.UseCors();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapRazorPages();
});

app.Run();

static void ConfigureCloudinaryService(IServiceCollection services, IConfiguration configuration)
{

    var cloudName = configuration.GetValue<string>("AccountSettings:CloudName");
    var apiKey = configuration.GetValue<string>("AccountSettings:ApiKey");
    var apiSecret = configuration.GetValue<string>("AccountSettings:ApiSecret");

    if (new[] { cloudName, apiKey, apiSecret }.Any(string.IsNullOrWhiteSpace))
    {
        throw new ArgumentException("Please specify your Cloudinary account Information");
    }

    services.AddSingleton(new Cloudinary(new Account(cloudName, apiKey, apiSecret)));
}