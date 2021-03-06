﻿using firstStore.UI.Data;
using firstStore.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace firstStore.UI.Controllers
{
    [Authorize]
    public class ProdutosController:Controller
    {

        private readonly FirstStoreDataContext _ctx;

        public ProdutosController(FirstStoreDataContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var model = _ctx.Produtos.Include(p=>p.Tipo).ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            var tipos = _ctx.TipoProdutos.ToList()
                .Select(t=>new SelectListItem{ Value = t.Id.ToString(), Text = t.Nome });
            ViewBag.Tipos = tipos;

            var model = new Produto();
            if (id != null)
            {
               model = _ctx.Produtos.Find(id);
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(Produto model)
        {
            if (ModelState.IsValid)
            {
                if(model.Id != null)
                {
                    _ctx.Update(model);
                    _ctx.SaveChanges();

                    return RedirectToAction("Index");

                }

                _ctx.Produtos.Add(model);
                _ctx.SaveChanges();

                return RedirectToAction("Index");

            }
            var tipos = _ctx.TipoProdutos.ToList()
                .Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Nome });
            ViewBag.Tipos = tipos;
            return View(model);

            
        }

        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            var produto = _ctx.Produtos.Find(id);

            if(produto == null)
                return NotFound();

            _ctx.Produtos.Remove(produto);
            _ctx.SaveChanges();

            return NoContent();
        }
    }
}
