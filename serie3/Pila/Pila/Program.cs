class Program
{
    static void Main(string[] args)
    {

        Pila pila = new Pila(10);

        pila.Push(10);
        pila.Push(20);
        pila.Push(30);
        pila.Push(40);

        pila.Clear();
        pila.Mostrar();
        pila.MostrarAnteriores();
    }
}

