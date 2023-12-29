using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_Estacionamento_C_.moldels
{
    public class Estacionamento
    {
        private List<string> Veiculos = new List<string>();
        private decimal precoInicial = 0;
        private decimal precoHora = 0;

        public Estacionamento(decimal inicial, decimal hora)
        {
            this.precoInicial = inicial;
            this.precoHora = hora;

        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar:  ex:ABC-1234: ");
            string placaVeiculo = Console.ReadLine();
            Veiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover");
            string placa = "";
            placa = Console.ReadLine();
            if (Veiculos.Any(placa => placa.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiuculo permaneceu estacionado:");
                int tempoEstacionado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Valor totalizado com as horas utilizada do serviço: {precoInicial + (precoHora * tempoEstacionado):c}");

            }
            else
            {
                Console.WriteLine($"Placa{placa} não encontrada");
            }
            Veiculos.Remove(placa);


        }
        public void ListarVeiculo()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine($"Todos os Veiculos Estacionados:");
                for (int i = 0; i < Veiculos.Count; i++)
                {
                    Console.WriteLine($"N°{i + 1} - {Veiculos[i]}");
                }

            }else{
                Console.WriteLine("Não há veiculos estacionados");
            }

        }

    }
}
