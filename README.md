Repuestas al TP Nª1

2)Primera pregunta:

   Composicion:
   
   Sin pedidos, clientes no deberia existir. por lo tanto ahi tenemos una composicion.
   
   Agregacion:

   Sin pedidos, Cadetes seguira funcionando. por lo tanto ahi tenemos una agregacion.
   Es el mismo caso para cadeteria.

  Segunda pregunta:

  Cadeteria deberia poder mostrar su lista de cadetes.
  Cadeteria deberia poder agregar, modificar o pasar pedidos a cadetes.
  Cadetes deberia poder mostrar su lista de pedidos.
  Cadetes deberia poder cambiar el estado de los pedidos.
  
  Tercera pregunta:

  Los metodos,atributos y propiedades que deberian ser publicos, serian los cuales yo deberia modificar su comportamiento.
  por ejemplo, el estado de los pedidos, la lista de los pedidos en el caso de los cadetes, el calcular el jornarl, etc.
  En el caso de los privados seria los casos en que el usuario no deberia tocar esos campos, por el ejemplo el ID de los cadetes, el nombre etc. Por lo general todos los atributos se ponene en privado y se utilizan metodos especificos para su modificacion.

  Cuarta pregunta:

  Clientes:
  Atributos que deberan ir si o si:
  Nombre, Direccion y Telefono.
  "Se creeara un contrucctor extra en el caso que se desee incorporar la obs de Direccion".

  Pedidos:
  Atributos que deberan ir si o si:
  Nro, Cliente, Estado.
  "Se creeara un contrucctor extra en el caso que se desee incorporar la obs".

  Cadete:
  Atributos que deberan ir si o si:
  Id,Nombre,Direccion,Telefono.
  "Se creeara un contrucctor extra en el que el cadete venga con pedidos."

  Cadeteria:
  Atributos que deberan ir si o si:
  Nombre,Telefono.
  "Se creeara un contrucctor extra en el que Cadeteria tenga para asignarle una lista de Cadetes."


  Quinta pregunta:
  Podria haberse diseñado de otra forma las clases, una para que se encargue de manipular tanto clientes con los pedidos, ya que cada pedido tendra un cliente especifico, y cada cliente tendra un unico pedido por vez.

  