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
            string operacao = "";
            //----------------------------------------------

            while (true)
            {
                //Menu
                //---------------------------------------------------------------
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
                operacao = Console.ReadLine();
                //---------------------------------------------------------------


                if (operacao == "S" || operacao == "s")
                {
                    break;
                }
                else if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
                {
                    Console.WriteLine("Opção Inválida. Por favor, insira uma opção válida.");
                    continue;
                }


                //Capturando os valores do usuário
                //--------------------------------------------------
                Console.WriteLine("Digite o primeiro número");
                primeiroNumero = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número");
                segundoNumero = decimal.Parse(Console.ReadLine());
                //--------------------------------------------------



                //Adição
                //----------------------------------------------
                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                //----------------------------------------------

                //Subtração
                //----------------------------------------------
                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                //----------------------------------------------

                //Multiplicação
                //----------------------------------------------
                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                //----------------------------------------------

                //Divisão
                //----------------------------------------------
                else if (operacao == "4")
                {
                    if (primeiroNumero == 0 && segundoNumero == 0)
                    {
                        Console.WriteLine("\n A divisão do número 0 por 0 é inderteminada \n");
                    }
                    else
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }
                }
                else
                {
                    Console.WriteLine("Opcao Invalida");
                }
                //----------------------------------------------
            }

        }
    }
}
