using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {   
            foreach (var item in produtos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: R$ {item.Preco}");
                Console.WriteLine();
                
            }
        } // fim de Listar

        public Produto CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine("Digite um código: ");
            produto.Codigo = int.Parse( Console.ReadLine() );

            Console.WriteLine("Digite o nome do produto desejado: ");
            produto.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite o preço do produto: ");
            produto.Preco = float.Parse ( Console.ReadLine() );

            return produto;

        } // fim de Cadastrar Produto

    }
}