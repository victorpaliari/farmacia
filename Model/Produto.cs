using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public abstract class Produto
    {
        public int numero = 0;
        public string nome;
        public int tipo = 0;
        public decimal preco = 0.0M;

        public Produto(int numero, string nome, int tipo, decimal preco)
        {
            this.numero = numero;
            this.nome = nome;
            this.tipo = tipo;
            this.preco = preco;
        }

        public int GetNumero()
        {
            return numero;
        }
        public void SetNumero(int numero)
        {
            this.numero = numero;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public int GetTipo()
        {
            return tipo;
        }
        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }
        public decimal GetPreco()
        {
            return preco;
        }
        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }
        public virtual void Visualizar()
        {
            string tipo = "";
            switch (this.tipo)
            {
                case 1: 
                    tipo = "Medicamento";
                    break;
                case 2:
                    tipo = "Cosmetico";
                    break;
                
            }
           
            Console.WriteLine("******************************************************");
            Console.WriteLine("Dados do produto");
            Console.WriteLine("******************************************************");
            Console.WriteLine($"Número do produto: {this.numero}");
            Console.WriteLine($"Nome do produto: {this.nome}");
            Console.WriteLine($"tipo do produto: {tipo}");
            Console.WriteLine($"Preço do produto: {this.preco.ToString("C")}");

        }


    }
}
