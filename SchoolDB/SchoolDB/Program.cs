using SchoolDatabase.Models; // MongoDbSettings için gerekli
using SchoolDatabase.Services;
using Microsoft.Extensions.Options; // IOptions için gerekli

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// MongoDB ayarlarını appsettings.json'dan al ve DI (Dependency Injection) ile sisteme dahil et
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDB")
);

// Diğer servisleri ekle (örneğin, veri servisleri)
builder.Services.AddSingleton<StudentService>(); // Örnek: Öğrenci servisi

builder.Services.AddControllers();
// Swagger/OpenAPI yapılandırması
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();