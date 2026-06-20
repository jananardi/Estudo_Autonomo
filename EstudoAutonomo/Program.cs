using EstudoAutonomo.Interfaces;
using EstudoAutonomo.Repositories;
using EstudoAutonomo.Services;

namespace EstudoAutonomo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPedidoRepository repository =
                new PedidoRepository();

            INotificacaoService notificacao =
                new EmailService();

            PedidoService pedidoService =
                new PedidoService();

            var processador =
                new ProcessadorPedido(
                    repository,
                    notificacao,
                    pedidoService
                );

            processador.Processar(
                "João",
                1500,
                "joao@gmail.com"
            );

            //A resposta da IA que mais me ajudou foi entender que o princípio Single Responsibility não significa criar várias classes sem necessidade,
            //mas sim garantir que cada classe tenha apenas um motivo para mudar. Isso me ajudou a enxergar como separar regras de negócio,
            //persistência e notificações em responsabilidades diferentes.
        }
    }
}
