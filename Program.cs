using ApiWithAuhtentications.Authentication.ApiKey;
using ApiWithAuhtentications.Authentication.Authentication.ApiKey;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using WebAppiUsers.Configuration;
using WebAppiUsers.Context;
using WebAppiUsers.Middleware;
using WebAppiUsers.Models;
using WebAppiUsers.Repositories;
using WebAppiUsers.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();

//to musi byc dla core6
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;
var connectionString = configuration.GetConnectionString("Default");
builder.Services.AddDbContext<MainApplicationContext>(o => o.UseSqlite(connectionString));

//// app configuration
//builder.Services.Configure<APISettings>(configuration.GetSection("APISettings"));//TODO czytanie z appsettings nie dziala

//builder.Services.AddSingleton<
//    IAuthorizationMiddlewareResultHandler, SampleAuthorizationMiddlewareResultHandler>();//nie dziala

//builder.Services.AddHttpClient("ApiKey", httpClient =>
//{
//    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("ApiKey", "8e421ff965cb4935ba56ef7833bf4750");//nie dziala
//    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(scheme: "ApiKey", parameter: "8e421ff965cb4935ba56ef7833bf4750");
//});


builder.Services
    .AddAuthentication(sharedOptions =>
    {
        sharedOptions.DefaultScheme = ApiKeyAuthenticationOptions.AuthenticationScheme;
    })
    .AddApiKey<ApiKeyAuthenticationService>(options => configuration.Bind("ApiKeyAuth", options));

//builder.Services.AddDefaultIdentity<User>(options =>
//{
//    options.SignIn.RequireConfirmedAccount = true;
//    options.Lockout.MaxFailedAccessAttempts = 3;
//    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
//    options.User.RequireUniqueEmail = true;
//    options.SignIn.RequireConfirmedEmail = true;
//})
//    .AddRoles<UserRole>()
//    .AddEntityFrameworkStores<MainApplicationContext>();

builder.Services.AddTransient<IRepositoryService<User>, UserService>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

//builder.Services.AddTransient<DatabaseAdminSeeder>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<MainApplicationContext>();
    //var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    //var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRoles>>();
    dataContext?.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{    
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<MyExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

//app.UseMiddleware<ApiKeyMiddleware>();//TODO wprowadzenie autoryzacji ale nie dziala

app.MapControllers();

app.Run();
