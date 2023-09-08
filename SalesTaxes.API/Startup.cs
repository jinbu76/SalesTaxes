using Swashbuckle.AspNetCore.SwaggerGen;

namespace SalesTaxes.API;

public class Startup
{
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNameCaseInsensitive = false;
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
            options.JsonSerializerOptions.WriteIndented = true;
        });
        
        // Swagger
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(ConfigureSwagger);
        
        // Service Definition
       

        // Repositories
       

        //DbContext
        

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseCors(cors => cors.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
        app.UseRouting();
        app.UseAuthentication();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
    
    private void ConfigureSwagger(SwaggerGenOptions options)
    {
        options.SwaggerDoc("v1", new()
        {
            Version = "v1",
            Title = "Administration API",
            Description = "APIs for Products",
            Contact = new()
            {
                Name = "Mike Gründer",
                Email = "mike@gruender.dev"
            }
        });
    }
}