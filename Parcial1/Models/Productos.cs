using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Parcial1.Models
{
    public class Productos
    {
        [Key]

        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Costo { get; set; }
        public int Inventario { get; set; }

    }
}
