using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Conexao4.Produtos
{
    public interface IProdutoAppService :
        ICrudAppService< //Defines CRUD methods
            ProdutoDto, //Used to show Produtos
            Guid, //Primary key of the Produto entity
            PagedAndSortedResultRequestDto //Used for paging/sorting
            > //Used to create/update a Produto
    {

    }

}
