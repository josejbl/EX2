using System;

namespace EX2.Classes.cs
{
    public class Produtos
    {
        // public int Codigo{get; set;}
        // public string Nome{get; set;}
        public int Codigo{get;set;}
        public string Nome{get;set;}
        public string Descricao{get;set;}
        public int Estoque{get;set;}

        public Produtos(){
            Console.WriteLine("Metodo contrutor foi executado");
        }
        
        public Produtos(int valor, string v)
        {
            Codigo = valor;
            Console.WriteLine($"Código insrido foi{Codigo}");
        }
        public Produtos(int codigo, string nome,string descricao,int Estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
        }

        // public Produtos(int valor, string v, object ) : this(valor)
        // {
        //     this.v = v;
        //     this. = ;
        // }
    }
}