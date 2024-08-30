public class Cadete {
    int id;
    string nombre;
    string direccion;
    int numero;
    List<Pedidos> pedidos;

    public Cadete(int id, string nombre, string direccion, int numero, List<Pedidos> pedidos)
    {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.numero = numero;
        this.pedidos = pedidos;
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Numero { get => numero; set => numero = value; }
    public List<Pedidos> Pedidos { get => pedidos; set => pedidos = value; }

    public int JornalACobrar(){
        int total = 0;
        foreach (Pedidos item in this.pedidos)
        {
            if(item.Estado){
                total = total +500;
            }
        }
        return total;
    }
}