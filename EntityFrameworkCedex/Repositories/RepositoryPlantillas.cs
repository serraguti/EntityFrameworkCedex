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

        //METODO PARA BUSCAR POR TURNO
        public async Task<List<Plantilla>> GetPlantillaTurnoAsync(string turno)
        {
            //EJEMPLO CON LINQ
            //var consulta = from datos in this.context.Plantillas
            //               where datos.Turno == turno
            //               select datos;
            //return await consulta.ToListAsync();
            return await this.context.Plantillas.Where(x => x.Turno == turno).ToListAsync();
        }

        public async Task CreatePlantilla(int idplantilla, string apellido, string funcion
            , string turno, int salario)
        {
            //NECESITAMOS INSTANCIAR UN NUEVO OBJETO MODEL
            Plantilla plan = new Plantilla();
            //ASIGNAMOS TODAS LAS PROPIEDADES
            plan.IdEmpleado = idplantilla;
            plan.Apellido = apellido;
            plan.Funcion = funcion;
            plan.Turno = turno;
            plan.Salario = salario;
            //SI DESEAMOS COMUNICARNOS CON LA BASE DE DATOS, PRIMERO
            //DEBEMOS AÑADIR EL OBJETO A LA COLECCION Dbset DEL CONTEXT
            this.context.Plantillas.Add(plan);
            //PARA REALIZAR EL INSERT, DEBEMOS GUARDAR LOS CAMBIOS
            await this.context.SaveChangesAsync();
        }
    }
}
