
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "itemsList",
    pattern: "Items/List",
    defaults: new { controller = "Items", action = "List" });

    app.MapControllerRoute(
    name: "ChildrensBooksList",
    pattern: "items/ListChildrensBooks",
    defaults: new { controller = "Items", action = "ListChildrensBooks" });

    app.MapControllerRoute(
    name: "PhilosophyBooksList",
    pattern: "items/ListPhilosophyBooks",
    defaults: new { controller = "Items", action = "ListPhilosopyBooks" });

    app.MapControllerRoute(
    name: "ContactUs",
    pattern: "Home/ContactUs",
    defaults: new { controller = "Home", action = "ContactUs" });


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
