# Binary Search Tree (BST) in C#

## 📖 Descripción
Este proyecto implementa un Árbol de Búsqueda Binaria (BST) en C#. Incluye operaciones como inserción, búsqueda, eliminación y recorrido del árbol en diferentes órdenes. Es ideal para entender estructuras de datos en C# y cómo gestionar árboles binarios de búsqueda.

## 📌 Características
- Insertar un nodo en el BST
- Buscar un nodo en el BST
- Eliminar un nodo del BST
- Recorridos: Preorden, Inorden y Postorden
- Interfaz de consola interactiva para probar las funcionalidades

## 📝 Uso
Cuando ejecutes el programa, verás un menú con opciones como:
1. Insertar un nodo
2. Buscar un nodo
3. Imprimir en Preorden
4. Imprimir en Inorden
5. Imprimir en Postorden
6. Eliminar un nodo
7. Salir

Introduce el número de la opción deseada y sigue las instrucciones en pantalla.

## 🛠 Implementación
La clase `BTS` representa un Árbol de Búsqueda Binaria. Sus principales métodos son:
- **Insert(int data):** Agrega un nodo al árbol.
- **Search(int data):** Busca un nodo en el árbol y muestra si existe o no.
- **PreOrder(), InOrder(), PostOrder():** Recorridos del árbol.
- **deleteNode(int value):** Elimina un nodo específico del árbol.

### Ejemplo de Código
A continuación, se muestra un ejemplo de uso del BST en C#:

```csharp
class Program
{
    static void Main(string[] args)
    {
        BTS tree = new BTS();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(80);
        
        Console.WriteLine("Inorden:");
        tree.Inorder();
        
        Console.WriteLine("\nEliminando 50...");
        tree.deleteNode(50);
        
        Console.WriteLine("Inorden después de eliminar 50:");
        tree.Inorder();
    }
}
```

## 🎯 Resultados
Al ejecutar el programa, el usuario podrá realizar las operaciones mencionadas y visualizar el estado del BST en cada paso. Por ejemplo, al insertar y recorrer el árbol en inorden, se verá la estructura ordenada de los elementos. La eliminación de un nodo reorganizará el árbol para mantener sus propiedades.

