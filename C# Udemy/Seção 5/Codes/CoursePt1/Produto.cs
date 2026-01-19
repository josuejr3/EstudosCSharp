using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CoursePt1
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produto()
        {
            _quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this() {
            this._nome = nome;
            this._preco = preco;            
        }




        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }


        public override string ToString()
        {
        	return _nome 
            + ", $ " 
            + _preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", " 
            + _quantidade 
            + " unidades, Total: $ " 
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


        public string GetNome()
        {
            return this._nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }



        public void AdicionarProdutos(int quantity)
        {
            _quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            _quantidade -= quantity;
        }


    }
}