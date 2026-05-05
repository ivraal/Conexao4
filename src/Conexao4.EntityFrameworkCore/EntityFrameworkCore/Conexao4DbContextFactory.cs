using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Conexao4.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Conexao4DbContextFactory : IDesignTimeDbContextFactory<Conexao4DbContext>
{
    public Conexao4DbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        Conexao4EfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<Conexao4DbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));
        
        return new Conexao4DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Conexao4.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}
