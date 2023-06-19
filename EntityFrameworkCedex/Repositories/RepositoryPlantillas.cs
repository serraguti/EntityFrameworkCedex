using EntityFrameworkCedex.Data;
using EntityFrameworkCedex.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCedex.Repositories
{
    public class RepositoryPlantillas
    {
        //ESTA CLASE NECESITA EL CONTEXT PARA PODER REALIZAR LAS CONSULTAS
        private PlantillaContext context;

        public RepositoryPlantillas(PlantillaContext context)
        {
            this.context = context;
        }

        //EL ACCESO A LA BASE DE DATOS SE PUEDE REALIZAR CON CONSULTAS
        //LINQ (MAS LARGAS) O CONSULTAS LAMBDA
        //LOS METODOS SON ASINCRONOS AL ACCEDER A LA BASE DE DATOS
        public async Task<List<Plantilla>> GetPlantillasAsync()
        {
            //EJEMPLO CON LINQ
            //var consulta = from datos in this.context.Plantillas
            //               select datos;
            //return await consulta.ToListAsync();
            //EJEMPLO CON LAMBDA
            return  await this.context.Plantillas.ToListAsync();
        }
    }
}
