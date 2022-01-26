using aperture_case.Config;
using aperture_case.Datalayer;
using aperture_case.Services;
using aperture_case.Util;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var adminKey = NullUtil.GetValueOrDefault(Environment.GetEnvironmentVariable("ADMIN_KEY"),""); 
var testKey = NullUtil.GetValueOrDefault(Environment.GetEnvironmentVariable("TEST_KEY"),""); 
var config = new Config(adminKey, testKey);
var storageClient = new StorageClient();  
var serviceFac = new ServiceFactory(config, storageClient); 
var acService = serviceFac.GetActivationCodeService(); 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IActivationCodeService>(acService);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
