using System;
using System.Collections.Generic;
public class Ejercicio1
    {
    //Creación de las listas para cada elemento de cada producto
    static List<int> codigo = new List<int>();
    static List<string> nombre = new List<string>();
    static List<int> cantidad = new List<int>();
    static List<double> precio = new List<double>();
    public static void Main(string[] args)
        {
        //Creación del switch para las opciones de gestión de inventario
        int op;
        do
        {
            Console.WriteLine("\n--- GESTIÓN DE INVENTARIO ---");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Eliminar Producto");
            Console.WriteLine("3. Modificar Producto");
            Console.WriteLine("4. Consultar Producto");
            Console.WriteLine("5. Mostrar Todos los Productos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: AgregarProducto(); break;
                case 2: EliminarProducto(); break;
                case 3: ModificarProducto(); break;
                case 4: ConsultarProducto(); break;
                case 5: MostrarProductos(); break;
                case 6: Console.WriteLine("¡Adiós!"); break;
                default: Console.WriteLine("Opción no válida. Intente de nuevo."); break;
            }

        }
        while (op!=6);
    }
    public static void AgregarProducto()
    {
        //Función para el agregado de producto
        Console.Write("\nIngrese el código del nuevo producto: ");
        int nuevoCodigo = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del nuevo producto: ");
        string nuevoNombre = Console.ReadLine();
        Console.Write("Ingrese la cantidad del nuevo producto: ");
        int nuevaCantidad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio del nuevo producto: ");
        double nuevoPrecio = double.Parse(Console.ReadLine());

        //Se añaden los elementos introducidos anteriormente a las listas
        codigo.Add(nuevoCodigo);
        nombre.Add(nuevoNombre);
        cantidad.Add(nuevaCantidad);
        precio.Add(nuevoPrecio);

        Console.WriteLine("\nProducto agregado exitosamente.");
    }
    public static void EliminarProducto()
    {
        //Función para eliminar un producto
        Console.Write("\nIngrese el código del producto a eliminar: ");
        int eliminarCodigo = int.Parse(Console.ReadLine());

        //Se usa un IndexOf para encontrar el índice del producto a través del código
        int comprobacion = codigo.IndexOf(eliminarCodigo);

        //Bifurcación para comprobar la existencia del producto
        if (comprobacion != -1)
        {
            //Se elimina el producto solicitado
            codigo.RemoveAt(comprobacion);
            nombre.RemoveAt(comprobacion);
            cantidad.RemoveAt(comprobacion);
            precio.RemoveAt(comprobacion);

            Console.WriteLine("Producto eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("\nProducto no encontrado.");
        }
    }
    public static void ModificarProducto()
    {
        //Función para modificar un producto
        Console.Write("\nIngrese el código del producto a modificar: ");
        int modificarCodigo = int.Parse(Console.ReadLine());

        //Se usa un IndexOf para encontrar el índice del producto a través del código
        int comprobacion = codigo.IndexOf(modificarCodigo);

        //Bifurcación para comprobar la existencia del producto
        if (comprobacion != -1)
        {
            //Se digitan la nueva información para el producto a modificar
            Console.Write("Ingrese el nuevo nombre del producto: ");
            string modificarNombre = Console.ReadLine();
            Console.Write("Ingrese la nueva cantidad del producto: ");
            int modificarCantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nuevo precio del producto: ");
            double modificarPrecio = double.Parse(Console.ReadLine());

            //Se modifica el producto solicitado
            nombre[comprobacion] = modificarNombre;
            cantidad[comprobacion] = modificarCantidad;
            precio[comprobacion] = modificarPrecio;

            Console.WriteLine("Producto modificado exitosamente.");
        }
        else
        {
            Console.WriteLine("\nProducto no encontrado.");
        }
    }
    public static void ConsultarProducto()
    {
        //Función para consultar un producto
        Console.Write("\nIngrese el código del producto a consultar: ");
        int consultarCodigo = int.Parse(Console.ReadLine());

        //Se usa un IndexOf para encontrar el índice del producto a través del código
        int comprobacion = codigo.IndexOf(consultarCodigo);

        //Bifurcación para comprobar la existencia del producto
        if (comprobacion != -1)
        {
            //Se escribe la información del producto consultado
            Console.WriteLine($"Código: {codigo[comprobacion]}");
            Console.WriteLine($"Nombre: {nombre[comprobacion]}");
            Console.WriteLine($"Cantidad: {cantidad[comprobacion]}");
            Console.WriteLine($"Precio: {precio[comprobacion]}");
        }
        else
        {
            Console.WriteLine("\nProducto no encontrado.");
        }
    }
    public static void MostrarProductos()
    {
        //Función para mostrar todos los productos

        //Bifurcación para comprobar si existe el inventario
        if (codigo.Count == 0)
        {
            Console.WriteLine("\nEl inventario está vacío.");
        }
        else
        {
            //Se usa un for para digitar toda la información de los productos
            Console.WriteLine("\n--- LISTA DE PRODUCTOS ---");
            for (int i = 0; i < codigo.Count; i++)
            {
                Console.WriteLine($"\nPRODUCTO #{i+1}");
                Console.WriteLine($"Código: {codigo[i]}");
                Console.WriteLine($"Nombre: {nombre[i]}");
                Console.WriteLine($"Cantidad: {cantidad[i]}");
                Console.WriteLine($"Precio: {precio[i]}");
            }
        }
    }
}