using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAutonomo.Services
{
    // Responsável pelas regras de negócio do pedido,
    // como validações e aplicação de descontos.
    // Segue o princípio Single Responsibility (S),
    // possuindo apenas uma responsabilidade.
    public class PedidoService
    {
        public double ProcessarValor(double valorTotal)
        {
            if (valorTotal <= 0)
            {
                throw new ArgumentException(
                    "Valor do pedido inválido."
                );
            }

            if (valorTotal > 1000)
            {
                valorTotal -= 100;
            }

            return valorTotal;
        }
    }
}
