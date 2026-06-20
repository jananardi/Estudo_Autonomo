namespace EstudoAutonomo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processador = new ProcessadorPedido();

            processador.Processar(
                "João",
                1500,
                "joao@email.com"
            );
        }
    }
}
