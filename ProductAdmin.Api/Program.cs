using Microsoft.EntityFrameworkCore;
using ProductAdmin.Repositoroy;
using ProductAdmin.RepositoryInterface;
using ProductAdmin.Service;
using ProductAdmin.ServiceInterface;

var builder = WebApplication.CreateBuilder(args);
//This file has now merge two files progrm.cs and startup.cs
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ProductDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("PortalConnection")));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IProductService,ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
