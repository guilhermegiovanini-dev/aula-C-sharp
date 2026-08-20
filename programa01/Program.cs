using programa01;

Console.WriteLine("**** SISTEMA DA LOJA DE BIKE ****");
Console.WriteLine();

//INSTANCIANDO O OBJETO DA CLASSE
Bike bike = new Bike();

Console.WriteLine("Modelo Bike");
bike.Modelo = Console.ReadLine();

Console.WriteLine("Capacidade da bateria");
bike.Bateria = double.Parse(Console.ReadLine());

Console.WriteLine("Peso do ciclista: ");
bike.PesoCiclista = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de recargas por mês: ");
bike.RecargaMes = int.Parse(Console.ReadLine());

//Exibir resultado na Tela

Console.WriteLine("\n--Relatório de desempenho da Bike--");
Console.WriteLine($"Bicicleta: {bike.Modelo.ToUpper()}");
Console.WriteLine($"Autonomia Estimada: {bike.CalcularAutonomia():F1} por carga");
Console.WriteLine($"Consumo Mensal: {bike.CalcularConsumoMensal():F2} KWm");
Console.WriteLine($"A bike é Economica: {bike.BikeEconomica()}");