using System;
using System.Collections.Generic;
public class Ejercicio2
{
    static List<double> saldo = new List<double> {0};
    public static void Main(string[] args)
    {
        //Se hace uso de switch para que el usuario pueda decidir la acción a tomar a cabo
        int op;
        do
        {
            Console.WriteLine("PUEDE REALIZAR LAS SIGUIENTES ACCIONES:");
            Console.WriteLine("(1) Consultar Saldo");
            Console.WriteLine("(2) Depositar Dinero");
            Console.WriteLine("(3) Retirar Dinero");
            Console.WriteLine("(4) Salir");
            Console.Write("Seleccione la opción deseada: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: ConsultarSaldo(); break;
                case 2: DepositarDinero(); break;
                case 3: RetirarDinero(); break;
                case 4: Console.WriteLine("\n¡Adiós!"); break;
                default: Console.WriteLine("\nOpción inválida, vuelva a intentarlo.\n"); break;
            }
        }
        while (op != 4);
    }
    public static void ConsultarSaldo()
    {
        //Función para consultar el saldo
        Console.WriteLine($"\nSaldo Actual: {saldo[0]}\n");
    }
    public static void DepositarDinero()
    {
        //Función para depositar dinero
        Console.Write("\nDigite el monto a depositar: ");
        float deposito = float.Parse(Console.ReadLine());

        //Bifurcación para saber si se puede depositar el dinero solicitado
        if (deposito < 0)
        {
            Console.WriteLine("\nNo se permiten valores negativos.\n");
        }
        else
        {
            saldo[0] += deposito;

            //Se digita el monto depositado y el saldo actual luego del depósito
            Console.WriteLine($"\nMonto Depositado: {deposito}");
            Console.WriteLine($"Saldo Actual: {saldo[0]}\n");
        }
    }
    public static void RetirarDinero()
    {
        //Función para retirar dinero
        Console.Write("\nDigite el monto a retirar: ");
        float retiro = float.Parse(Console.ReadLine());

        //Bifurcación para saber si se puede retirar el dinero solicitado
        if (retiro > 0)
        {
            //Bifurcación para saber si se puede retirar el dinero solicitado
            if (retiro <= saldo[0])
            {
                //Se digita el monto retirado y el saldo actual luego del retiro
                saldo[0] -= retiro;
                Console.WriteLine($"\nMonto Retirado: {retiro}");
                Console.WriteLine($"Saldo Actual: {saldo[0]}\n");
            }
            else
            {
                Console.WriteLine("\nNo se puede retirar más de lo que actualmente posee.\n");
            }
        }
        else
        {
            Console.WriteLine("\nLa cantidad debe ser mayor que 0.\n");
        }
    }
}