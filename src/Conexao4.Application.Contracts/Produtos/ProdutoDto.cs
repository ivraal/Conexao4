using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Conexao4.Produtos
{
    public class ProdutoDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(128)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public float Preco { get; set; }
    }
}
