
class Program
{
    static void Main()
    {
        // Crear una cola
        Queue<string> cola = new Queue<string>();

        // Operaciones básicas
        cola.Enqueue("Uno"); // Insertar elemento
        cola.Enqueue("Dos");
        cola.Enqueue("Tres");

        // Mostrar elementos
        Console.WriteLine("Elementos en la cola:");
        foreach (var elemento in cola)
        {
            Console.WriteLine(elemento);
        }

        // Eliminar elemento (FIFO - First In First Out)
        string elementoEliminado = cola.Dequeue();
        Console.WriteLine($"Elemento eliminado: {elementoEliminado}");

        // Mostrar elementos después de la eliminación
        Console.WriteLine("Elementos en la cola después de la eliminación:");
        foreach (var elemento in cola)
        {
            Console.WriteLine(elemento);
        }
        Console.ReadKey();
    }
}
