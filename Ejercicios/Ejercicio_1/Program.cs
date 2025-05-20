
Console.WriteLine("Ingrese el valor del numero a invertir:");
int x = Convert.ToInt32(Console.ReadLine());
int resultado = 0;
while (x > 0)
{
    resultado = resultado * 10 + x % 10;
    x = x / 10;
}
Console.WriteLine("El numero invertido es:" + resultado);
