# Refatoração utilizando SOLID

## Objetivo

Refatorar o código original que concentrava múltiplas responsabilidades em uma única classe, aplicando princípios do SOLID para melhorar a manutenção, organização e extensibilidade do sistema.

## Princípios Aplicados

### Single Responsibility Principle (SRP)

As responsabilidades foram separadas em classes específicas:

* PedidoService: validações e regras de negócio.
* PedidoRepository: persistência dos pedidos.
* EmailService e WhatsAppService: envio de notificações.

### Open/Closed Principle (OCP)

O sistema foi projetado para permitir a adição de novos canais de notificação sem alterar o código principal. Como exemplo, foi criada a classe WhatsAppService implementando a mesma interface de notificação.

### Dependency Inversion Principle (DIP)

A classe ProcessadorPedido depende de abstrações (interfaces) em vez de implementações concretas, reduzindo o acoplamento e facilitando futuras modificações.

## Resultado

O código ficou mais organizado, reutilizável e preparado para futuras expansões, seguindo boas práticas de desenvolvimento orientado a objetos.

