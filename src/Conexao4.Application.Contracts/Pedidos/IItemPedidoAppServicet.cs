using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Conexao4.Pedidos;

public interface IItemPedidoAppService :
    ICrudAppService< //Defines CRUD methods
        ItemPedidoDto, //Used to show Produtos
        int, //Primary key of the Produto entity
        PagedAndSortedResultRequestDto> //Used for paging/sorting
{
    Task AdicionarAoCarrinhoAsync(int produtoId);
    Task FinalizarCarrinhoAsync();
}
