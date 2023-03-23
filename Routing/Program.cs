var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Kapsayýcýya hizmet ekle

builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
// Http istek iþlem hattýný ayarla


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();


app.UseEndpoints(endpoints => {
    endpoints.MapControllerRoute(
            name: "haber",
            pattern: "Haberler",
            defaults: new { controller = "Home", action = "Haber" }
        ) ;
    endpoints.MapControllerRoute(
            name: "spor",
            pattern: "SporHaberleri",
            defaults: new { controller = "Home", action = "Spor" }
        );
    endpoints.MapControllerRoute(
            name: "hava",
            pattern: "HavaDurumu",
            defaults: new { controller = "Home", action = "Hava" }
        );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
