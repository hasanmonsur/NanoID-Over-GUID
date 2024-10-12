using UniqueIdGenerator.Contacts;
using UniqueIdGenerator.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// add DI service
builder.Services.AddSingleton<IGuIdService, GuIdService>();
builder.Services.AddSingleton<IXIdService, XIdService>();
builder.Services.AddSingleton<INanoIDService, NanoIDService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// Middleware and endpoint configuration
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();

