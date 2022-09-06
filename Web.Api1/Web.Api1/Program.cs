using System.Web.Http;
using Web.Api1.Core.Configuration;
using Web.Api1.Core.Interfaces;
using Web.Api1.Infrastructure;
using WebApi1.Core.Services;
using System.Web.Http.Cors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IDataProvider, DataProvider>();
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.Configure<DataProviderOptions>(builder.Configuration.GetSection("DataProviderOptions"));
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
//builder.Services.AddSingleton(Configuration)

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

