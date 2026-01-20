using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    public class Conta
    {

        // Atributos - Getters e Setters
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtores
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }
        public Conta(int numero, string titular, double saldo) : this(numero, titular) {
            Deposito(saldo);
        }

        // Saques e Depósitos
        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque (double quantia)
        {
            Saldo -= (quantia + 5.0);
        }


        // Sobrecarga do ToString
        public override string ToString(){
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}