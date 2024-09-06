using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class ManejoCSV{
    public static void WriteCSV(string filePath, List<Cadete> cadetes)
    {
        StringBuilder sb = new StringBuilder();
        
        // Escribir la cabecera
        sb.AppendLine("Id,Nombre,Direccion,Telefono");

        // Escribir los datos de cada cadete
        foreach (var cadete in cadetes)
        {
            sb.AppendLine($"{cadete.Id},{cadete.Nombre},{cadete.Direccion},{cadete.Numero}");
        }

        // Escribir todo el contenido en el archivo CSV
        File.WriteAllText(filePath, sb.ToString());
    }
}


