using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;
using SimpleLibraryAPI;
using SimpleLibraryAPI.Entidades;

[MemoryDiagnoser]
public class EfBenchmark
{
    [Benchmark]
    public List<Autor> GetAll()
    {
        ApplicationDbContext dbContext = new ApplicationDbContext(
            new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("server=.;database=SimpleLibraryAPI;integrated security=true;Trust Server Certificate=true")
            .Options);

        return dbContext.Autores
            .ToList();
    }
    [Benchmark]
    public List<Autor> GetAllWithAsNoTracking()
    {
        ApplicationDbContext dbContext = new ApplicationDbContext(
            new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("server=.;database=SimpleLibraryAPI;integrated security=true;Trust Server Certificate=true")
            .Options);

        return dbContext.Autores
            .AsNoTracking()
            .ToList();
    }
}
