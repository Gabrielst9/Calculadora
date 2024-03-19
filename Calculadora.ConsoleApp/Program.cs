namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando as Váriaveis
            //----------------------------------------------
            decimal primeiroNumero = 0;
            decimal segundoNumero = 0;
            decimal resultado = 0;
            //----------------------------------------------

            while (true)
            {
                //Menu
                //---------------------------------------------------------------
                string operacao = MostrarMenu();
                //---------------------------------------------------------------

                if (OpcaoSaidaSelecionada(operacao ))
                {
                    break;
                }
                else if (OpcaoInvalida(operacao))
                {
                    ExibirMensagemErro();
                    continue;
                }
                else
                    RealizarCalculo(operacao);
            }
        }

        

        static string MostrarMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("| " + " Calculadora Tabajara - 2024" + " |");
            Console.WriteLine("-------------------------------- \n");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("| " + "Digite 1 para Adicionar" + "   |");
            Console.WriteLine("| " + "Digite 2 para Subtrair" + "    |");
            Console.WriteLine("| " + "Digite 3 para Multiplicar" + " |");
            Console.WriteLine("| " + "Digite 4 para Dividir" + "     |");
            Console.WriteLine("| " + "Digite S para Sair" + "        |");
            Console.WriteLine("-----------------------------");
            string operacao = Console.ReadLine();

            return operacao;
        }

        static bool OpcaoSaidaSelecionada(string opcao)
        {
            bool opcaoSaidaSelecionada = opcao == "S" || opcao == "s";

            return opcaoSaidaSelecionada;
        }

        static bool OpcaoInvalida(string opcao)
        {
            bool opcaoInvalida = opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4";

            return opcaoInvalida;
        }

        private static void ExibirMensagemErro()
        {
            Console.WriteLine("Opção Inválida. Por favor, insira uma opção válida.");
        }

        static void RealizarCalculo(string operacao)
        {
            double resultado;

            //Capturando os valores do usuário
            //--------------------------------------------------
            Console.WriteLine("Digite o primeiro número");
            double primeiroNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            double segundoNumero = double.Parse(Console.ReadLine());
            //--------------------------------------------------


            switch (operacao)
            {
                case "1":
                    resultado = primeiroNumero + segundoNumero;
                    break;

                case "2":
                    resultado = primeiroNumero - segundoNumero;
                    break;

                case "3":
                    resultado = primeiroNumero * segundoNumero;
                    break;

                case "4":
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Digite um número diferente de 0 para o segundo número");
                        segundoNumero = double.Parse(Console.ReadLine());
                    }

                    resultado = primeiroNumero / segundoNumero;
                    break;

                default:
                    resultado = 0;
                    break;
            }

            resultado = primeiroNumero / segundoNumero;

            ExibirResultado(resultado);
        }

        private static void ExibirResultado(double resultado)
        {
            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}