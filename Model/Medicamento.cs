using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public class Medicamento : Produto
    {
        private string generico;

        public Medicamento(int numero, string nome, int tipo, decimal preco, string generico) : base(numero, nome, tipo, preco)
        {
            this.generico = generico;
        }
        public string GetGenerico()
        {
            return generico;
        }
        public void SetGenerico(string generico)
        {
            this.generico = generico;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Nome do genérico: {this.generico} ");
        }
    }
}
