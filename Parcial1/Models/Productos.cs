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

        [Required(ErrorMessage = "El campo descripcion no debe estar vacio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo existencia no debe estar vacio")]
        [Range(1, int.MaxValue, ErrorMessage = "Por favor inserte un valor mayor a 0")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El campo costo no debe estar vacio")]
        [Range(1, int.MaxValue, ErrorMessage = "Por favor inserte un valor mayor a 0")]
        public decimal Costo { get; set; }

        public int Inventario { get; set; }

    }
}
