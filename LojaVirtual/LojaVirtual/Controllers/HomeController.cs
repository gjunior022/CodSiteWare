using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaVirtual.Models;
using LojaVirtual.ViewModel;

namespace LojaVirtual.Controllers
{
    public class HomeController : LojaVirtual.Const.MasterController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Carrinho()
        {
            List<ProdutoViewModel> carrinho = new List<ProdutoViewModel>();
            if (Session[SESSAO_CARRINHO] != null && listaCarrinhoAtual.Count > 0)
            {
                carrinho = listaCarrinhoAtual;
                ViewBag.total = carrinho.Sum(x => x.preco);
            }
            return View(carrinho.AsEnumerable());
        }
    }
}