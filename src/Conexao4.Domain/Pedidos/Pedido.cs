using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Conexao4.Pedidos
{
    public class Pedido : AuditedAggregateRoot<int>
    {
        public Guid UserId { get; set; }
    }
}
