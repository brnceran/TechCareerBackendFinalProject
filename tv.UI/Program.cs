using tv.Business.Abstract;
using tv.Business.Concrete;
using tv.DataAccess.Abstract;
using tv.DataAccess.Concrete.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IAdvertDal, EfAdvertDal>();
builder.Services.AddSingleton<IAdvertService,AdvertManager>();

builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();

builder.Services.AddSingleton<IUserDal, EfUserDal>();
builder.Services.AddSingleton<IUserService, UserManager>();

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
    pattern: "{controller=Advert}/{action=Index}/{id?}");

app.Run();
