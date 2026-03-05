using System.Globalization;
using Exercicio.Entities.Enums;
using System.Text;

namespace Exercicio.Entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    
    
    public Order()
    {
    }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }
    
    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);
    }

    public double Total()
    {
        double sum = 0.0;
        foreach (OrderItem item in Items)
        {
            sum += item.SubTotal();
        }

        return sum;
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
        output.AppendLine($"Order status: {Status}");
        output.AppendLine($"Client: {Client}");
        output.AppendLine("Order Items:");
        foreach (OrderItem item in Items)
        {
            output.AppendLine(item.ToString());
        }

        output.AppendLine($"Total price: $ {Total().ToString("F2", CultureInfo.InvariantCulture)}");
        return output.ToString();
    }


}