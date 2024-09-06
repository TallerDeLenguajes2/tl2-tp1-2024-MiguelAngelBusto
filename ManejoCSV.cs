using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

public class ManejoCSV{
    public Cadeteria LoadCadeteria(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            return csv.GetRecords<Cadeteria>().FirstOrDefault();
        }
    }

    public void LoadCadetes(string filePath, Cadeteria cadeteria)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            var cadetes = csv.GetRecords<Cadete>().ToList();
            cadeteria.Cadetes.AddRange(cadetes);
        }
    }

    public void LoadClientes(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            var clientes = csv.GetRecords<Cliente>().ToList();
            GlobalData.Clientes = clientes.ToDictionary(c => c.Numero);
        }
    }

    public void LoadPedidos(string filePath, Cadeteria cadeteria)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            var pedidos = csv.GetRecords<Pedidos>().ToList();
            foreach (var cadete in cadeteria.Cadetes)
            {
                cadete.Pedidos = pedidos.Where(p => p.Cliente != null && p.Cliente.Numero == cadete.Numero).ToList();
                
                foreach (var pedido in cadete.Pedidos)
                {
                    if (pedido.Cliente != null && GlobalData.Clientes.ContainsKey(pedido.Cliente.Numero))
                    {
                        pedido.Cliente = GlobalData.Clientes[pedido.Cliente.Numero];
                    }
                }
            }
        }
    }

    public void SaveCadeteria(string filePath, Cadeteria cadeteria)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            csv.WriteRecord(cadeteria);
            csv.NextRecord();
        }
    }

    public void SaveCadetes(string filePath, IEnumerable<Cadete> cadetes)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            csv.WriteRecords(cadetes);
        }
    }

    public void SaveClientes(string filePath, IEnumerable<Cliente> clientes)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            csv.WriteRecords(clientes);
        }
    }

    public void SavePedidos(string filePath, IEnumerable<Pedidos> pedidos)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            csv.WriteRecords(pedidos);
        }
    }
}

// Clase para almacenar datos globales
public static class GlobalData
{
    public static Dictionary<int, Cliente> Clientes { get; set; } = new Dictionary<int, Cliente>();
}
