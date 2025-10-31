using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NewApp.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(Options =>
    Options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

// Add services to the container .
builder.Services.AddControllersWithViews();

var app = builder.Build();
