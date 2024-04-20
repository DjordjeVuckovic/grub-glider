using System.Reflection;
using System.Text;
using dotenv.net;
using GrubGlider.BuildingBlocks.Api;
using GrubGlider.BuildingBlocks.Configuration;
using GrubGlider.BuildingBlocks.Endpoints;
using GrubGlider.OfferingService.Extensions;
using GrubGlider.OfferingService.Persistence.Extensions;

DotEnv.Fluent()
    .WithoutExceptions()
    .WithTrimValues()
    .WithEncoding(Encoding.UTF8)
    .WithoutOverwriteExistingVars()
    .Load();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCorsPolicy();
builder.Services.AddRouting();

builder.Services.AddOptions(builder.Configuration);
builder.Services.AddMediator();
builder.Services.AddPersistence(builder.Configuration.IsDevelopment());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
app.UseCors(CorsPolicyExtension.PolicyName);
app.UseRouting();

app.MapEndpoints(Assembly.GetExecutingAssembly());

app.Run();