using EntityFrameworkCedex.Data;
using EntityFrameworkCedex.Models;
using EntityFrameworkCedex.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Fundamentos Entity Framework");
string connectionString = 
    "Data Source=sqleoipaco.database.windows.net;Initial Catalog=EOIAZURE;Persist Security Info=True;User ID=adminsql;Password=Admin123";
var provider = new ServiceCollection()
    .AddTransient<RepositoryPlantillas>()
    .AddDbContext<PlantillaContext>(options => options.UseSqlServer(connectionString))
    .BuildServiceProvider();

//RECUPERAMOS EL REPOSITORY DE LOS SERVICIOS
RepositoryPlantillas repo = provider.GetService<RepositoryPlantillas>();
List<Plantilla> datos = await repo.GetPlantillasAsync();
foreach (Plantilla plan in datos)
{
    Console.WriteLine(plan.IdEmpleado + " - " + plan.Apellido);
}
Console.WriteLine("Fin de Program");
