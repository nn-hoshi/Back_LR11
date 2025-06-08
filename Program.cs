var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllProduct", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
    options.AddPolicy("Kotiki", policy =>
    {
        policy.WithOrigins("https://ibb.co/LXdFDRvr", "https://ibb.co/7tKXmxTy", "https://ru.pinterest.com").AllowAnyHeader().AllowAnyMethod();
    });
});

// ��������� ������ ����������� �������
builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllProduct");
// ����������� ������������ middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


app.Run();