using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Conexao4.Produtos
{
    public class ProdutoAppService :
        CrudAppService<
            Produto, //The Produto entity
            ProdutoDto, //Used to show Produtos
            Guid, //Primary key of the produto entity
            PagedAndSortedResultRequestDto //Used for paging/sorting
            >, //Used to create/update a produto
        IProdutoAppService //implement the IProdutoAppService
    {
        public ProdutoAppService(IRepository<Produto, Guid> repository)
            : base(repository)
        {

        }
    }
}
