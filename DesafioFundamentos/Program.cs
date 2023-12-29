using System.Diagnostics.Contracts;
using projeto_Estacionamento_C_.moldels;
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal ValorInicial = 0;
decimal ValorHora = 0;

Console.WriteLine("Seja Bem-Vindo ao sistema de estacionamento");
Console.WriteLine("Digite o preço inicial: ");
ValorInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o preço por Hora: ");
ValorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(ValorInicial, ValorHora);
bool rodar = true;


while (rodar)
{

    Console.WriteLine("Digite a sua Opção \n1 - Cadastrar veiculos \n2 - Remover Veiculos \n3 - Listar Veiculo \n4 - Encerrar");
    int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
    switch (opcaoEscolhida)
    {

        case 1:
            es.AdicionarVeiculo();
            break;
        case 2:
            es.RemoverVeiculo();
            break;
        case 3:
            es.ListarVeiculo();
            break;
        case 4:
            rodar = false;
            break;

        default:
            Console.WriteLine("Valor não invalido, verifique as opções disponiveis");
            break;

    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
      Console.Clear();

}
Console.WriteLine("Encerrando Serviço");

