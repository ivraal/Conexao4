using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Conexao4.Produtos
{
    public class Produto : AuditedAggregateRoot<int>
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public string? UrlImagem { get; set; }
        public float Preco { get; set; }
    }
}
