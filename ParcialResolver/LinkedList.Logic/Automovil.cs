using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Logic
{
    public class Automovil
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Año { get; set; }

        public string Color { get; set; }

        public decimal Precio { get; set; }

        public Automovil(string marca, string modelo, int año, string color, decimal precio)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
            Precio = precio;
        }

        public override string ToString()
        {
            var output = string.Empty;

            output += $"Marca: {Marca}\n" +
                      $"Modelo: {Modelo}\n" +
                      $"Año: {Año}\n" +
                      $"Color: {Color}\n" +
                      $"Precio: {Precio:C2} \n \n";

            return output;
        }

    }
}
