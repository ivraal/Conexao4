using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Conexao4.Produtos
{
    public class ProdutoDto : AuditedEntityDto<Guid>
    {
        public string Nome { get; set; } = string.Empty;

        public float Preco { get; set; }
    }
}
