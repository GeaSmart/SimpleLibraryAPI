using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.EntityFrameworkCore;
using SimpleLibraryAPI;
using SimpleLibraryAPI.Entidades;

[MemoryDiagnoser]
public class EfBenchmark
{
    private ApplicationDbContext dbContext;

    [Benchmark]
    public List<Autor> GetAll()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("server=.;database=SimpleLibraryAPI;integrated security=true;Trust Server Certificate=true")
            .Options;

        dbContext = new ApplicationDbContext(options);
        return dbContext.Autores.ToList();
    }
    [Benchmark]
    public List<Autor> GetAllWithAsNoTracking()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("server=.;database=SimpleLibraryAPI;integrated security=true;Trust Server Certificate=true")
            .Options;

        dbContext = new ApplicationDbContext(options);
        return dbContext.Autores.AsNoTracking().ToList();
    }
}
