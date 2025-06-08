var builder = WebApplication.CreateBuilder(args);

// Добавляем только необходимые сервисы
builder.Services.AddControllers();

var app = builder.Build();

// Минимальная конфигурация middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();