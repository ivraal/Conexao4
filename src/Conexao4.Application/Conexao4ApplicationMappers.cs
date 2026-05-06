using Conexao4.Produtos;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;

namespace Conexao4;

[Mapper]
public partial class ProdutoToProdutoDtoMapper : MapperBase<Produto, ProdutoDto>
{
    public override partial ProdutoDto Map(Produto source);

    public override partial void Map(Produto source, ProdutoDto destination);
}

/*
 * You can add your own mappings here.
 * [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
 * public partial class Conexao4ApplicationMappers : MapperBase<BookDto, CreateUpdateBookDto>
 * {
 *    public override partial CreateUpdateBookDto Map(BookDto source);
 * 
 *    public override partial void Map(BookDto source, CreateUpdateBookDto destination);
 * }
 */
