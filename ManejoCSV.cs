using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class ManejoCSV{
    public static void WriteCSV(string filePath, List<Cadete> cadetes)
    {
        StringBuilder sb = new StringBuilder();
        
        // Escribir la cabecera
        //sb.AppendLine("Id,Nombre,Direccion,Telefono");

        // Escribir los datos de cada cadete
        foreach (var cadete in cadetes)
        {
            sb.AppendLine($"{cadete.Id},{cadete.Nombre},{cadete.Direccion},{cadete.Numero}");
        }

        // Escribir todo el contenido en el archivo CSV
        File.WriteAllText(filePath, sb.ToString());
    }


public static List<Cadete> ReadAndDisplayCSV(string filePath)
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
        for (int i = 0; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');

            // Asegúrate de que el formato del CSV es correcto
            if (values.Length == 4)
            {
                Cadete cadete = new Cadete(int.Parse(values[0]),values[1],values[2],int.Parse(values[3]));

                cadetes.Add(cadete);
            }
        }

        return cadetes;
    }
}