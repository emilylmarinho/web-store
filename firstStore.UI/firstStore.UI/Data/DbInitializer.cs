using firstStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstStore.UI.Data
{
    public class DbInitializer
    {

        public static void Init(FirstStoreDataContext ctx)
        {
            ctx.Database.EnsureCreated();

            if (!ctx.Produtos.Any())
            {


                var alimentacao = new TipoProduto() { Nome = "Alimentação" };
                var bebidas = new TipoProduto() { Nome = "Bebidas" };
                var acessorio = new TipoProduto() { Nome = "Acessórios" };

                var produtos = new List<Produto>(){
                        new Produto(){Nome = "Picanha", Tipo = alimentacao, Valor = 40.00M},
                        new Produto(){Nome = "Leite", Tipo = alimentacao, Valor = 5.50M},
                        new Produto(){Nome = "Chocolate", Tipo = alimentacao, Valor = 8.00M},
                        new Produto(){Nome = "Coca-cola", Tipo = bebidas, Valor = 6.50M},
                        new Produto(){Nome = "Relógio", Tipo = acessorio, Valor = 200.99M},
                        new Produto(){Nome = "Tenis", Tipo = acessorio, Valor = 250.00M},
                        new Produto(){Nome = "Água", Tipo = bebidas, Valor = 3.00M}
                    };

                ctx.Produtos.AddRange(produtos);
                ctx.SaveChanges();
            }
        }
    }
}
