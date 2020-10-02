using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Models;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            //instancia os produtos daos 
            ProdutosDAO dao = new ProdutosDAO();

            //lista os produtos ara fazer o retorno da view em uma visualização html
            IList<Produto> produtos =  dao.Lista();

            //cria uma propriedade chamada produtos para poder fazer o retorno de uma lista e 
            //adiciona a lista na view bag que é possivel esta adicionando o produtos
            //que ira redirecionar para a a camada de visualização
            ViewBag.Produtos = produtos;
            return View();
        }
    }
}