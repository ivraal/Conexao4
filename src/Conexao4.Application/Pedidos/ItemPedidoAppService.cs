using Conexao4.Produtos;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Conexao4.Pedidos;

public class ItemPedidoAppService :
    CrudAppService<
        ItemPedido, //The Book entity
        ItemPedidoDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto>, //Used to create/update a book
    IItemPedidoAppService //implement the IItemPedidoAppService
{
    protected readonly IProdutoAppService _produtoAppService;
    protected readonly IPedidoAppService _pedidoAppService;
    

    public ItemPedidoAppService(
        IRepository<ItemPedido, int> repository,
        IProdutoAppService produtoAppService,
        IPedidoAppService pedidoAppService)
        : base(repository)
    {
        _produtoAppService = produtoAppService;
        _pedidoAppService = pedidoAppService;
    }

    protected override async Task<IQueryable<ItemPedido>> CreateFilteredQueryAsync(PagedAndSortedResultRequestDto input)
    {
        var query = await base.CreateFilteredQueryAsync(input);

        query = query.Where(x => x.UserId == CurrentUser.Id!.Value);
        query = query.Where(x => x.PedidoId == null);

        return query;
    }

    public override async Task<PagedResultDto<ItemPedidoDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var l = await base.GetListAsync(input);

        foreach (var item in l.Items)
            item.Produto = await _produtoAppService.GetAsync(item.ProdutoId);

        return l;
    }

    public async Task AdicionarAoCarrinhoAsync(int produtoId)
    {
        var l = await base.GetListAsync(new PagedAndSortedResultRequestDto { MaxResultCount = 1000 });
        var e = l.Items.Where(x => x.ProdutoId == produtoId).FirstOrDefault();
        if (e != null)
        {
            e.Quantidade++;
            await UpdateAsync(e.Id, e);

            return;
        }

        await CreateAsync(new ItemPedidoDto
        {
            UserId = CurrentUser.Id!.Value,
            ProdutoId = produtoId,
            Quantidade = 1
        });

        return;
    }

    public async Task FinalizarCarrinhoAsync()
    {
        var pedido = await _pedidoAppService.CreateAsync(new PedidoDto { UserId = CurrentUser.Id!.Value });

        var l = await base.GetListAsync(new PagedAndSortedResultRequestDto { MaxResultCount = 1000 });
        foreach (var item in l.Items)
        {
            item.PedidoId = pedido.Id;
            await UpdateAsync(item.Id, item);
        }

        return;
    }
}
