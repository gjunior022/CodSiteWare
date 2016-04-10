using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LojaVirtual.Models;

namespace LojaVirtual.Controllers
{
    public class PromocoesController : LojaVirtual.Const.MasterController
    {
        private LojaVirtualEntities db = new LojaVirtualEntities();
        
        // GET: Promocoes
        public ActionResult Index()
        {
            return View(db.Promocao.ToList());
        }

        public ActionResult AdicionarNoCarinho(int? codProduto, int? codPromocao)
        {
            if (codProduto == null || codPromocao == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KitPromocao kit = db.KitPromocao.Where(x => x.codProduto == codProduto && x.codPromocao == codPromocao).FirstOrDefault();
            if (kit == null)
            {
                return HttpNotFound();
            }

            AddPromocaoCarrinho(kit);
            return RedirectToAction("Carrinho", "Home");
        }

        public ActionResult KitsPromocoes()
        {
            return View(db.ObterPromocoes().AsEnumerable());
        }

        // GET: Promocoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promocao promocao = db.Promocao.Find(id);
            if (promocao == null)
            {
                return HttpNotFound();
            }
            return View(promocao);
        }

        // GET: Promocoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Promocoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codPromocao,nomePromocao,quantidade,preco")] Promocao promocao)
        {
            if (ModelState.IsValid)
            {
                db.Promocao.Add(promocao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(promocao);
        }

        // GET: Promocoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promocao promocao = db.Promocao.Find(id);
            if (promocao == null)
            {
                return HttpNotFound();
            }
            return View(promocao);
        }

        // POST: Promocoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codPromocao,nomePromocao,quantidade,preco")] Promocao promocao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(promocao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(promocao);
        }

        // GET: Promocoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promocao promocao = db.Promocao.Find(id);
            if (promocao == null)
            {
                return HttpNotFound();
            }
            return View(promocao);
        }

        // POST: Promocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Promocao promocao = db.Promocao.Find(id);
            db.Promocao.Remove(promocao);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
