using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {   Console.ForegroundColor = ConsoleColor.Red;

            foreach (var item in produtos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: R$ {item.Preco}");
                Console.WriteLine();
                
                Console.ResetColor();
            }
        }
    }
}