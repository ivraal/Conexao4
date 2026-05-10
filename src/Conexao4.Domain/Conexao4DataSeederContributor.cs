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
        private readonly IRepository<Produto, int> _produtoRepository;

        public ProdutoStoreDataSeederContributor(IRepository<Produto, int> produtoRepository)
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
                        Preco = 14.90f,
                        UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG"
                    },
                    autoSave: true
                );

                await _produtoRepository.InsertAsync(
                    new Produto
                    {
                        Nome = "Coxinha",
                        Preco = 8.90f,
                        UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/Coxinha_-_iguaria_brasileira_01.jpg/250px-Coxinha_-_iguaria_brasileira_01.jpg"
                    },
                    autoSave: true
                );

                await _produtoRepository.InsertAsync(
                    new Produto
                    {
                        Nome = "Chá",
                        Preco = 10.90f,
                        UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Cup_of_Earl_Gray.jpg/250px-Cup_of_Earl_Gray.jpg"
                    },
                    autoSave: true
                );

                await _produtoRepository.InsertAsync(
                    new Produto
                    {
                        Nome = "Cappuccino",
                        Preco = 18.00f,
                        UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Latte_art.jpg/250px-Latte_art.jpg"
                    },
                    autoSave: true
                );

                await _produtoRepository.InsertAsync(
                    new Produto
                    {
                        Nome = "Chocolate",
                        Preco = 15.0f,
                        UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/Hahndorf_Hot_Chocolate.jpg/250px-Hahndorf_Hot_Chocolate.jpg"
                    },
                    autoSave: true
                );
            }
        }
    }
}
