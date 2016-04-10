using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaVirtual.ViewModel;
using LojaVirtual.Models;

namespace LojaVirtual.Const
{
    public class MasterController : Controller
    {
        public const string SESSAO_CARRINHO = "chartSession";

        public List<ProdutoViewModel> listaCarrinhoAtual
        {
            get
            {
                return (List<ProdutoViewModel>)Session[SESSAO_CARRINHO];
            }
            set
            {
                Session[SESSAO_CARRINHO] = value;
            }
        }

        protected override void OnActionExecuting(
        ActionExecutingContext filterContext)
        {
            if (Session[SESSAO_CARRINHO] == null)
            {
                Session[SESSAO_CARRINHO] = new List<ProdutoViewModel>();
            }
            base.OnActionExecuting(filterContext); // re-added in edit
        }

        public MasterController()
        {

        }

        public void AddProdutoCarrinho(Produto p)
        {
            ProdutoViewModel novoItem = new ProdutoViewModel();
            novoItem.nomeProduto = p.nomeProduto;
            novoItem.preco = p.preco;
            novoItem.quantidade = 1;
            novoItem.nomePromocao = "N/A";

            listaCarrinhoAtual.Add(novoItem);
        }

        public void AddPromocaoCarrinho(KitPromocao kit)
        {
            ProdutoViewModel novoItem = new ProdutoViewModel();
            novoItem.nomeProduto = "Kit " + kit.Produto.nomeProduto;
            novoItem.preco = kit.Promocao.preco;
            novoItem.quantidade = kit.Promocao.quantidade;
            novoItem.nomePromocao = kit.Promocao.nomePromocao;

            listaCarrinhoAtual.Add(novoItem);
        }
    }
}