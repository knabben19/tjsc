using System;

class Program
{
    static void Main()
    {
        string opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("  SISTEMA INFORMATIVO - TJSC");
            Console.WriteLine("=======================================");
            Console.WriteLine("1 - Sobre o TJSC");
            Console.WriteLine("2 - Serviços disponíveis no site");
            Console.WriteLine("3 - Simular consulta de processo");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("=======================================");
            Console.Write("Escolha uma opção: ");
            
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    MostrarSobre();
                    break;

                case "2":
                    MostrarServicos();
                    break;

                case "3":
                    ConsultarProcesso();
                    break;

                case "0":
                    Console.WriteLine("Encerrando sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != "0")
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != "0");
    }

    static void MostrarSobre()
    {
        Console.Clear();
        Console.WriteLine("=== SOBRE O TJSC ===\n");
        Console.WriteLine("O Tribunal de Justiça de Santa Catarina (TJSC)");
        Console.WriteLine("é o órgão máximo do Poder Judiciário do Estado de Santa Catarina.");
        Console.WriteLine("Ele julga processos de 2ª instância e administra o Judiciário estadual.");
        Console.WriteLine("\nSite oficial: https://www.tjsc.jus.br/");
    }

    static void MostrarServicos()
    {
        Console.Clear();
        Console.WriteLine("=== SERVIÇOS DISPONÍVEIS NO SITE ===\n");
        Console.WriteLine("- Consulta processual");
        Console.WriteLine("- Jurisprudência");
        Console.WriteLine("- Certidões");
        Console.WriteLine("- Diário da Justiça");
        Console.WriteLine("- Consulta de pautas de julgamento");
        Console.WriteLine("- Serviços ao cidadão");
    }

    static void ConsultarProcesso()
    {
        Console.Clear();
        Console.WriteLine("=== CONSULTA PROCESSUAL (SIMULAÇÃO) ===\n");
        Console.Write("Digite o número do processo: ");
        string numero = Console.ReadLine();

        Console.WriteLine("\nConsultando processo " + numero + "...");
        Console.WriteLine("Status: Em andamento");
        Console.WriteLine("Última movimentação: 15/02/2026");
        Console.WriteLine("Vara: 1ª Vara Cível");
    }
}