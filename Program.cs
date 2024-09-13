/*using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

public class Program
{
    public static void Main(string[] args)
    {

    }
}*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "CSV/cadetes.csv";
        List<Cadete> loadedCadetes = ManejoCSV.ReadAndDisplayCSV(filePath);
        List<Pedidos> pedidosP = new List<Pedidos>(); 
        List<Pedidos> pedidosA = new List<Pedidos>();
        List<Pedidos> pedidosT = new List<Pedidos>();
        int x =0;
        string opcion;
        while(x!=-1){
        Console.WriteLine(Mensajes.Menu());
        opcion=Console.ReadLine();
        x=int.Parse(opcion);
        switch (x)
        {
            case 1: 
            System.Console.WriteLine("Ingrese un nombre:");
            string nombre = Console.ReadLine();
            System.Console.WriteLine("Ingrese una direccion:");
            string direccion = Console.ReadLine();
            System.Console.WriteLine("Ingrese un numero telefonico:");
            string numero = Console.ReadLine();
            Cliente cliente = new Cliente(nombre,direccion,double.Parse(numero));
            System.Console.WriteLine("Ingrese una Observacion:");
            string observacion = Console.ReadLine();
            Pedidos volar = new Pedidos(1,observacion,cliente,false);
            pedidosP.Add(volar);
            break;

            case 2:
            foreach (Pedidos item in pedidosP)
            {
                Console.Clear();
                System.Console.WriteLine("\nNumero de pedido"+item.Numero+"\nObservacion:"+item.Observaciones+"\nCliente: "+item.Cliente.Nombre);
                System.Console.WriteLine("\n\nDesea asignar ese pedido? y/n");
                string desicion = Console.ReadLine();
                if(desicion=="Y" || desicion =="y"){
                    Console.Clear();
                    System.Console.WriteLine("Cadetes disponibles: ");
                    foreach (Cadete aux in loadedCadetes)
                    {
                        System.Console.WriteLine("\nID: "+aux.Id);
                        System.Console.WriteLine("\nNombre: "+aux.Nombre);
                        System.Console.WriteLine("\n\n--------------------");
                    }
                    System.Console.WriteLine("Seleccione el Id del cadete: ");
                    string aux3 = Console.ReadLine();
                    int aux4 = int.Parse(aux3);
                    loadedCadetes[aux4].Pedidos.Add(item);
                    pedidosA.Add(item);
                    pedidosP.Remove(item);
                    break;
                }
            }
            break;
            case 3:
            foreach (Pedidos item in pedidosA)
            {
                Console.Clear();
                System.Console.WriteLine("\nNumero de pedido"+item.Numero+"\nObservacion:"+item.Observaciones+"\nCliente: "+item.Cliente.Nombre);
                System.Console.WriteLine("\n\nDesea cambiar el estado del pedido? y/n");
                string desicion = Console.ReadLine();
                if(desicion=="Y" || desicion =="y"){
                    item.Estado=true;
                    pedidosT.Add(item);
                    pedidosA.Remove(item);
                }
            }
            break;
            case 4:
                foreach (Cadete aux in loadedCadetes)
                    {
                        System.Console.WriteLine("\nID: "+aux.Id);
                        System.Console.WriteLine("\nNombre: "+aux.Nombre);
                        System.Console.WriteLine("\n\n--------------------");
                    }
                    System.Console.WriteLine("Seleccione el Id del cadete: ");
                    string decicion = Console.ReadLine();
                    int eleccion = int.Parse(decicion);
                    System.Console.WriteLine("Seleccione el Id del cadete al que ira: ");
                    string decicion2 = Console.ReadLine();
                    int eleccion2 = int.Parse(decicion2);
                    foreach (Pedidos item in loadedCadetes[eleccion-1].Pedidos)
                    {
                        System.Console.WriteLine("\nNumero de pedido"+item.Numero+"\nObservacion:"+item.Observaciones+"\nCliente: "+item.Cliente.Nombre);
                        System.Console.WriteLine("\n\nDesea asignar ese pedido? y/n");
                        string aux2 = Console.ReadLine();
                        if(aux2=="Y" || aux2 =="y"){
                        loadedCadetes[eleccion2-1].Pedidos.Add(item);
                        loadedCadetes[eleccion-1].Pedidos.Remove(item);
                        break;
                        }
                    }
            break;
            case 5:
            Console.Clear();
            foreach (Cadete item in loadedCadetes)
            {
                float dinero = item.JornalACobrar();
                Console.WriteLine("Total a cobrar: $"+dinero);
                Console.WriteLine("Total de pedidos: "+dinero/500);
                Console.WriteLine("Total promedio: "+(dinero/500)/item.Pedidos.Count());
            }
            break;
            default:
            break;
        }
        Console.Clear();
        }
    }

}
    // Método para leer el archivo CSV y cargar los datos en una lista de Cadetes
