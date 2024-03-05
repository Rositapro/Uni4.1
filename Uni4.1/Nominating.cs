using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni4._1
{
    internal class Nominating
    {
        private int workingdays;
        public int Workingdays { get; set; }

        //metodo para calcular la nomina
        public decimal CalculateNom(int workdays, decimal valorDia)
        {
            decimal totalSalario = workdays * valorDia;
            return totalSalario;
        }
    }
}
