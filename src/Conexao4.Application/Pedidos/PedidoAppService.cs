using Conexao4.Pedidos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Conexao4.Pedidos
{
    public class PedidoAppService :
        CrudAppService<
            Pedido, //The Pedido entity
            PedidoDto, //Used to show Pedidos
            int, //Primary key of the produto entity
            PagedAndSortedResultRequestDto //Used for paging/sorting
            >, //Used to create/update a produto
        IPedidoAppService //implement the IPedidoAppService
    {
        public PedidoAppService(IRepository<Pedido, int> repository)
            : base(repository)
        {

        }
    }
}
