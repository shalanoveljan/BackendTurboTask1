using TurboazTask1.Services.Abstract;
using TurboazTask1.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAppDataContext, AppDataContext>();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
app.Run();
