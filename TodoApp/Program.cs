using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Repository;
using TodoApp.Repository.InMemory;
using TodoApp.Repository.MsSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Validation framework, DI asp.net core

// configure asp.net the ef library to connect for a db
builder.Services.AddDbContext<TodoDBContext>();
// configure identity framework
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<TodoDBContext>();

// DI object is configured by a constructor inject the object defined here 
builder.Services.AddScoped<TodoDBContext, TodoDBContext>();
// if test environment then work with inmemroy object
// else work with database
// asp.net automatically configures objects using DI concept
// use AddScoped if you are using database
builder.Services.AddScoped<ITodoRepository, TodoDBRepository>();

// Whenwe use In Memory, use  AddSingleton
// builder.Services.AddSingleton<ITodoRepository,TodoInMemoryRepository>();

// DI
// AddSingleton - one object is created for the full application
// AddScroped -  an object is created for all request response pipeline
// AddTransient - a new objectis created for every request

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.Automigrate();


// Auto-Migrate
/*using (var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope())
{
    var context = serviceScope.ServiceProvider.GetRequiredService<TodoDBContext>();
    context.Database.Migrate();
}*/

/*
 Anadawan for Migration

using (var scope = app.Services.CreateScope())
{
    using (var appContext = scope.ServiceProvider.GetRequiredService<TodoDbContext>())
    {
        try
        {
            appContext.Database.Migrate(); // migration are there in the assembly update them on the database.
        }
        catch (Exception ex)
        {
            //Log errors or do anything you think it's needed
            throw;
        }
    }
}
 */

app.UseRouting();

app.UseAuthorization();

// it identifes the controllers folder list a set of url which it can prepare 
// /home
// /todo/GetAllTodos
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=GetAllTodos}/{id?}");

app.Run();
