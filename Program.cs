using System;

namespace Aula_24___Carrinho
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Seu carrinho:");
            Produto p1 = new Produto(1, "PlayStation 4", 2599f);
            Produto p2 = new Produto(2, "Iphone 11 Pro Max", 7057f);
            Produto p3 = new Produto(3, "Computador - I7(9°g)", 5600f);
            Produto p4 = new Produto(4, "Televisão 60pol", 3200f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.MostrarProdutos();
        }
    }
}
