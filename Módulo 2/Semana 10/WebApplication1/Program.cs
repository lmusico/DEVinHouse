using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using WebApplication1;
using WebApplication1.Context;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApiVersioning(o =>
{
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    o.ReportApiVersions = true;
    o.ApiVersionReader = ApiVersionReader.Combine(
       new QueryStringApiVersionReader("api-version"),
        new HeaderApiVersionReader("X-Version"),
        new MediaTypeApiVersionReader("ver")
        );
});


builder.Services.AddVersionedApiExplorer(
    options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });

builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

builder.Services.AddDbContext<FilmesContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services.AddControllers().AddNewtonsoftJson(
    x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    var descriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
    app.UseSwaggerUI(
        options =>
        {
            foreach (var description in descriptionProvider.ApiVersionDescriptions)
            {
                string isDeprecated = description.IsDeprecated ? " (Depreciada)" : string.Empty;

                options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                        $"{description.GroupName.ToUpperInvariant()}{isDeprecated}");

            }
        }
    );

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


