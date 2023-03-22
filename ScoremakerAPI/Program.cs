using Microsoft.AspNetCore.Diagnostics.HealthChecks;

using ScoreMaker.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHealthChecks();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddHealthChecks()
    .AddCheck<HealthCheck>("HealthCheck");

var app = builder.Build();

app.MapHealthChecks("/healthcheck");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

/*app.UseAuthorization();*/

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

/*app.UseHealthChecks("/health", new HealthCheckOptions()
{
    ResponseWriter = HealthCheckResponseWriter.WriteResponse
});*/

/*app.MapControllers();*/

app.Run();

