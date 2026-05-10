using Conexao4.Pedidos;
using Conexao4.Produtos;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;

namespace Conexao4;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AbpSolution1ProdutoToProdutoDtoMapper : MapperBase<Produto, ProdutoDto>
{
    public override partial ProdutoDto Map(Produto source);

    public override partial void Map(Produto source, ProdutoDto destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AbpSolution1CreateUpdateProdutoDtoToProdutoMapper : MapperBase<ProdutoDto, Produto>
{
    public override partial Produto Map(ProdutoDto source);

    public override partial void Map(ProdutoDto source, Produto destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AbpSolution1ItemPedidoToItemPedidoDtoMapper : MapperBase<ItemPedido, ItemPedidoDto>
{
    public override partial ItemPedidoDto Map(ItemPedido source);

    public override partial void Map(ItemPedido source, ItemPedidoDto destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AbpSolution1CreateUpdateItemPedidoDtoToItemPedidoMapper : MapperBase<ItemPedidoDto, ItemPedido>
{
    public override partial ItemPedido Map(ItemPedidoDto source);

    public override partial void Map(ItemPedidoDto source, ItemPedido destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AbpSolution1PedidoToPedidoDtoMapper : MapperBase<Pedido, PedidoDto>
{
    public override partial PedidoDto Map(Pedido source);

    public override partial void Map(Pedido source, PedidoDto destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AbpSolution1CreateUpdatePedidoDtoToPedidoMapper : MapperBase<PedidoDto, Pedido>
{
    public override partial Pedido Map(PedidoDto source);

    public override partial void Map(PedidoDto source, Pedido destination);
}

/*
 * You can add your own mappings here.
 * [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
 * public partial class Conexao4ApplicationMappers : MapperBase<ProdutoDto, CreateUpdateProdutoDto>
 * {
 *    public override partial CreateUpdateProdutoDto Map(ProdutoDto source);
 * 
 *    public override partial void Map(ProdutoDto source, CreateUpdateProdutoDto destination);
 * }
 */
