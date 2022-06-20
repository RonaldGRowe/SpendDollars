using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpendDollars.Data;
using SpendDollars.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MoneyDbContext>(options =>
  options.UseSqlite(builder.Configuration.GetConnectionString("MoneyDbContext")));

builder.Services.AddSingleton<MoneySpentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/api/moneyspent", ([FromServices] MoneySpentService service) =>
{
    return Results.Ok(service.GetAverage());
});
app.MapGet("/api/moneyspent/latest", ([FromServices]  MoneySpentService service) =>
{
    return Results.Ok(service.GetLatest());
});
app.Run();
