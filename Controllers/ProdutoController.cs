using System;
using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        
        // Models
        Produto produto = new Produto();


        // Views
        ProdutoView productview = new ProdutoView();

        public void ListarProdutos()
        {
            productview.Listar( produto.Read() );

        }

        public void Cadastrar()
        {
            produto.Inserir( productview.CadastrarProduto() );
        }


    }
}