using Blazorise;
using Conexao4.Pedidos;
using Conexao4.Produtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.BlazoriseUI;
using Volo.Abp.Users;
using static Volo.Abp.PermissionManagement.Blazor.Components.ResourcePermissionManagementModal;

namespace Conexao4.Blazor.Components.Pages;

public partial class Index
{
    [Inject]
    protected ICurrentUser CurrentUser { get; set; } = default!;

    [Inject]
    protected NavigationManager Navigation { get; set; } = default!;

    [Inject]
    protected IProdutoAppService ProdutoAppService { get; set; } = default!;

    [Inject]
    protected IItemPedidoAppService ItemPedidoAppService { get; set; } = default!;

    protected Modal CarrinhoModal { get; set; }

    List<ProdutoDto> lProduto = new List<ProdutoDto>();
    List<ItemPedidoDto> lItemPedido = new List<ItemPedidoDto>();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var prdProduto = await ProdutoAppService.GetListAsync(new PagedAndSortedResultRequestDto { MaxResultCount = 1000 });
            lProduto = prdProduto.Items.ToList();

            await AtualizarCarrinhoAsync();

            await InvokeAsync(StateHasChanged);
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task AdicionarAoCarrinhoAsync(int produtoId)
    {
        await ItemPedidoAppService.AdicionarAoCarrinhoAsync(produtoId);
        await AtualizarCarrinhoAsync();
    }

    private async Task RemoverDoCarrinhoAsync(int itemPedidoId)
    {
        await ItemPedidoAppService.DeleteAsync(itemPedidoId);
        await AtualizarCarrinhoAsync();
    }

    private async Task AtualizarCarrinhoAsync()
    {
        if (!CurrentUser.IsAuthenticated)
            return;

        var prdItemPedido = await ItemPedidoAppService.GetListAsync(new PagedAndSortedResultRequestDto { MaxResultCount = 1000 });
        lItemPedido = prdItemPedido.Items.ToList();

        await InvokeAsync(StateHasChanged);
    }

    protected override void Dispose(bool disposing)
    {
        PageLayout.ShowToolbar = true;
    }

    protected virtual async Task OpenCarrinhoAsync()
    {
        try
        {
            // Mapper will not notify Blazor that binded values are changed
            // so we need to notify it manually by calling StateHasChanged
            await InvokeAsync(async () =>
            {
                StateHasChanged();
                if (CarrinhoModal != null)
                {
                    await CarrinhoModal.Show();
                }

            });
        }
        catch (Exception ex)
        {
            await HandleErrorAsync(ex);
        }
    }

    protected virtual async Task CloseCarrinhoModalAsync()
    {
        await CarrinhoModal.Hide();
    }
}
