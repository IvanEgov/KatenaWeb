using Katena.Domain;
using Katena.Domain.Repositories.Abstruct;
using Katena.Domain.Repositories.EntietyFramework;
using Katena.Domain.Repositories.EntityFramework;
using Katena.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IQuestion, EFQuestionBase>();
builder.Services.AddScoped<IQuestionPack, EFQuestionPack>();
builder.Services.AddScoped<ITextField, EFTextField>();
builder.Services.AddScoped<DataManager>();

//Подключаем контекст БД
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//Настройка Identity системы
builder.Services.AddIdentity<IdentityUser, IdentityRole>(opts =>
{
	opts.User.RequireUniqueEmail = true;
	opts.Password.RequiredLength = 6;
	opts.Password.RequireNonAlphanumeric = false;
	opts.Password.RequireLowercase = false;
	opts.Password.RequireUppercase = false;
	opts.Password.RequireDigit = false;
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

//Настраиваем куки для аутентификации
builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.Name = "KatenaAuth";
	options.Cookie.HttpOnly = true;
	options.LoginPath = "/account/login";
	options.AccessDeniedPath = "/account/accessdenied";
	options.SlidingExpiration = true;
});

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

//Подключаем систему маршрутизации
app.UseRouting();

//Подключаем аутентификацию и авторизацию
app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
