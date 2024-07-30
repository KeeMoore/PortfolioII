var builder = WebApplication.CreateBuilder(args);
// Add our service
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Our builder code
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Portfolio}/{action=Index}/{id?}");
app.Run();
