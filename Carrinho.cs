using System;
using System.Collections.Generic;

namespace Aula_24___Carrinho
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void MostrarProdutos()
        {
            if(carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"{p.Nome} - R$ {p.Preco.ToString("n2")}");
                }
                MostrarTotal();
            }
        }

        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if(carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"Total do Carrinho: \nR${ValorTotal.ToString("n2")} ");
            }else{
                Console.WriteLine($"Seu carrinho ainda está vazio!");
            }
        }
    }
}