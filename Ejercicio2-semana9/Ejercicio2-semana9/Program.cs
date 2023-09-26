//ejercicio2-melvin perez ramirez
{
    double euler = Math.E;
    double eulerRedondeado = Math.Round(euler, 10);

    Console.WriteLine("Número de Euler (Math.E): " + eulerRedondeado);

    double resultado1 = euler + 6.678;
    double resultado2 = euler * 10;
    

    resultado1 = Math.Round(resultado1, 10);
    resultado2 = Math.Round(resultado2, 10);
  

    Console.WriteLine($"Math.E + 5.678 = {resultado1}");
    Console.WriteLine($"Math.E * 10 = {resultado2}");
    
}