using MB.Infrastructure;

var builder = WebApplication.CreateBuilder(args);



var connectionstring = builder.Configuration.GetConnectionString("MasterBlogger");

// Add services to the container.
builder.Services.AddControllersWithViews();
Bootstrapper.Config(builder.Services , connectionstring);

var app = builder.Build();

// Config the HTTP request pipeline.
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
