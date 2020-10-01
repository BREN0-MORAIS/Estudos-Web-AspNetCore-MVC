﻿
using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using CaelumEstoque.Filtros;
using System.Collections.Generic;
using System.Web.Mvc;
namespace CaelumEstoque.Controllers
{
    [AutorizacaoFilter]
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/

        [Route("produtos", Name = "ListaProdutos")]
        public ActionResult Index()
        {
            object usuarioLogado = Session["usuarioLogado"];
            if (usuarioLogado != null)
            {
                ProdutosDAO dao = new ProdutosDAO();
                var produtos = dao.Lista();
                return View(produtos);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult Form()
        {
            ViewBag.Produto = new Produto();
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = dao.Lista();
            ViewBag.Categorias = categorias;
            return View(categorias);
        }

       [ValidateAntiForgeryToken, HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            int idDaInformatica = 1;
            if (produto.CategoriaId.Equals(idDaInformatica) && produto.Preco < 100)
            {
                ModelState.AddModelError("produto.InformaticaComPrecoInvalido", "Produtos da categoria informática devem ter preço maior do que 100");
            }
            if (ModelState.IsValid)
            {
                ProdutosDAO dao = new ProdutosDAO();
                dao.Adiciona(produto);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Produto = produto;
                CategoriasDAO categoriasDAO = new CategoriasDAO();
                ViewBag.Categorias = categoriasDAO.Lista();
                return View("Form");
            }
        }

        [Route("produtos/{id}", Name = "VisualizaProduto")]
        public ActionResult Visualiza(int id)
        {
            ProdutosDAO dao = new ProdutosDAO();
            Produto produto = dao.BuscaPorId(id);
            ViewBag.Produto = produto;
            return View();
        }

        public ActionResult DecrementaQtd(int id)
        {
            ProdutosDAO dao = new ProdutosDAO();
            Produto produto = dao.BuscaPorId(id);
            produto.Quantidade--;
            dao.Atualiza(produto);
            return Json(produto);
        }
    }
}