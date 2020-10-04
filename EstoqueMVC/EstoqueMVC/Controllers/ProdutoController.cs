
using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using CaelumEstoque.Filtros;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CaelumEstoque.Controllers
{
   // [AutorizacaoFilter]
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {

            //instancia o dao de  ProdutosDAO
            ProdutosDAO dao = new ProdutosDAO();

            //cria uma variavel Ilist e adiciona a lista do dao 
            IList<Produto> produtos = dao.Lista();

            //cria uma viewBag com atributo Produtos que recebe uma lista de produtos
            ViewBag.Produtos = produtos;

            //retorna a lista de produtos para a visuaiização de dados
            return View(produtos);
        }


        public ActionResult form()
        {
            //retorna uma lista para adicionar na view form no item combobox

            //instancia o DAO categoria
            CategoriasDAO categoriasDao = new CategoriasDAO();

            //cria um Ilist de categoria e adiciona em um atributo categoria,
            //cria uma lista de categoria e chama o metodo de lista 
            IList<CategoriaDoProduto> categorias = categoriasDao.Lista();

            //cria uma view bag com atributo categoria e adiciona a lista de categoria
            ViewBag.Categorias = categorias;

            //retorna a view bag, para poder chamar na visuaklzação
            return View();
        }

        //passa os dados do formularios para esse metodo que carrega todos os atributos do objeto
        public ActionResult Adiciona(Produto produto)
        {
            //instancia o dao 
            ProdutosDAO dao = new ProdutosDAO();

            //chama o metodo de adicionar o objeto 
            dao.Adiciona(produto);

            //retorna a view, para a camada de visualização
            return View();
        }
       
    }
}