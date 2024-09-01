using Dependency_Injection_IoC_Ornek_3.Models;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
// RuntimeCompilation Nugetten yukledik ve AddRazorRuntimeCompilation seklinde
// ekledik bunun amaci sayfayi refles ettigimde degisikligi gormek


builder.Services.AddSingleton<DbConfigurations>();  // Nesne bir kez uretir. Herkese her requeste bu nesne gonderilir
//builder.Services.AddScoped<DbConfigurations>();     // Ýstegi yapana gore uretir
//builder.Services.AddTransient<DbConfigurations>();  // Her requese yeniden nesne uretir





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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
