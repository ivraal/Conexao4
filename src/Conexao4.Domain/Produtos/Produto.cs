using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Conexao4.Produtos
{
    public class Produto : AuditedAggregateRoot<Guid>
    {
        public string Nome { get; set; } = string.Empty;
        public int CodProduto { get; set; }
        public float Preco { get; set; }
    }
}
