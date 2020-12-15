using System;
using EX2.Classes.cs;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
           Produtos produtos1 = new Produtos();
           produtos1.Codigo = 1;
           produtos1.Nome = "Suco de Maracuja";
           produtos1.Descricao = "Polpa de fruta";
           produtos1.Estoque = 30;

           Console.WriteLine($"Produto 1 Còdigo {produtos1.Codigo},nome {produtos1.Nome},Descrição{produtos1.Descricao},Estoque{produtos1.Estoque}");

            Produtos produtos2 = new  Produtos();
            produtos2.Nome = "Suco de goiaba";
            Console.WriteLine($"Codigo inserido {produtos2.Codigo},nome{produtos2.Nome}");

            Produtos produtos3 = new Produtos(1,"Traquinas","Bolacha de chocolate",1809);

            Console.WriteLine($"Codigo{produtos3.Codigo},nome {produtos3.Nome},Descriçao {produtos3.Descricao},Estoque {produtos3.Estoque}");

        }
    }
}
