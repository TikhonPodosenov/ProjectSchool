
using Microsoft.EntityFrameworkCore;
using ProjectSchool;
using ProjectSchool.DB;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<GlobalDataService>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
         options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddScoped<ISqlQueryExecutor, ApplicationDbContext>();

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

//    try
//    {
//        await dbContext.Database.CanConnectAsync();
//        Console.WriteLine("������� ���������� � ���� ������");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"������ ����������� � ���� ������: {ex.Message}");
        
//    }
//}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
  
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
