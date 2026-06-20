using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAutonomo.Interfaces
{
    // Interface responsável por definir o contrato de envio
    // de notificações para os clientes.
    public interface INotificacaoService
    {
        void Enviar(string destino);
    }
}
