using EmptyCoreWebApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});
builder.Services.AddDbContext<UsersContext>(options =>
{
	options.UseSqlite(builder.Configuration.GetConnectionString("othersqlconnection"));
});
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddEntityFrameworkStores<UsersContext>()
        .AddDefaultTokenProviders();

var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=index}/{id?}");

app.UseAuthentication();
app.UseAuthorization();



app.Run();
