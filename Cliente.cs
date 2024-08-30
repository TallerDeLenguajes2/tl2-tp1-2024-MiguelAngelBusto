public class Cliente {

    string nombre;
    string direccion;
    int numero;
    string datosObsDirec;

    public Cliente(string nombre, string direccion, int numero)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.numero = numero;
    }

    public Cliente(string nombre, string direccion, int numero, string datosObsDirec)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.numero = numero;
        this.datosObsDirec = datosObsDirec;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Numero { get => numero; set => numero = value; }
    public string DatosObsDirec { get => datosObsDirec; set => datosObsDirec = value; }
}