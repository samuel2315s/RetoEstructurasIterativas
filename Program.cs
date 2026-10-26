
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Array de calificaciones del grupo
        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        // Calcular la suma y el promedio
        int suma = 0;

        foreach (int calificacion in calificaciones)
        {
            suma += calificacion;
        }

        double promedio = (double)suma / calificaciones.Length;

        // ==========================================
        // SECCION 1: FOR Y FOREACH
        // ==========================================

        Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

        for (int i = calificaciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");
        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio.ToString("0.0", CultureInfo.InvariantCulture)}");

        Console.WriteLine("\n=== POSICIONES PARES ===");

        for (int i = 0; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine($"Posición par: {calificaciones[i]}");
        }

        // ==========================================
        // SECCION 2: WHILE Y DO-WHILE
        // ==========================================

        Console.WriteLine("\n=== CONTROL DE ACCESO ===");

        int intentos = 0;
        string clave = "sena2026";
        string claveIngresada = "";

        while (claveIngresada != clave && intentos < 3)
        {
            Console.Write("Ingresa la clave: ");
            claveIngresada = Console.ReadLine() ?? "";
            intentos++;

            if (claveIngresada != clave)
            {
                Console.WriteLine(
                    $"Clave incorrecta. Intentos restantes: {3 - intentos}");
            }
        }

        if (claveIngresada == clave)
        {
            Console.WriteLine("Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Acceso bloqueado.");
        }

        // Menu interactivo con do-while
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            string entrada = Console.ReadLine() ?? "";

            if (!int.TryParse(entrada, out opcion))
            {
                opcion = 0;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine(
                        $"Promedio del grupo: {promedio.ToString("0.0", CultureInfo.InvariantCulture)}");
                    break;

                case 2:
                    int mayor = calificaciones[0];

                    foreach (int calificacion in calificaciones)
                    {
                        if (calificacion > mayor)
                        {
                            mayor = calificacion;
                        }
                    }

                    Console.WriteLine($"Calificación más alta: {mayor}");
                    break;

                case 3:
                    Console.WriteLine("Hasta luego.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

        } while (opcion != 3);

        // ==========================================
        // SECCION 3: BREAK Y CONTINUE
        // ==========================================

        Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 60)
            {
                Console.WriteLine(
                    $"Encontrada en posición {i + 1}: {calificaciones[i]}");
                break;
            }
        }

        Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");

        int aprobados = 0;

        foreach (int calificacion in calificaciones)
        {
            if (calificacion < 60)
            {
                continue;
            }

            Console.WriteLine($"Aprobado: {calificacion}");
            aprobados++;
        }

        Console.WriteLine($"Total aprobados: {aprobados}");

        Console.WriteLine("\n=== FILTRO COMBINADO ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] >= 95)
            {
                Console.WriteLine(
                    $"Búsqueda detenida al encontrar: {calificaciones[i]}");
                break;
            }

            if (calificaciones[i] < 70)
            {
                continue;
            }

            Console.WriteLine(
                $"Calificación procesada: {calificaciones[i]}");
        }
    }
}
