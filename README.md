# ExamenDatos
## Examen Acceso Datos
Andrea García Bravo
19/10/2018

url: https://github.com/Andrea-Miin/ExamenDatos

## 1.
IEnumerable representa una colección que puede enumerarse, es decir, algo que puede recorrerse independientemente de cómo sea su estructura.  
IQueryable es una interfaz que se utiliza en LINQ to SQL principalmente. Solo te tienes que preocupar por ella si quieres implementar un proveedor de LINQ.  
La principal diferencia es que IQueryable de LINQ usa expresiones en lugar de delegados.  
IEnumerable es útil para trabajar con secuencias que se iteran en memoria, pero IQueryable es ideal con fuentes de datos remotas como una base de datos.  
Con IEnumerable podemos hacer una consulta LINQ a objetos, mientras que IQueryable la hace a SQL.  
Además, IEnumerable es lento para consultar datos, mientras que IQueryable es más rápido.

## 2.
## Parte a  
Declaro los dos arrays y creo un IEnumerable al que le digo que quiero todos los datos de a excepto los que se encuentren en b.  
Y corro un foreach en caso de que hayan mas de un valor.    
## Parte b  
Utilizo left join para juntar las dos tablas y coger solo las que en la columna de la derecha sean nulas.

## 3.
Declaro una lista de int con un numero de cualquiera.  
Mediante unos for recorro la lista dandole un valor secuencial y envio el valor de ese momento a otra clase donde comprueba si es par, menor o mayor que 10.  
Si lo es, lo muestra por pantalla.

## 4.
Creo otra lista de enteros vacia. con un for recorro la lista anterior para darle los valores.  
Lo guardo en una variable result donde utilizo la palabra reservada de LINQ Max() para sacar el valor mayor de la lista.

## 5.
Los objetos básicos de ADO.NET son:  
	* Connection => Proporciona conectividad a una base de datos. También actúa como abstract factory para los objetos command.  
	* Command => Permite tener acceso a los comandos de la base de datos para devolver, modificar, agregar o eliminar datos. También para ejecutar procedimientos.  
	* Parameter => Describe un parametro para un command, incluido direccion, tipo de datos y sintaxis de datos.

## 6.
## Parte a  
Primero declaro los dos enteros que se van a sumar y multiplicar.  
Despues mediante expresion lambda sumo y multiplico los valores, para despues introducirlos en dos delegados.  
Por ultimo, los muestro en pantalla.    
## Parte b  
Creo un clase Operation donde hago, por un lado la suma de dos valores, y por otro lado la multiplicacion.  
Despues regresa el resultado.  
En la parte principal del programa llamo a las dos operaciones pasando los dos valores con los que quiero trabajar.