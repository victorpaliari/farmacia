﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public class Cosmetico : Produto
    {
        private string? fragrancia;
        public Cosmetico(int numero, string nome, int tipo, decimal preco, string fragrancia) : base(numero, nome, tipo, preco)
        {
            this.fragrancia = fragrancia;
        }

        public string GetFragrancia()
        {
            return fragrancia;
        }
        public void SetFragrancia(string fragrancia)
        {
            this.fragrancia = fragrancia;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Nome da fragrância: {this.fragrancia} ");
        }
    }
}
