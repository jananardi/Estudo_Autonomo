using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoAutonomo.Interfaces;

namespace EstudoAutonomo.Repositories
{
    // Implementação responsável pelo armazenamento dos pedidos.
    // Esta classe pode ser substituída futuramente por uma integração
    // real com banco de dados sem impactar outras partes do sistema.
    public class PedidoRepository : IPedidoRepository
    {
        public void Salvar(string cliente, double valorTotal)
        {
            Console.WriteLine(
                $"Salvando pedido de {cliente} no valor de R${valorTotal}"
            );
        }
    }
}
