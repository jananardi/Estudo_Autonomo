using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoAutonomo.Interfaces;

namespace EstudoAutonomo.Services
{
    // Implementação de envio de notificações por e-mail.
    // Novos canais de comunicação podem ser adicionados
    // através de novas implementações da interface.
    public class EmailService : INotificacaoService
    {
        public void Enviar(string destino)
        {
            Console.WriteLine(
                $"Enviando e-mail para {destino}"
            );
        }
    }
}
