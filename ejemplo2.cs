Console.WriteLine(" Escoger dia de la semana");
Console.WriteLine("------------------------------------");

Console.WriteLine("Ingrese un numero y te dara el dia de la semana");
Console.WriteLine("N:1= Lunes, N:2= Martes, N:3= Miercoles, N:4= Jueves");
Console.WriteLine("N:5= Viernes, N:6= Sabado, N:7= Domingo");

Console.Write("Ingrese ingrese un numero:");
double n = double.Parse(Console.ReadLine());



switch (n)
{
    case 1:
        Console.WriteLine("El Dia es Lunes");
        break;
    case 2:
        Console.WriteLine("El Dia es Martes");
        break;
    case 3:
        Console.WriteLine("El Dia es Miercoles");
        break;
    case 4:
        Console.WriteLine("El Dia esJueves");
        break;
    case 5:
        Console.WriteLine("El Dia es Viernes");
        break;
    case 6:
        Console.WriteLine("El Dia es Sabado");

        break;
    case 7:
        Console.WriteLine("El Dia es Domingo");

        break;
    default:
        Console.WriteLine("Escibe otro numero solo es del 1-7");
        break;

}
