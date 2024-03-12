using System.Timers;

string dia;

Console.WriteLine("Dame un día: ");
dia = Console.ReadLine();
string mensaje = "Ha ingresado el día ";

switch (dia)
{
        case "lunes": Console.WriteLine(mensaje + dia); break;
        case "martes": Console.WriteLine(mensaje + dia); break;
        case "miercoles": Console.WriteLine(mensaje + dia); break;
        case "jueves": Console.WriteLine(mensaje + dia); break;
        case "viernes": Console.WriteLine(mensaje + dia); break;
        case "sabado": Console.WriteLine(mensaje + dia); break;
        case "domingo": Console.WriteLine(mensaje + dia); break;
        default: Console.WriteLine("El día ingresado no es válido"); break;
}
if (dia == "lunes")
{
    Console.WriteLine("Tienes clases de Matemáticas desde las 08:00 AM a 12:00 M");
}
else if(dia == "martes")
{
    Console.WriteLine("Tienes clases de Inglés desde las 08:00 AM a 12:00 M");
}
else if(dia =="miercoles")
{
    Console.WriteLine("Tienes clases de Literatura desde las 08:00 AM a 12:00 M");
}
else if (dia == "jueves")
{
    Console.WriteLine("Tienes el día libre");
}
else if (dia == "viernes")
{
    Console.WriteLine("Tienes clases de Calculo desde las 08:00 AM a 12:00 M");
}
else if (dia == "msabado")
{
    Console.WriteLine("Tienes cita con el odontólogo a las 15:00");
}
else if (dia == "domingo")
{
    Console.WriteLine("Tienes el día libre");
}