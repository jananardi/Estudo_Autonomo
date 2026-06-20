using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoAutonomo.Interfaces;
using EstudoAutonomo.Services;

namespace EstudoAutonomo
{
    // Classe responsável por coordenar o processamento do pedido.
    // Utiliza abstrações (interfaces) para reduzir o acoplamento,
    // seguindo o princípio Dependency Inversion (D) do SOLID.
    public class ProcessadorPedido
    {
        private readonly IPedidoRepository _repository;
        private readonly INotificacaoService _notificacao;
        private readonly PedidoService _pedidoService;

        public ProcessadorPedido(
            IPedidoRepository repository,
            INotificacaoService notificacao,
            PedidoService pedidoService)
        {
            _repository = repository;
            _notificacao = notificacao;
            _pedidoService = pedidoService;
        }

        public void Processar(
            string cliente,
            double valorTotal,
            string contato)
        {
            valorTotal =
                _pedidoService.ProcessarValor(valorTotal);

            _repository.Salvar(cliente, valorTotal);

            _notificacao.Enviar(contato);
        }
    }
}
