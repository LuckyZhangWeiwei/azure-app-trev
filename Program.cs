var builder = WebApplication.CreateBuilder(args);

// 添加服务
builder.Services.AddRazorPages(); // 如果使用 Razor Pages
builder.Services.AddControllers(); // 如果使用 MVC / API

var app = builder.Build();

// 配置中间件
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();      // 替代 MapStaticAssets

app.UseRouting();

app.UseAuthorization();

// 绑定端点
app.MapRazorPages();       // 替代 WithStaticAssets
app.MapControllers();      // 如果有 API

app.Run();