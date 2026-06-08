using System.ComponentModel;

Console.WriteLine("Calculo del Descuento de las Compras");
Console.WriteLine("------------------------------------");

Console.Write("Ingrese el monto de las compras:");
double compra = double.Parse(Console.ReadLine());

double desc, tpago;

if (compra >= 100)
{
    desc = compra * 0.15;
    Console.WriteLine("tiene un descuento de 15%");
    tpago = compra - desc;
    Console.WriteLine($"El total a pagar es: {tpago:F2}");
}
else
{
     desc = 0;
    Console.WriteLine(" No cuenta con descuento");
    tpago = compra - desc;
    Console.WriteLine($"El total a pagar es: {tpago:F2}");
}


