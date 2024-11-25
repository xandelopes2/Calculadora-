using System;

class Program
{
    static void Main(string[] args)
    {
        // MINHA PRIMEIRA CALCULADORA

        int soma1 = 0;
        int soma2 = 0;
        int total1 = 0;

        int sub1 = 0;
        int sub2 = 0;
        int total2 = 0;

        int mult1 = 0;
        int mult2 = 0;
        int total3 = 0;

        int div1 = 0;
        int div2 = 0;
        int total4 = 0;

        Console.WriteLine("Seja Bem-vindo a calculadora do Alexandre xD");
        Console.WriteLine("Qual operação deseja realizar?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        if (int.TryParse(Console.ReadLine(), out int operacao))
        {
            if (operacao == 1)
            {
                Console.WriteLine("Digite o primeiro numero: (inteiro)");
                soma1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: (inteiro)");
                soma2 = int.Parse(Console.ReadLine());

                total1 = soma1 + soma2;

                Console.WriteLine($"O valor da soma dos dois numeros é: {total1}");
            }
            else if (operacao == 2)
            {
                Console.WriteLine("Digite o primeiro numero inteiro: ");
                sub1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero inteiro: ");
                sub2 = int.Parse(Console.ReadLine());

                total2 = sub1 - sub2;

                Console.WriteLine($"O valor da subtração dos dois numeros é: {total2}");
            }
            else if (operacao == 3)
            {
                Console.WriteLine("Digite o primeiro numero inteiro: ");
                mult1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero inteiro: ");
                mult2 = int.Parse(Console.ReadLine());

                total3 = mult1 * mult2;

                Console.WriteLine($"O valor da multiplicação dos dois numeros é: {total3}");
            }
            else if (operacao == 4)
            {
                Console.WriteLine("Digite o primeiro número inteiro: ");
                div1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número inteiro: ");
                div2 = int.Parse(Console.ReadLine());

                
                if (div2 != 0)
                {
                    total4 = div1 / div2;
                    Console.WriteLine($"O valor da divisão dos dois numeros é: {total4}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida. Escolha um numero entre 1 e 4.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um numero.");
        }
        Console.ReadLine();
    }
}