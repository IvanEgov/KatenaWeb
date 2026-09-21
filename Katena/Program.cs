using Katena.Domain;
using Katena.Domain.Entities;
using Katena.Domain.Repositories.Abstruct;
using Katena.Domain.Repositories.EntietyFramework;
using Katena.Domain.Repositories.EntityFramework;
using Katena.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IQuestion, EFQuestionBase>();
builder.Services.AddScoped<IQuestionPack, EFQuestionPack>();
builder.Services.AddScoped<ITextField, EFTextField>();
builder.Services.AddScoped<IAnswers, EFAnswersBase>();
builder.Services.AddScoped<IResaults, EFResaultsBase>();
builder.Services.AddScoped<IReason, EFReasonBase>();
builder.Services.AddScoped<INews, EFNewsBase>();
builder.Services.AddScoped<IFeedback, EFFeedbackBase>();
builder.Services.AddScoped<DataManager>();

//Подключаем контекст БД
builder.Services.AddDbContext<AppDbContext>(x => x.UseMySql(builder.Configuration.GetConnectionString("Default"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("Default"))));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//Настройка Identity системы
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(opts =>
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

// Настройка сесии 
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

//Настраиваем политику авторизации для Admin area
builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
});

//Добавляем сервисы для контроллеров и представлений (MVC)
builder.Services.AddControllersWithViews(x =>
{
	x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
})
	//выставляем совместимость с asp.net core 3.0
  .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();

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
app.UseSession();   // добавляем middleware для работы с сессиями
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
