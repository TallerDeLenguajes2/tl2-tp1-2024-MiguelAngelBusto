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
        // Lista de objetos Cadete
        List<Cadete> cadetes = new List<Cadete>
        {
            new Cadete { Id = 1, Nombre = "Carlos Fernández", Direccion = "asdasdsa", Numero = 123123 },
            new Cadete { Id = 2, Nombre = "Pablo Albetus", Direccion = "asdasdsa", Numero = 123123 },
            new Cadete {  Id = 1, Nombre = "Miguel Bustos", Direccion = "asdasdsa", Numero = 123123 }
        };

        // Define el nombre del archivo CSV
        string filePath = "CSV/cadetes.csv";

        // Crear y escribir en el archivo CSV
        ManejoCSV.WriteCSV(filePath, cadetes);

        Console.WriteLine("Archivo CSV creado y escrito con éxito.");

        // Leer y mostrar el archivo CSV
        List<Cadete> loadedCadetes = ManejoCSV.ReadAndDisplayCSV(filePath);

        // Mostrar los cadetes cargados desde el archivo CSV
        Console.WriteLine("\nCadetes cargados desde el archivo CSV:");
        foreach (Cadete cadete in loadedCadetes)
        {
            Console.WriteLine(cadete.Nombre);
            Console.WriteLine($"Id: {cadete.Id}, Nombre: {cadete.Nombre}, Direccion: {cadete.Direccion}, Telefono: {cadete.Numero}");
        }
    }

}
    // Método para leer el archivo CSV y cargar los datos en una lista de Cadetes
