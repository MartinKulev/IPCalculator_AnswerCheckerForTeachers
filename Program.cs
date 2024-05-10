using IPTestFormASP.Data;
using IPTestFormASPTeacherApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IPTestFormASPDbContext>(c => c.UseMySQL("Server=mysql-210770ab-techstore.b.aivencloud.com;Database=iptests;Uid=avnadmin;Pwd=AVNS_ECNjUML_9rCSuGwr_PA;Port=15039"));
builder.Services.AddScoped<IPService>();

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
    pattern: "{controller=InternetProtocol}/{action=TestsList}/{id?}");

app.Run();
