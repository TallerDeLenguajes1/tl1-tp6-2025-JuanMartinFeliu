// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

/*

Console.WriteLine("Ingrese el valor del numero a invertir:");
int x = Convert.ToInt32(Console.ReadLine());
int resultado = 0;
while (x > 0)
{
    resultado = resultado * 10 + x % 10;
    x = x / 10;
}
Console.WriteLine("El numero invertido es:" + resultado);

*/

/*

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

*/

/*
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
*/

/*
Console.Write("Ingrese una cadena de texto: ");
        string cadena1 = Console.ReadLine();

        // Longitud de la cadena
        Console.WriteLine("Longitud de la cadena: " + cadena1.Length);

        // Concatenar con una segunda cadena
        Console.Write("Ingrese una segunda cadena: ");
        string cadena2 = Console.ReadLine();
        string concatenada = cadena1 + " " + cadena2;
        Console.WriteLine("Cadenas concatenadas: " + concatenada);

        // Extraer una subcadena
        Console.Write("Ingrese la posición inicial de la subcadena: ");
        int inicio = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la longitud de la subcadena: ");
        int longitud = int.Parse(Console.ReadLine());
        string subcadena = cadena1.Substring(inicio, longitud);
        Console.WriteLine("Subcadena: " + subcadena);

        // Calculadora simple
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        double suma = num1 + num2;
        Console.WriteLine("La suma de " + num1.ToString() + " y " + num2.ToString() + " es igual a: " + suma.ToString());

        // Recorrer la cadena con foreach
        Console.WriteLine("Caracteres en la cadena:");
        foreach (char c in cadena1)
        {
            Console.WriteLine(c);
        }

        // Buscar una palabra en la cadena
        Console.Write("Ingrese una palabra a buscar: ");
        string palabra = Console.ReadLine();
        if (cadena1.Contains(palabra))
        {
            Console.WriteLine("La palabra '" + palabra + "' fue encontrada.");
        }
        else
        {
            Console.WriteLine("La palabra '" + palabra + "' no fue encontrada.");
        }

        // Mayúsculas y minúsculas
        Console.WriteLine("En mayúsculas: " + cadena1.ToUpper());
        Console.WriteLine("En minúsculas: " + cadena1.ToLower());

        // Separar una cadena con delimitador
        Console.Write("Ingrese una cadena separada por guiones (-): ");
        string cadenaSeparada = Console.ReadLine();
        string[] partes = cadenaSeparada.Split('-');
        Console.WriteLine("Partes separadas:");
        foreach (string parte in partes)
        {
            Console.WriteLine(parte);
        }

        // Resolver una ecuación simple como "582+2"
        Console.Write("Ingrese una ecuación simple (ej: 582+2): ");
        string ecuacion = Console.ReadLine();
        if (ecuacion.Contains("+"))
        {
            string[] numeros = ecuacion.Split('+');
            double n1 = double.Parse(numeros[0]);
            double n2 = double.Parse(numeros[1]);
            Console.WriteLine($"Resultado: {n1 + n2}");
        }
        else if (ecuacion.Contains("-"))
        {
            string[] numeros = ecuacion.Split('-');
            double n1 = double.Parse(numeros[0]);
            double n2 = double.Parse(numeros[1]);
            Console.WriteLine($"Resultado: {n1 - n2}");
        }
        else if (ecuacion.Contains("*"))
        {
            string[] numeros = ecuacion.Split('*');
            double n1 = double.Parse(numeros[0]);
            double n2 = double.Parse(numeros[1]);
            Console.WriteLine($"Resultado: {n1 * n2}");
        }
        else if (ecuacion.Contains("/"))
        {
            string[] numeros = ecuacion.Split('/');
            double n1 = double.Parse(numeros[0]);
            double n2 = double.Parse(numeros[1]);
            if (n2 != 0)
            {
                Console.WriteLine($"Resultado: {n1 / n2}");
            }
            else
            {
                Console.WriteLine("Error: división por cero.");
            }
        }
        else
        {
            Console.WriteLine("Operación no reconocida.");
        }
*/