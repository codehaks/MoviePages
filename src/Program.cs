using MoviePages.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MovieDbContext>();
builder.Services.AddRazorPages();

var app = builder.Build();

//app.UseStaticFiles();
app.MapStaticAssets();
app.MapRazorPages();

app.Run();
