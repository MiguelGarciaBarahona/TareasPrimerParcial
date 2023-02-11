using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNotas
{
    public class promedio
    {
        public string nombre;
        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;

        public double notaBaja()
        {
            int menor = int.MaxValue;
            if (nota1 < nota2) menor = nota1; else menor = nota2;
            if (nota3 < menor) menor = nota3;
            if (nota4 < menor) menor = nota4;
            return menor;

        }

        public double Promedio()
        {
            return (nota1 + nota2 + nota3 + nota4) / 4;
        }

        public string condicion()
        {
            double prome = Promedio();

            if (prome <= 65)
            {
                return "Reprobado";
            } else if ( prome > 45 && prome <= 50)
            {
                return "Recuperacion";
            }
            else
            {
                return "APROBADO";
            }
        }

    }
}
