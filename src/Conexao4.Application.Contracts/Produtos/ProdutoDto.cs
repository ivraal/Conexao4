using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Conexao4.Produtos
{
    public class ProdutoDto : AuditedEntityDto<int>
    {
        [Required]
        [StringLength(128)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public float Preco { get; set; }

        [StringLength(1024)]
        public string? Descricao { get; set; }

        [StringLength(512)]
        public string? UrlImagem { get; set; }
    }
}
