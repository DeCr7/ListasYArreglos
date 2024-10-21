using System;
using System.Collections.Generic;
    public class Ejercicio3
    {
    //Creación de las listas para almacenar las palabras en español y en inglés
    static List<string> palabrasEspañol = new List<string>();
    static List<string> palabrasIngles = new List<string>();
    public static void Main(string[] args)
        {
        //Se lleva a cabo el proceso de crear el diccionario
        crearDiccionario();

        //Se usa un switch para el usuario pueda traducir todas las veces que necesite
        int op;
        do
        {
            Console.WriteLine("\n(1) Traducir Palabra");
            Console.WriteLine("(2) Salir");
            Console.Write("Digite lo que desea hacer: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: traducir(); break;
                case 2: Console.WriteLine("¡Adiós!"); break;
                default: Console.WriteLine("Opción no válida. Intente de nuevo."); break;
            }
        }
        while (op != 2);
    }

    public static void crearDiccionario()
    {
        //Se introducen los 5 pares de palabras para el diccionario
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Introduce la palabra #{i + 1} en español: ");
            string palabraEspañol = Console.ReadLine();
            Console.Write($"Introduce la palabra #{i + 1} en inglés: ");
            string palabraIngles = Console.ReadLine();

            palabrasEspañol.Add(palabraEspañol);
            palabrasIngles.Add(palabraIngles);
        }
    }
    public static void traducir()
    {
        //Se pasan las listas a arrays ya que el número queda fijo en 5
        string[] arrayEspañol = palabrasEspañol.ToArray();
        string[] arrayIngles = palabrasIngles.ToArray();

        //Creación de un booleano en caso de encontrar o no la palabra
        bool comprobar = false;
        Console.Write("\nDigite la palabra a traducir: ");
        string palabraClave = Console.ReadLine();

        //Se revisa las palabras en español para encontrar la traducción
        for (int i = 0; i < arrayEspañol.Length; i++)
        {
            if (arrayEspañol[i].Equals(palabraClave, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"La traducción de '{palabraClave}' es: {arrayIngles[i]}");
                comprobar = true;
                break;
            }
        }
        //Se revisa las palabras en inglés para encontrar la traducción
        for (int i = 0; i < arrayIngles.Length; i++)
        {
            if (arrayIngles[i].Equals(palabraClave, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"La traducción de '{palabraClave}' es: {arrayEspañol[i]}");
                comprobar = true;
                break;
            }
        }

        //En caso de no encontrar la palabra en el diccionario
        if (!comprobar)
        {
            Console.WriteLine($"{palabraClave} no fue encontrado.");
        }
    }
}