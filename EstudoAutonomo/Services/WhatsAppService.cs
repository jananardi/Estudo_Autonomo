using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoAutonomo.Interfaces;

namespace EstudoAutonomo.Services
{
    // Nova implementação de notificação via WhatsApp.
    // Demonstra o princípio Open/Closed (O), pois foi possível
    // adicionar uma nova funcionalidade sem modificar o código existente.
    public class WhatsAppService : INotificacaoService
    {
        public void Enviar(string destino)
        {
            Console.WriteLine(
                $"Enviando WhatsApp para {destino}"
            );
        }
    }
}
