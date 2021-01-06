using System;
using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {

        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv"; // PATH = Nome da constante

        public Produto(){

            // Verificar se a pasta exite

            string pasta = PATH.Split("/")[0];

            /* Indice [0] = Database
               Indice [1] = Produto.csv */

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Verificar se o arquivo existe

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
                
            }

        } // fim do método construtor Produto

        // internal List<Produto> Ler()
        // {
        //     throw new NotImplementedException();
        // }

        public List<Produto> Read()
        {
            // Criando uma lista para armazenar os produtos
            List<Produto> product = new List<Produto>();

            // Lemos as linhas do arquivo CSV
            string[] linhas = File.ReadAllLines(PATH);

            // Percorremos as linhas do arquivo CSV
            foreach (string item in linhas)
            {
                // Separamos os elementos de cada linha
                string [] atributos = item.Split(";");

                // Exemplo abaixo:

                // 1;Smart-watch;2000,00
                /* [0] = 1
                   [1] = Smart-watch
                   [2] = 2000,00

                */

                // Passamos para um objeto do tipo Produto
                Produto prod = new Produto();
                
                prod.Codigo = int.Parse( atributos[0] );
                prod.Nome = atributos[1] ;
                prod.Preco = float.Parse( atributos[2] );

                product.Add(prod);


            }

            return product;
        }

        public void Inserir(Produto product)
        {
        // Criamos um array de linhas para inserir no csv
        string [] linhas = { PrepararLinhasCSV (product) };

        // Método responsável por inserir linhas em um arquivo
        File.AppendAllLines(PATH, linhas);
        }
        string PrepararLinhasCSV(Produto prod)
        {
            return $"{prod.Codigo}; {prod.Nome}; {prod.Preco}";
        } 


    }
}