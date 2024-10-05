using MoviePages.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MovieDbContext>();
builder.Services.AddRazorPages()
    .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[] { "fa", "en" };
    options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("fa");
    options.SupportedCultures = supportedCultures.Select(c => new System.Globalization.CultureInfo(c)).ToList();
    options.SupportedUICultures = supportedCultures.Select(c => new System.Globalization.CultureInfo(c)).ToList();
});

var app = builder.Build();

// Localization middleware to enable request localization
var supportedCultures = new[] { "fa", "en" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("fa")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

//app.UseStaticFiles();
app.MapStaticAssets();
app.MapRazorPages();

app.Run();
