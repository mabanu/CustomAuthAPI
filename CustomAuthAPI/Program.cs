using Microsoft.EntityFrameworkCore;
using CustomAuthAPI.Repository.Interfaces;
using CustomAuthAPI.Repository.Repo;
using CustomAuthAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IStoreRepository, StoreRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseMySQL(builder.Configuration.GetConnectionString("sqlConnection")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
builder.Configuration.AddUserSecrets<Program>();


app.UseCors(cors => cors
	.AllowAnyHeader()
	.AllowAnyMethod()
	.AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();