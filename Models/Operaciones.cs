using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Operaciones
    {
        [Required(ErrorMessage = "La descripción no puede estar vacía.")]
        public int primerNumero;

        [Required(ErrorMessage = "La descripción no puede estar vacía.")]
        public int segundoNumero;
        public decimal resultado;

        public Operaciones()
        {
            primerNumero = 0;
            segundoNumero = 0;
            resultado = 0;
        }
    }
}
