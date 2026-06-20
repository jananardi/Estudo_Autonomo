using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAutonomo.Interfaces
{
    // Interface que define o contrato para persistência de pedidos.
    // Permite que diferentes implementações de banco de dados
    // sejam utilizadas sem alterar a lógica principal da aplicação.
    public interface IPedidoRepository
    {
        void Salvar(string cliente, double valorTotal);
    }
}
