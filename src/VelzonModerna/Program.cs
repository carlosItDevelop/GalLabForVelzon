using GeneralLabSolutions.Domain.Notigfications;
using GeneralLabSolutions.InfraStructure.Data;
using GeneralLabSolutions.InfraStructure.IoC;
using Microsoft.EntityFrameworkCore;
using VelzonModerna.Configuration.Extensions;
using VelzonModerna.Configuration.Mappings;

public class Program
{
    public static void Main(string [] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddMvcConfiguration();

        // Configurações de Configuration
        var configuration = builder.Configuration;
        configuration.SetBasePath(builder.Environment.ContentRootPath)
            .AddJsonFile("appsettings.json", true, true)
            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
            .AddEnvironmentVariables();

        if (builder.Environment.IsDevelopment())
        {
            configuration.AddUserSecrets<Program>();
        }

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        builder.Services
            .AddServicesAndDepencencyInjections()
            .AddAutoMapper(typeof(AutoMapperConfig));


        builder.Services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
        });


        var app = builder.Build();



        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=GalLabs}/{action=GlDashboard}/{id?}");

        app.Run();

    }
}