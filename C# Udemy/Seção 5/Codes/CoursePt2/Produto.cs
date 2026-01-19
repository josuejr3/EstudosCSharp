using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CoursePt2
{
    public class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        public string Nome {
            get {return _nome; }
            set{    
                if (value != null && value.Length > 1){
                    _nome = value;
                }
            }
        }



        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this() {
            this._nome = nome;
            this.Preco = preco;            
        }




        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public override string ToString()
        {
        	return _nome 
            + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", " 
            + Quantidade 
            + " unidades, Total: $ " 
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }





        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }


    }
}