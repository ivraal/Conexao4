using Conexao4.Produtos;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;

namespace Conexao4.Blazor;


[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AbpSolution1BlazorMappers : MapperBase<ProdutoDto, ProdutoDto>
{
    public override partial ProdutoDto Map(ProdutoDto source);

    public override partial void Map(ProdutoDto source, ProdutoDto destination);
}