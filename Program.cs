var builder = WebApplication.CreateBuilder(args);

// ✅ Adiciona suporte a controllers
builder.Services.AddControllers();

// (opcional, mas útil)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger (interface pra testar)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// ✅ ESSA LINHA É A MAIS IMPORTANTE
app.MapControllers();

app.Run();