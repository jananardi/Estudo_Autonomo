using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAutonomo
{
    public class ProcessadorPedido
    {

        // Esta classe possui várias responsabilidades:
        // - Valida o pedido
        // - Aplica regras de negócio
        // - Salva no banco de dados
        // - Envia e-mail
        // Isso dificulta a manutenção e viola o princípio
        // Single Responsibility (SRP) do SOLID.

        public void Processar(string cliente, double valorTotal, string emailCliente)
        {
            // Validação do pedido
            if (valorTotal <= 0)
            {
                throw new ArgumentException("Valor do pedido inválido.");
            }

            // Regra de negócio (desconto VIP)
            if (valorTotal > 1000)
            {
                valorTotal -= 100;
            }

            // Simulação de persistência no banco
            Console.WriteLine($"Salvando pedido de {cliente} no valor de R${valorTotal} no Banco de Dados...");

            // Simulação de envio de e-mail
            Console.WriteLine($"Enviando e-mail para {emailCliente}: Seu pedido foi processado com sucesso!");
        }

        //Primeiro Commit: implementação original.
        //A classe ProcessadorPedido concentra validação, regras de negócio, persistência e notificações em um único local,
        //dificultando manutenção e evolução do sistema, além de violar princípios do SOLID.
    }
}
