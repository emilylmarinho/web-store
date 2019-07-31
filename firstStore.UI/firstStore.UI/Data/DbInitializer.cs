using firstStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using firstStore.UI.infra;
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
                        new Produto(){Nome = "Relógio", Tipo = acessorio, Valor = 200.99M},
                        new Produto(){Nome = "Tenis", Tipo = acessorio, Valor = 250.00M},
                        new Produto(){Nome = "Água", Tipo = bebidas, Valor = 3.00M}
                    };

                ctx.Produtos.AddRange(produtos);
                ctx.SaveChanges();
            }

            if (!ctx.Usuarios.Any())
            {
                ctx.Usuarios.AddRange(new List<Usuario>
                {
                    new Usuario(){Nome="Emily Marinho", Email="emily.lm@outlook.com", Senha="teste123".Encrypt()},
                    new Usuario(){Nome="Mario Silva", Email="teste@outlook.com", Senha="123".Encrypt()},
                    new Usuario(){Nome="Fabiano Nalin", Email="fabiano.nalin@gmail.com", Senha="123456".Encrypt()}
                });
                ctx.SaveChanges();
            }
        }
    }
}
