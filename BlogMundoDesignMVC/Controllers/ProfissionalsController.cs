using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogMundoDesignMVC.Contexto;
using BlogMundoDesignMVC.Models;

namespace BlogMundoDesignMVC.Controllers
{
    public class ProfissionalsController : Controller
    {
        private Contexto.Contexto db = new Contexto.Contexto();

        // GET: Profissionals
        public ActionResult Index()
        {
            return View(db.Profissionais.ToList());
        }

        // GET: Profissionals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profissional profissional = db.Profissionais.Find(id);
            if (profissional == null)
            {
                return HttpNotFound();
            }
            return View(profissional);
        }

        // GET: Profissionals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profissionals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Profissional profissional)
        {
            if (ModelState.IsValid)
            {
                db.Profissionais.Add(profissional);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profissional);
        }

        // GET: Profissionals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profissional profissional = db.Profissionais.Find(id);
            if (profissional == null)
            {
                return HttpNotFound();
            }
            return View(profissional);
        }

        // POST: Profissionals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Sobrenome,Idade,Sexo,Logradouro,Bairro,Cidade,Estado,PossuiExperiencia,TipoExperiencia,LocalExperiencia,EfetuouPagamento")] Profissional profissional)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profissional).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profissional);
        }

        // GET: Profissionals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profissional profissional = db.Profissionais.Find(id);
            if (profissional == null)
            {
                return HttpNotFound();
            }
            return View(profissional);
        }

        // POST: Profissionals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profissional profissional = db.Profissionais.Find(id);
            db.Profissionais.Remove(profissional);
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
