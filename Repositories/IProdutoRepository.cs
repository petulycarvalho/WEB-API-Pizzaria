using APIPizzaria.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIPizzaria.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> Get();
        Task<Produto> Get (int Id);
        Task<Produto> Create (Produto produto);
        Task Update (Produto produto);
        Task Delete (int Id);
    }
}
