using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Coloca tus nombres: ");
        string nombres = Console.ReadLine();

        Console.WriteLine("Colocas tus apellidos: ");
        string apellidos = Console.ReadLine();

        Console.WriteLine("\nResultados para nombres:");
        MostrarResultados(nombres);

        Console.WriteLine("\nResultados para apellidos:");
        MostrarResultados(apellidos);

        Console.WriteLine("\nPrograma de fechas:");
        Console.WriteLine("Coloca la primera fecha (YYYY-MM-DD): ");
        DateTime fecha1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Coloca la segunda fecha (YYYY-MM-DD): ");
        DateTime fecha2 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("\nResultados para fechas:");
        MostrarResultadosFechas(fecha1, fecha2);
    }

    static void MostrarResultados(string texto)
    {
        Console.WriteLine($"Longitud: {texto.Length}");
        Console.WriteLine($"En mayúscula: {texto.ToUpper()}");
        Console.WriteLine($"Primer carácter: {texto[0]}");
        Console.WriteLine($"Último carácter: {texto[texto.Length - 1]}");

        string textoConUnderscore = texto.Replace(' ', '_');
        Console.WriteLine($"Con espacios remplazados por underscore: {textoConUnderscore}");
        Console.WriteLine();
    }

    static void MostrarResultadosFechas(DateTime fecha1, DateTime fecha2)
    {
        Console.WriteLine($"Días transcurridos en el año para la primera fecha: {fecha1.DayOfYear}");
        Console.WriteLine($"Días transcurridos en el año para la segunda fecha: {fecha2.DayOfYear}");
        Console.WriteLine($"Diferencia de días entre ambas fechas: {(fecha2 - fecha1).Days}");
        Console.WriteLine($"Día de la semana de la segunda fecha: {fecha2.DayOfWeek}");
        Console.WriteLine($"Suma de días de la primera fecha en la segunda: {fecha2.AddDays(fecha1.Day).ToShortDateString()}");
        Console.WriteLine($"Suma de años de la segunda fecha en la primera: {fecha1.AddYears(fecha2.Year).ToShortDateString()}");
    }
}
