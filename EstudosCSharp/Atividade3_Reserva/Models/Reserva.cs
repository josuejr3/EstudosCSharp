using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() 
        {
            Hospedes = new List<Pessoa>();
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verifica se a capacidade da suíte é suficiente
            if (Suite == null)
                throw new Exception("Nenhuma suíte cadastrada na reserva!");

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lança exceção se houver mais hóspedes que a capacidade
                throw new Exception("Número de hóspedes maior que a capacidade da suíte!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Valor base: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Aplica desconto de 10% se os dias reservados forem >= 10
            if (DiasReservados >= 10)
            {
                valor *= 0.9m; // desconto de 10%
            }

            return valor;
        }
    }
}
