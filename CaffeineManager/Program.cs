using CaffeineManager.Model;
using SqlSugar;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMasaBlazor();
builder.Services.AddScoped<ISqlSugarClient>(s =>
{
    var sqlSugar = new SqlSugarClient(new ConnectionConfig
    {
        DbType = DbType.Sqlite,
        ConnectionString = "DataSource=O:\\CoffeeData3.db",
        IsAutoCloseConnection = true,
    });
    return sqlSugar;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// 自动建表
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ISqlSugarClient>();
    db.CodeFirst.InitTables<Coffee, ItemType>();
}

app.Run();