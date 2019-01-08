using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;

namespace Ia_ComandaRestaurante.Controllers
{
   
    public class MenuController : Controller
    {

        private static string itens = "[{\"Nome\":\"Sanduiche de peito de frango grelhado\",\"Tipo\":\"Comida\",\"Descricao\":\"Sanduiche empacotado de proteínas!\",\"Preco\":5,\"Img\":\"/images/Chicken-sandwich.jpg\"},{\"Nome\":\"Nachos\",\"Tipo\":\"Comida\",\"Descricao\":\"Aproveite o melhor da cultura Mexicana com os nossos pratos!\",\"Preco\":5,\"Img\":\"/images/Nachos.jpg\"},{\"Nome\":\"Taco\",\"Tipo\":\"Comida\",\"Descricao\":\"Aquele taco que você respeita.\",\"Preco\":4.5,\"Img\":\"/images/Taco.jpg\"},{\"Nome\":\"Pizza\",\"Tipo\":\"Comida\",\"Descricao\":\"A famosa pizza, top 5 das refeições a lá PoberAgi.\",\"Preco\":8,\"Img\":\"/images/Pizza.jpg\"},{\"Nome\":\"Refrigerante\",\"Tipo\":\"Bebida\",\"Descricao\":\"O rémedio preto favorito das crian\uFFFDas.\",\"Preco\":4.5,\"Img\":\"/images/Refrigerante.jpg\"},{\"Nome\":\"Cerveja\",\"Tipo\":\"Bebida\",\"Descricao\":\"Gelada ao seu gosto.\",\"Preco\":4,\"Img\":\"/images/Cerveja.jpg\"},{\"Nome\":\"Porção de carne\",\"Tipo\":\"Comida\",\"Descricao\":\"Carne assada na hora.\",\"Preco\":7,\"Img\":\"/images/Carne.jpg\"}]";

        static List<Menu> casos = JsonConvert.DeserializeObject <List<Menu>>(itens);

        //OBTENDO QUANTIDADE DE CASOS
        float size = casos.Count;
        

    public IActionResult Index()
        {
            List<Menu> list = new List<Menu>();
            list.Add(new Menu { Nome = "Champagne", Tipo = "Bebida", Descricao="Delicioso vinho branco, produzido na França",Preco = 15.25f,Img="/images/Champagne.jpg"});
            for (int i = 0; i < size; i++)
            {
                list.Add(item: new Menu { Nome = casos[i].Nome, Tipo = casos[i].Tipo, Descricao = casos[i].Descricao, Preco = casos[i].Preco, Img = casos[i].Img});
                
            }

            return View(list);
        }
    }
}