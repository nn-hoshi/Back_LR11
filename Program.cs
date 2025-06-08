var builder = WebApplication.CreateBuilder(args);

// ��������� ������ ����������� �������
builder.Services.AddControllers();

var app = builder.Build();

// ����������� ������������ middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();