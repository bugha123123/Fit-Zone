using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Instagram_Clone.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stripe;
using Instagram_Clone.ApplicationDBContext;
using AccountService = Instagram_Clone.Service.AccountService;

var builder = WebApplication.CreateBuilder(args);
var facebookAppId = builder.Configuration["Authentication:Facebook:AppId"];
var facebookAppSecret = builder.Configuration["Authentication:Facebook:AppSecret"];
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("InstagramCloneString")));
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 1;
    options.Password.RequiredUniqueChars = 0;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

//services
builder.Services.AddScoped<IExerciseService, ExerciseService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IFeedBackService, FeedBackService>();

//services
StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.MapGet("/", (HttpContext context) =>
{
    if (!context.User.Identity.IsAuthenticated)
    {
        // Redirect unauthenticated users to the login page
        context.Response.Redirect("/Account/LogInPage");
        return Task.CompletedTask;
    }
    else
    {
        context.Response.Redirect("/Home/Index");
        return Task.CompletedTask;
    }

    // If the user is already authenticated, return 404 or another appropriate response
    context.Response.StatusCode = 404;
    return Task.CompletedTask;
});
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();





app.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}",
        defaults: new { controller = "Home", action = "Index" });

app.Run();
