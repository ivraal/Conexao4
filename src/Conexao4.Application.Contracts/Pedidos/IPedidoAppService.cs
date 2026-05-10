using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Conexao4.Pedidos
{
    public interface IPedidoAppService :
        ICrudAppService< //Defines CRUD methods
            PedidoDto, //Used to show Produtos
            int, //Primary key of the Produto entity
            PagedAndSortedResultRequestDto> //Used for paging/sorting
    {

    }
}
