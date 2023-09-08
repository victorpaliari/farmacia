using Farmacia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Repository
{
    public interface IProdutoRepository 
    {
        //Métodos Crud
        public void CriarProduto(Produto produto);
        public void ListarTodosProdutos();
        public void ConsultarProdutoPorNumero(int numero);
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int numero);

        //Método agregado
        public void MudarBackground();

    }
}
