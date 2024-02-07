using Application;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddHttpContextAccessor();

builder.Services.AddDistributedMemoryCache();
/*builder.Services.AddStackExchangeRedisCache(opt => opt.Configuration = "localhost:6379");*///redis ba�lnama alan�
//ara�t�ralacak redis ve docker
//https://redis.io/download/

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
//if (app.Environment.IsProduction())//hatalar� sadece kullan�caya uygun g�sterir
app.ConfigureCustomExceptionMiddleware();//deveplomnet katman�nda g�rmek i�in

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
