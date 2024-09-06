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
        /*List<Cadete> loadedCadetes = ReadAndDisplayCSV(filePath);

        // Mostrar los cadetes cargados desde el archivo CSV
        Console.WriteLine("\nCadetes cargados desde el archivo CSV:");
        foreach (var cadete in loadedCadetes)
        {
            Console.WriteLine($"Nombre: {cadete.Nombre}, Edad: {cadete.Edad}, Cargo: {cadete.Cargo}");
        }*/
    }

}
    // Método para leer el archivo CSV y cargar los datos en una lista de Cadetes
    /*static List<Cadete> ReadAndDisplayCSV(string filePath)
    {
        List<Cadete> cadetes = new List<Cadete>();

        // Leer el archivo CSV
        string[] lines = File.ReadAllLines(filePath);

        // Mostrar el contenido del archivo CSV
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        // Procesar el contenido del archivo CSV (excepto la cabecera)
        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');

            // Asegúrate de que el formato del CSV es correcto
            if (values.Length == 3)
            {
                Cadete cadete = new Cadete
                {
                    Nombre = values[0],
                    Edad = int.Parse(values[1]),
                    Cargo = values[2]
                };

                cadetes.Add(cadete);
            }
        }

        return cadetes;
    }
}*/
