using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCedex.Models
{
    [Table("PLANTILLA")]
    public class Plantilla
    {
        //LAS CLAVES SON OPCIONALES, ESO SI, 
        //SI NO INCLUIMOS UNA KEY, EN LAS CONSULTAS DE ACCION
        //NOS DARA ERROR
        //SI NOS EQUIVOCAMOS DE KEY, LOS DATOS VAN A CORROMPERSE
        //AL RECUPERARLOS
        [Key]
        [Column("EMPLEADO_NO")]
        public int IdEmpleado { get; set; }
        [Column("APELLIDO")]
        public string Apellido { get; set; }
        [Column("FUNCION")]
        public string Funcion { get; set; }
        [Column("T")]
        public string Turno { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
    }
}
