using dz_geometry.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ISquareService, SquareService>();
builder.Services.AddScoped<IRectangleService, RectangleService>();
builder.Services.AddScoped<ICircleService, CircleService>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
    pattern: "{controller=Geometry}/{action=Index}/{id?}");

app.Run();
