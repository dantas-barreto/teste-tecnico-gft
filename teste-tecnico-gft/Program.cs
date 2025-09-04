// Teste Técnico GFF

// Desafio 1:
using teste_tecnico_gft;

var canetaAzul = new Item("Caneta Azul", 50);
bool retirada = canetaAzul.Retirar(10);
Console.WriteLine(canetaAzul.ExibirDados());

// Desafio 2:
var cliente = new Cliente("Clara", 1234);
Console.WriteLine(cliente.Saudacao());

// Desafio 3:
/*
 * Crie uma classe em C# chamada Projeto para gerenciar um projeto chamado
 * "Aplicativo Mobile", com um orçamento inicial de R$5.000,00 e uma equipe de
 * 4 membros. A classe deve ter propriedades para o nome, orçamento e número
 * de membros. O código deve permitir que esses valores sejam acessados e
 * modificados, mas com validação: o orçamento e o número de membros devem ser
 * sempre valores positivos. Se um valor negativo for atribuído, o código deve
 * lançar uma exceção. Além disso, a classe precisa incluir um método para
 * calcular e retornar o orçamento médio por membro. O código deve seguir as
 * boas práticas de programação orientada a objetos e ser bem comentado.
 */