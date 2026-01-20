using System;
using System.Globalization;

namespace ExercicioBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine()!);

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine()!;

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine()!);

            Conta conta;

            if (resp == 's' || resp == 'S'){
                Console.Write("Entre um valor para depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, titular, valorDeposito);
            }
            else{
                conta = new Conta(numeroConta, titular);                
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}