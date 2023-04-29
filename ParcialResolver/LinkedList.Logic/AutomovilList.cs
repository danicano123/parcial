using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Logic
{
    public class AutomovilList
    {
        private DoubleNode<Automovil>? _first;

        private DoubleNode<Automovil>? _last;

        public AutomovilList()
        {
            _first = null;
            _last = null;
            Count = 0;

            // Adicionamos 12 vehículos
 
        }

        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $"Marca: {pointer.Data.Marca}\n" +
                          $"Modelo: {pointer.Data.Modelo}\n" +
                          $"Año: {pointer.Data.Año}\n" +
                          $"Color: {pointer.Data.Color}\n" +
                          $"Precio: {pointer.Data.Precio:C2} \n \n" ;
                pointer = pointer.Right;
            }
            return output;
        }

        public string ToInvertedList()
        {
            var output = string.Empty;
            var pointer = _last;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Left;
            }
            return output;
        }

        public void Add(Automovil item)
        {
            var node = new DoubleNode<Automovil>(item);
            if (IsEmpty)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Left = _last;
                _last!.Right = node;
                _last = node;
            }
            Count++;
        }

        public AutomovilList GetBrand(string brand)
        {
            var result = new AutomovilList();
            var current = _first;
            while (current != null)
            {
                if (current.Data.Marca == brand)
                {
                    result.Add(current.Data);
                }
                current = current.Right;
            }
            return result;
        }

        // Retorna los carros de entre el rango de modelos 
        public AutomovilList GetCarsByYear(int lower, int upper)
        {
            var result = new AutomovilList();
            var current = _first;
            while (current != null)
            {
                if (current.Data.Año >= lower && current.Data.Año <= upper)
                {
                    result.Add(current.Data);
                }
                current = current.Right;
            }
            return result;
        }

        // Retorna los carros de entre el rango de precios 
        public AutomovilList GetPrice(decimal lower, decimal upper)
        {
            var result = new AutomovilList();
            var current = _first;
            while (current != null)
            {
                if (current.Data.Precio >= lower && current.Data.Precio <= upper)
                {
                    result.Add(current.Data);
                }
                current = current.Right;
            }
            return result;
        }

        // Retorna los carros dependiendo de los siguientes criterios. 
        // Nota si en los criterios de marca, color y modelo 
        // se envía * significa que son todos 
        public AutomovilList GetSeveralFilters(string brand, string year, string color, int minimumYear, decimal maximumPrice)
        {
            var result = new AutomovilList();
            var current = _first;
            while (current != null)
            {
                if ((brand == "*" || current.Data.Marca == brand) &&
                    (year == "*" || current.Data.Año.ToString() == year) &&
                    (color == "*" || current.Data.Color == color) &&
                    current.Data.Año >= minimumYear &&
                    current.Data.Precio <= maximumPrice)
                {
                    result.Add(current.Data);
                }
                current = current.Right;
            }
            return result;
        }

        // Retorna el carro con menor precio y el carro con mayor 
        // precio en un array
        // En la posición 0 el carro con menor precio
        // En la posición 1 el carro con mayor precio 
        // Dada una lista de carros

        public Automovil[] GetMinMax(AutomovilList list)
        {
            if (list.IsEmpty)
            {
                return new Automovil[2];
            }

            var current = list._first;
            var minPrice = current.Data.Precio;
            var maxPrice = current.Data.Precio;
            var minCar = current.Data;
            var maxCar = current.Data;

            while (current != null)
            {
                if (current.Data.Precio < minPrice)
                {
                    minPrice = current.Data.Precio;
                    minCar = current.Data;
                }

                if (current.Data.Precio > maxPrice)
                {
                    maxPrice = current.Data.Precio;
                    maxCar = current.Data;
                }

                current = current.Right;
            }

            return new Automovil[] { minCar, maxCar };
        }


    }
}
