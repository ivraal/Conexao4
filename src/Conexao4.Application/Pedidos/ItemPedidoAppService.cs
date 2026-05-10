using Conexao4.Produtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Conexao4.Pedidos;

public class ItemPedidoAppService :
    CrudAppService<
        Produto, //The Book entity
        ItemPedidoDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto>, //Used to create/update a book
    IItemPedidoAppService //implement the IItemPedidoAppService
{
    public ItemPedidoAppService(IRepository<Produto, int> repository)
        : base(repository)
    {

    }
}
