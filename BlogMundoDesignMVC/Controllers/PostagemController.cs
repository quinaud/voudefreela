using BlogMundoDesignMVC.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace BlogMundoDesignMVC.Controllers
{
    public class PostagemController : Controller
    {
       

        // GET: Postagem
        public ActionResult Index()
        {
            var wc = new WebClient();
            var json = wc.DownloadString("https://blogmundodesign.firebaseio.com/postagens.json");
            var lista = JsonConvert.DeserializeObject<IDictionary<string, Postagem>>(json);

            ViewBag.ListaPostagem = lista;

            return View();
        }

        // GET: Postagem/Details/5
        public ActionResult Details(string idPostagem)
        {

            var wc = new WebClient();
            var json = wc.DownloadString("https://blogmundodesign.firebaseio.com/postagens.json");
            var lista = JsonConvert.DeserializeObject<IDictionary<string, Postagem>>(json);

            var postagem = new Postagem();

            foreach (var item in lista)
            {
                if (item.Key == idPostagem)
                {


                    postagem.ConteudoPrimeiroNivelPostagem = item.Value.ConteudoPrimeiroNivelPostagem;
                    postagem.ConteudoSegundoNivelPostagem = item.Value.ConteudoSegundoNivelPostagem;
                    postagem.DataPostagem = item.Value.DataPostagem;
                    postagem.NomeAutor = item.Value.NomeAutor;
                    postagem.SubtituloPostagem = item.Value.SubtituloPostagem;
                    postagem.TituloMeioPostagem = item.Value.TituloMeioPostagem;
                    postagem.TituloPostagem = item.Value.TituloPostagem;
                    postagem.ImagemPostBase64 = item.Value.ImagemPostBase64;
                    postagem.FotoAutor = item.Value.FotoAutor;

                }
            }


            return View(postagem);
        }

        public ActionResult NovaPostagem()
        {
            return View();
        }

        // GET: Postagem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Postagem/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Postagem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Postagem/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Postagem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Postagem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
