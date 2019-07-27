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
                    var produtos = new List<Produto>(){
                        new Produto(){Nome = "Picanha", Tipo = "Alimentação", Valor = 40.00M},
                        new Produto(){Nome = "Leite", Tipo = "Alimentação", Valor = 5.50M},
                        new Produto(){Nome = "Chocolate", Tipo = "Alimentação", Valor = 8.00M},
                        new Produto(){Nome = "Coca-cola", Tipo = "Bebidas", Valor = 6.50M},
                        new Produto(){Nome = "Relógio", Tipo = "Acessório", Valor = 200.99M},
                        new Produto(){Nome = "Tenis", Tipo = "Acessório", Valor = 250.00M},
                        new Produto(){Nome = "Água", Tipo = "Bebidas", Valor = 3.00M}
                    };

                ctx.Produtos.AddRange(produtos);
                ctx.SaveChanges();
            }
        }
    }
}
