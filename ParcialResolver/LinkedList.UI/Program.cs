using LinkedLists.Logic;
var listaAutomoviles = new AutomovilList();

// Marcas: Toyota, Nissan, Honda, Chevrolet
// Modelos: Camry, Altima, Accord, Malibu
// Años: 2010, 2015, 2020, 2022
// Colores: Rojo, Azul, Negro, Blanco
// Precios: entre 0 y 60 millones, entre 60 y 120 millones, entre 120 y 240 millones

listaAutomoviles.Add(new Automovil("Toyota", "Camry", 2010, "Rojo", 40_000_000));
listaAutomoviles.Add(new Automovil("Nissan", "Altima", 2015, "Azul", 70_000_000));
listaAutomoviles.Add(new Automovil("Honda", "Accord", 2020, "Negro", 160_000_000));
listaAutomoviles.Add(new Automovil("Chevrolet", "Malibu", 2022, "Blanco", 200_000_000));
listaAutomoviles.Add(new Automovil("Toyota", "Camry", 2015, "Blanco", 55_000_000));
listaAutomoviles.Add(new Automovil("Nissan", "Altima", 2022, "Rojo", 90_000_000));
listaAutomoviles.Add(new Automovil("Honda", "Accord", 2010, "Azul", 20_000_000));
listaAutomoviles.Add(new Automovil("Chevrolet", "Malibu", 2020, "Negro", 140_000_000));
listaAutomoviles.Add(new Automovil("Toyota", "Camry", 2020, "Negro", 150_000_000));
listaAutomoviles.Add(new Automovil("Nissan", "Altima", 2015, "Blanco", 65_000_000));
listaAutomoviles.Add(new Automovil("Honda", "Accord", 2022, "Rojo", 190_000_000));
listaAutomoviles.Add(new Automovil("Chevrolet", "Malibu", 2010, "Azul", 30_000_000));


Console.WriteLine("*** Linked Lists ***");


    Console.WriteLine("Lista de vehículos: \n");
    Console.WriteLine(listaAutomoviles);

Console.WriteLine("-----------------------------------------------------");

var toyotaCars = listaAutomoviles.GetBrand("Toyota");
    Console.WriteLine("Vehículos de la marca Toyota: \n");
    Console.WriteLine(toyotaCars);

Console.WriteLine("-----------------------------------------------------");

var cars2018to2021 = listaAutomoviles.GetCarsByYear(2018, 2021);
    Console.WriteLine("Vehículos de entre los años 2018 y 2021: \n");
    Console.WriteLine(cars2018to2021);

Console.WriteLine("-----------------------------------------------------");

var cheapCars = listaAutomoviles.GetPrice(0, 30000000);
    Console.WriteLine("Vehículos de precio menor o igual a 30.000.000: \n");
    Console.WriteLine(cheapCars);

Console.WriteLine("-----------------------------------------------------");

var filters = listaAutomoviles.GetSeveralFilters("Toyota", "*", "Negro", 2015, 40000000);
    Console.WriteLine("Vehículos de la marca Toyota, color negro, año mayor o igual a 2015 y precio menor o igual a 40.000.000: \n");
    Console.WriteLine(filters);

Console.WriteLine("-----------------------------------------------------");

var minMax = listaAutomoviles.GetMinMax(listaAutomoviles);
    Console.WriteLine($"Vehículo con menor precio: {minMax[0]}");
    Console.WriteLine($"Vehículo con mayor precio: {minMax[1]}");

    Console.ReadLine();

    



    //// Crear lista de automóviles
    //var automoviles = new AutomovilList();

    //// Adicionar 12 vehículos
    //automoviles.Add(new Automovil("Toyota", "Corolla", 2018, "Rojo", 45000000));
    //automoviles.Add(new Automovil("Mazda", "3", 2021, "Blanco", 90000000));
    //automoviles.Add(new Automovil("Chevrolet", "Spark", 2019, "Azul", 30000000));
    //automoviles.Add(new Automovil("Ford", "F-150", 2017, "Negro", 120000000));
    //automoviles.Add(new Automovil("Toyota", "Yaris", 2020, "Gris", 60000000));
    //automoviles.Add(new Automovil("Mazda", "CX-5", 2016, "Blanco", 80000000));
    //automoviles.Add(new Automovil("Chevrolet", "Sail", 2018, "Negro", 40000000));
    //automoviles.Add(new Automovil("Ford", "Mustang", 2022, "Rojo", 200000000));
    //automoviles.Add(new Automovil("Hyundai", "Tucson", 2021, "Plata", 110000000));
    //automoviles.Add(new Automovil("Kia", "Sportage", 2019, "Azul", 85000000));
    //automoviles.Add(new Automovil("Nissan", "Versa", 2017, "Rojo", 45000000));
    //automoviles.Add(new Automovil("BMW", "X5", 2022, "Negro", 280000000));

    //// Ejemplo de uso de los métodos
    //Console.WriteLine("Carros Toyota:");
    //var toyotaCars = automoviles.GetBrand("Toyota");
    //foreach (var car in toyotaCars.ToString())
    //{
    //    Console.WriteLine("hola");
    //}

    //Console.WriteLine("Carros entre 2018 y 2020:");
    //var cars2018to2020 = automoviles.GetCarsByYear(2018, 2020);
    //foreach (var car in cars2018to2020.ToString())
    //{
    //    Console.WriteLine(car);
    //}

    //Console.WriteLine("Carros entre 60 y 120 millones:");
    //var cars60to120 = automoviles.GetPrice(60000000, 120000000);
    //foreach (var car in cars60to120.ToString())
    //{
    //    Console.WriteLine(car);
    //}

    //Console.WriteLine("Carros Ford negros:");
    //var fordBlackCars = automoviles.GetSeveralFilters("Ford", "*", "Negro", 0, 0);
    //foreach (var car in fordBlackCars.ToString())
    //{
    //    Console.WriteLine(car);
    //}

    //Console.WriteLine("Carro con menor y mayor precio:");
    //var minMax = automoviles.GetMinMax(automoviles);
    //Console.WriteLine($"Carro con menor precio: {minMax[0]}");
    //Console.WriteLine($"Carro con mayor precio: {minMax[1]}");
//}


