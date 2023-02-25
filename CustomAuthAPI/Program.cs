using CustomAuthAPI.Authentication;
using CustomAuthAPI.Repository.Interfaces;
using CustomAuthAPI.Repository.Repo;
using CustomAuthAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.UseSerilog((context, services, configuration) => configuration
	.ReadFrom.Configuration(context.Configuration)
	.ReadFrom.Services(services)
	.Enrich.FromLogContext()
	.WriteTo.Console()
	.WriteTo.File("Logs/logs.txt", rollingInterval: RollingInterval.Month)
);

// One way to do it but every endpoint need authorization
builder.Services.AddControllers(/*config => config.Filters.Add<ApiKeyAuthFilter>()*/);

builder.Services.AddAuthorization(options =>
{
	options.AddPolicy("RequireAdministratorRole",
		policy => policy.RequireRole("Administrator"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Add Authorization to swagger
builder.Services.AddSwaggerGen(config =>
{
	config.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
	{
		Description = "The API Key to access the API",
		Type = SecuritySchemeType.ApiKey,
		Name = "x-api-key",
		In = ParameterLocation.Header,
		Scheme = "ApiKeyScheme"
	});
	var scheme = new OpenApiSecurityScheme
	{
		Reference = new OpenApiReference
		{
			Type = ReferenceType.SecurityScheme,
			Id = "ApiKey"
		},
		In = ParameterLocation.Header
	};
	var requirement = new OpenApiSecurityRequirement
	{
		{ scheme, new List<string>() }
	};
	config.AddSecurityRequirement(requirement);
});

builder.Services.AddCors();

builder.Services.AddScoped<ApiKeyAuthFilter>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

// Every endpoint need Authorization
//app.UseMiddleware<ApiKeyAuthMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();