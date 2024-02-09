using Katena.Domain;
using Katena.Domain.Repositories.Abstruct;
using Katena.Domain.Repositories.EntietyFramework;
using Katena.Domain.Repositories.EntityFramework;
using Katena.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IQuestion, EFQuestion>();
builder.Services.AddScoped<IQuestionPack, EFQuestionPack>();
builder.Services.AddScoped<ITextField, EFTextField>();
builder.Services.AddScoped<DataManager>();

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var app = builder.Build();

IConfiguration configuration = app.Configuration;

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
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
