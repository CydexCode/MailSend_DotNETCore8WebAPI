using Microsoft.Extensions.Logging;
using MailSend_DotNETCore8WebAPI.Interfaces;
using MailSend_DotNETCore8WebAPI.Models;
using MailSend_DotNETCore8WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<MailSendSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IMailSendService, MailSendService>();
builder.Services.AddLogging();

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
