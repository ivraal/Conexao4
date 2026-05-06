using Conexao4.Produtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Conexao4
{
   public class ProdutoStoreDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Produto, Guid> _produtoRepository;

    public ProdutoStoreDataSeederContributor(IRepository<Produto, Guid> produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _produtoRepository.GetCountAsync() <= 0)
        {
            await _produtoRepository.InsertAsync(
                new Produto
                {
                    Nome = "Café",
                    Preco = 19.84f
                },
                autoSave: true
            );

            await _produtoRepository.InsertAsync(
                new Produto
                {
                    Nome = "Chocolate",
                    Preco = 15.0f
                },
                autoSave: true
            );
        }
    }
}
}
