public class Cadeteria {

    string nombre;
    int telefono;

    List<Cadete> cadetes;

    public Cadeteria(string nombre, int telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
    }
    public Cadeteria(string nombre, int telefono, List<Cadete> cadetes)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.cadetes = cadetes;
    }



    public string Nombre { get => nombre; set => nombre = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }

    public void MostrarCadetes (){
        foreach (Cadete item in cadetes)
        {
            Console.WriteLine("\nID: "+item.Id);
            Console.WriteLine("\nNombre: "+item.Nombre);
            Console.WriteLine("\nNumero: "+item.Numero);
            Console.WriteLine("\nDireccion: "+item.Direccion);
        }
    }

    public void AgregarPedido (Pedidos pedido){
        
    }
}