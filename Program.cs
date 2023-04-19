int opcao;
string[] produto = new string[10];
string[] preco = new string[10];
bool[] resposta = new bool[10];

do
{
    Console.WriteLine(@$"
     ------------------------
    | 1 - Cadastrar Produto  |
    | 2 - Listar Produtos    |
    | 0 - Sair               |
     ------------------------                
");
    opcao = int.Parse (Console.ReadLine());

    switch (opcao)
    {

        case 1:
            Console.WriteLine($"Cadastro de produtos");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o produto: ");
                produto[i] = Console.ReadLine();
                Console.WriteLine("Digite o preco do produto: ");
                preco[i] = Console.ReadLine();


                Console.WriteLine("Produto esta em promocao (S/N): ");
                resposta[i] = Console.ReadLine().ToLower() == "s";
            }

            Console.WriteLine($"Produto(s) cadastrado(s) com sucesso!");
            break;

        case 2:
            Console.WriteLine($"Listagem de Produtos:");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (produto[i] != null && produto[i] != "")
                {
                    Console.WriteLine($"{produto[i]} - R${preco[i]} {(resposta[i] ? "(em promoção)" : "")}");
                    Console.WriteLine();
                }
            }

            break;

        case 0:
            Console.WriteLine($"Saindo do sistema...");
            break;
        default:
            Console.WriteLine($"Opção inválida. Tente novamente.");
            break;
    }

} while (opcao != 0);
