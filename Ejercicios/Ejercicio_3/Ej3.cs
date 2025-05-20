int seguir = 1;
while (seguir > 0)
{
    Console.WriteLine("-----CALCULADORA-----");
    Console.WriteLine("5-Valor absoluto");
    Console.WriteLine("6-Cuadrado");
    Console.WriteLine("7-Raiz Cuadrada");
    Console.WriteLine("8-Seno (en grados)");
    Console.WriteLine("9-Coseno (en grados)");
    Console.WriteLine("10-Parte entera de un float");
    Console.WriteLine("Ingrese la operacion que quiere hacer:");
    int decidir = Convert.ToInt32(Console.ReadLine());

    int x;
    double resultado;
    float h;

    switch (decidir)
    {
        case 5:
            Console.WriteLine("Ingrese el numero:");
            x = Convert.ToInt32(Console.ReadLine());
            resultado = Math.Abs(x);
            Console.WriteLine("El resultado es: " + resultado);
            break;

        case 6:
            Console.WriteLine("Ingrese el numero:");
            x = Convert.ToInt32(Console.ReadLine());
            resultado = x * x;
            Console.WriteLine("El resultado es: " + resultado);
            break;

        case 7:
            Console.WriteLine("Ingrese el numero:");
            x = Convert.ToInt32(Console.ReadLine());
            resultado = Math.Sqrt(x);
            Console.WriteLine("El resultado es: " + resultado);
            break;

        case 8:
            Console.WriteLine("Ingrese el angulo en grados:");
            x = Convert.ToInt32(Console.ReadLine());
            resultado = Math.Sin(x * Math.PI / 180); // convertir a radianes
            Console.WriteLine("El resultado es: " + resultado);
            break;

        case 9:
            Console.WriteLine("Ingrese el angulo en grados:");
            x = Convert.ToInt32(Console.ReadLine());
            resultado = Math.Cos(x * Math.PI / 180); // convertir a radianes
            Console.WriteLine("El resultado es: " + resultado);
            break;

        case 10:
            Console.WriteLine("Ingrese el numero:");
            h = float.Parse(Console.ReadLine());
            resultado = (int)h;
            Console.WriteLine("El resultado es: " + resultado);
            break;

        default:
            Console.WriteLine("Opcion no disponible");
            break;
    }

    Console.WriteLine("¿Quiere seguir realizando operaciones?");
    Console.WriteLine("1-Seguir");
    Console.WriteLine("0-Salir");
    seguir = Convert.ToInt32(Console.ReadLine());
}
