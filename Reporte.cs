using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio6
{
    class Reporte
    {
        string Nombre;
        string Marca;
        int Modelo;
        DateTime FechaDevuelto;
        DateTime FechaDevolucion;
        int TotalPagar;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public int Modelo1 { get => Modelo; set => Modelo = value; }
        public DateTime FechaDevuelto1 { get => FechaDevuelto; set => FechaDevuelto = value; }
        public DateTime FechaDevolucion1 { get => FechaDevolucion; set => FechaDevolucion = value; }
        public int TotalPagar1 { get => TotalPagar; set => TotalPagar = value; }
    }
}
