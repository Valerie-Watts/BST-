# Árbol Binario de Búsqueda en C#

## Descripción
Los estudiantes deberán implementar un **Árbol Binario de Búsqueda (ABB)** en el lenguaje C# con las siguientes funcionalidades:

1. **Inserción de nodos** en el árbol.
2. **Búsqueda de un valor** en el árbol.
3. **Recorridos del árbol** en preorden, inorden y postorden.
4. **Eliminación de un nodo** del árbol manteniendo sus propiedades.

El programa permitirá al usuario ingresar valores y visualizar los recorridos correspondientes.

## Instrucciones
1. Implementar una clase que represente los nodos del árbol y otra que maneje la estructura del **Árbol Binario de Búsqueda**.
2. Incluir métodos para insertar, buscar, eliminar y recorrer el árbol en **preorden, inorden y postorden**.
3. Crear un menú en consola que permita al usuario realizar estas operaciones interactivamente.
4. Entregar el código fuente en un repositorio de GitHub junto con un README explicativo que describa la implementación y los resultados obtenidos.

## Uso
Al ejecutar el programa, se mostrará un menú con las siguientes opciones:

1. Insertar un nodo
2. Buscar un valor
3. Recorrer en preorden
4. Recorrer en inorden
5. Recorrer en postorden
6. Eliminar un nodo
7. Salir

### Ejemplo de Uso
Ejemplo de interacción con el usuario:

```plaintext
Árbol Binario de Búsqueda

¿Qué desea realizar?
1. Insertar un nodo
2. Buscar un valor
3. Recorrer en preorden
4. Recorrer en inorden
5. Recorrer en postorden
6. Eliminar un nodo
7. Salir

Ingrese una opción: 1
Ingrese el valor del nodo: 50
Se ha insertado el nodo con valor: 50

Ingrese una opción: 1
Ingrese el valor del nodo: 30
Se ha insertado el nodo con valor: 30

Ingrese una opción: 1
Ingrese el valor del nodo: 70
Se ha insertado el nodo con valor: 70

Ingrese una opción: 5
Recorrido en postorden:
30
70
50
```

