using firstStore.UI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace firstStore.UI.Controllers
{
    public class ProdutosController:Controller
    {

        private readonly FirstStoreDataContext _ctx = new FirstStoreDataContext();
        public IActionResult Index()
        {

            var model = _ctx.Produtos.ToList();

            return View(model);
        }
    }
}
