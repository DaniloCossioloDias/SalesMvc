using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class ProdutosController : Controller
    {
        private static List<Produto> produtos = new List<Produto>();

        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            produto.Id = produtos.Count + 1;
            produtos.Add(produto);
            return RedirectToAction("Index");
        }
    }
}
