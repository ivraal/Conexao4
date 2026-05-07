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
