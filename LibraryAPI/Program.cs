using Microsoft.EntityFrameworkCore;
using LibraryAPI.DatabaseContext;
using LibraryAPI.Services;
using LibraryAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// import DatabaseContext file
builder.Services.AddDbContext<ContextDataBase>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("TestDBString")), ServiceLifetime.Scoped);

builder.Services.AddScoped<IServiceLibrary, ServiceLibrary>();

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => Results.Redirect("/swagger"));
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();