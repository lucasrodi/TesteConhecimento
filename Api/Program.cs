using Api.Data;
using Api.IServices;
using Api.Services;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IApplicationContext, ApplicationContext>();
builder.Services.AddTransient<IAddFilme, AddFilme>();
builder.Services.AddTransient<IGetFilmeId, GetFilmeId>();
builder.Services.AddTransient<IGetAllFilme, GetAllFilme>();
builder.Services.AddTransient<IRemoveFilme, RemoveFilme>();
builder.Services.AddTransient<IUpdateFilme, UpdateFilme>();

builder.Services.AddCors();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}
app.UseCors(opt=> opt
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
