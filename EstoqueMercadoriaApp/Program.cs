using EstoqueMercadoriaEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueMercadoriaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int RandQtd; double RandValor;

            Random Rand = new Random();

            EstoqueModel Estoque = new EstoqueModel();

            for(int i=0; i<1000; i++)
            {
                RandQtd = Rand.Next(1000);
                RandValor = Math.Round(Rand.NextDouble() * Rand.Next(1000), 2);

                Estoque.Mercadorias.Add(new MercadoriaModel(RandQtd, RandValor));
            }

            Console.Write("Valor total: ");
            Console.WriteLine(Estoque.GetValorTotal());

            Console.Write("Média de valor das mercadorias: ");
            Console.WriteLine(Estoque.GetMediaValor());

            Console.ReadKey();
        }
    }
}
