using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio6
{
    class Vehiculos
    {
        string placa;
        string marca;
        int modelo;
        string color;
        int precioPerkm;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public int PrecioPerkm { get => precioPerkm; set => precioPerkm = value; }
    }
}
