using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio6
{
    class Alquiler
    {
        string nit;
        string placa;
        DateTime fechaAlq;
        DateTime fechaDev;
        int kilometros;

        public string Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlq { get => fechaAlq; set => fechaAlq = value; }
        public DateTime FechaDev { get => fechaDev; set => fechaDev = value; }
        public int Kilometros { get => kilometros; set => kilometros = value; }
    }
}
