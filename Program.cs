// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Bem vindo à loja!");

        Console.WriteLine($"Digite seu saldo");
        double saldoCliente = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Saldo total = {saldoCliente}\n");

        bool continuarComprando = true;

        while (continuarComprando && saldoCliente > 0)
        {
            Console.WriteLine("Temos os seguintes produtos:\n");
            Console.WriteLine("A - Shampoo R$:30,00");
            Console.WriteLine("B - Condicionador R$:20,00");
            Console.WriteLine("C - Máscara R$:50,00");
            Console.WriteLine("D - Esmalte qualquer cor R$:5,00\n");

            double
            Shampoo = 30,
            Condicionador = 20,
            Mascara = 50,
            Esmalte = 5;

            Console.WriteLine("Escolha o produto (A, B, C ou D):");
            string digito = Console.ReadLine().ToUpper();

            if (digito == "A" && saldoCliente >= Shampoo)
                saldoCliente -= Shampoo;
            else if (digito == "B" && saldoCliente >= Condicionador)
                saldoCliente -= Condicionador;
            else if (digito == "C" && saldoCliente >= Mascara)
                saldoCliente -= Mascara;
            else if (digito == "D" && saldoCliente >= Esmalte)
                saldoCliente -= Esmalte;
            else
                Console.WriteLine("Saldo insuficiente ou opção inválida.");

            Console.WriteLine($"Saldo atual: R$ {saldoCliente}");

            if (saldoCliente <= 0)
            {
                Console.WriteLine("Seu saldo acabou!");
                break;
            }

            Console.WriteLine("Deseja mais alguma coisa ou finalizar a compra? \nA - Sim \nB - Finalizar");
            string proxDigito = Console.ReadLine().ToUpper();

            if (proxDigito != "A")
            {
                continuarComprando = false;
                Console.WriteLine("Compra finalizada com sucesso!");
            }
        }
    }

}

