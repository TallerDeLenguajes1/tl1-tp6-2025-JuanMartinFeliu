int seguir = 1;
while (seguir > 0)
{
    Console.WriteLine("-----CALCULADORA-----");
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("Ingrese la operacion que quiere hacer:");
    int decidir = Convert.ToInt32(Console.ReadLine());
    int x, y, resultado;

    switch (decidir)
    {
        case 1:
            Console.WriteLine("Ingrese el primer numero:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            y = Convert.ToInt32(Console.ReadLine());
            resultado = x + y;
            Console.WriteLine("El resultado es:" + resultado);
            break;
        case 2:
            Console.WriteLine("Ingrese el primer numero:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            y = Convert.ToInt32(Console.ReadLine());
            resultado = x - y;
            Console.WriteLine("El resultado es:" + resultado);
            break;
        case 3:
            Console.WriteLine("Ingrese el primer numero:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            y = Convert.ToInt32(Console.ReadLine());
            resultado = x * y;
            Console.WriteLine("El resultado es:" + resultado);
            break;
        case 4:
            Console.WriteLine("Ingrese el primer numero:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero (Que sea distinto que 0):");
            y = Convert.ToInt32(Console.ReadLine());
            resultado = x / y;
            Console.WriteLine("El resultado es:" + resultado);
            break;
        default:
            Console.WriteLine("Opcion no disponible");
            break;
    }
    Console.WriteLine("¿Quiere seguir realizado operaciones?");
    Console.WriteLine("5-Seguir");
    Console.WriteLine("0-Salir");
    seguir = Convert.ToInt32(Console.ReadLine());
}