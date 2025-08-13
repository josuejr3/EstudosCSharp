public class Venda {

    public Venda(int id, string nome, decimal preco)
    {
        Id = id;
        Preco = preco;
        Produto = nome;
    }
    
    
    
    public int Id { get; set; }
    public string Produto { get; set; }
    public decimal Preco { get; set; }
}