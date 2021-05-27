using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBBDD.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [PrimaryKey]
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
    }
}
