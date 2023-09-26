Console.WriteLine("Calculadora de raíces de ecuaciones cuadráticas");
Console.Write("Ingrese el valor de a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de c: ");
double c = Convert.ToDouble(Console.ReadLine());


double discriminante = (b * b) - (4 * a * c);

if (discriminante > 0)
{
    double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
    double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
    Console.WriteLine($"Las raíces son {raiz1} y {raiz2}");
}
else if (discriminante == 0)
{
    double raiz = -b / (2 * a);
    Console.WriteLine($"La raíz doble es {raiz}");
}
else
{
    Console.WriteLine("Las raíces no se pueden calcular");
}

Console.ReadLine();