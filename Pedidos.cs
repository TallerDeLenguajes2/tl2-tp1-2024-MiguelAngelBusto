public class  Pedidos{

    int numero;
    string observaciones;
    Cliente cliente;
    bool estado;

    public Pedidos(int numero, string observaciones, Cliente cliente, bool estado)
    {
        this.numero = numero;
        this.observaciones = observaciones;
        this.cliente = cliente;
        this.estado = estado;
    }

    public int Numero { get => numero; set => numero = value; }
    public string Observaciones { get => observaciones; set => observaciones = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
    public bool Estado { get => estado; set => estado = value; }

    public string VerDireccionCliente(){
        return this.Cliente.Direccion;
    }

    public string VerDatosCliente(){
        return "Nombre: "+this.Cliente.Nombre+"\nDireccion: "+this.Cliente.Direccion+"\nNumero: "+this.Cliente.Numero.ToString()+"\nObservacion de Direccion: "+this.Cliente.DatosObsDirec;
    }
}