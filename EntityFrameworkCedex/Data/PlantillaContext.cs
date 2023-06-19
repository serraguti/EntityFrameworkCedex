using EntityFrameworkCedex.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCedex.Data
{
    public class PlantillaContext: DbContext
    {
        //NECESITAMOS UN CONSTRUCTOR QUE RECIBIRA LAS OPCIONES DE ESTE 
        //CONTEXT
        public PlantillaContext(DbContextOptions<PlantillaContext> options) : base(options) { }
        //CADA TABLA DE LA BASE DE DATOS PARA REALIZAR CONSULTAS DEBE SER UN DbSet
        //CON EL MODEL QUE DESEEMOS
        public DbSet<Plantilla> Plantillas { get; set; }
    }
}
