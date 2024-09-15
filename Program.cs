using Identity_SampleProject.Entities;
using Identity_SampleProject.IdentityContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();
builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme);
builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<IdentityDatabaseContext>()
    .AddDefaultTokenProviders();



builder.Services.AddDbContext<IdentityDatabaseContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnectionString")));

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapIden

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
