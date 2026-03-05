using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Course
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            Console.WriteLine(order);

            // Convertendo um enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Fazendo o caminho inverso (string->enum)
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            // O valor deve estar igual ao que está dentro do enum OrderStatus
            Console.WriteLine(os);


        }
    }

}