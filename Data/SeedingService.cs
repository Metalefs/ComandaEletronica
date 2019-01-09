using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;
using Ia_ComandaRestaurante.Models.ViewModels.Enums;
using Newtonsoft.Json;

namespace Ia_ComandaRestaurante.Data
{
    public class SeedingService
    {
        private Ia_ComandaRestauranteContext _context;
        
        public SeedingService(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.Funcionario.Any() ||
                    _context.Menu.Any() ||
                    _context.Pedido.Any() ||
                    _context.Mesa.Any())
            {
                return; // O Banco de dados Já foi populado
            } 
            //FUNCIONARIOS
            Funcionario f1 = new Funcionario("Guilherme", "Copeiro", "senha123");
            Funcionario f2 = new Funcionario("Jackson", "Garçom", "MeDev");

            //____________________________________________________________________________________
            //ITENS DO CARDAPIO
            string cardapioJson;
            WebClient client = new WebClient();
            cardapioJson = client.DownloadString("http://eumotorista.portifoliotgm.esy.es/IA/cardapioJSON.txt");
            
            List<Menu> ListaCardapio = JsonConvert.DeserializeObject<List<Menu>>(cardapioJson);
            
            Menu Sanduiche = new Menu("Sanduiche de peito de frango grelhado", "Comida", 4.0f, "Sanduiche empacotado de proteínas!", "~wwwroot//images//Chicken-sandwich.jpg","baixa");
            Menu Nachos = new Menu(ListaCardapio[1].Nome, ListaCardapio[1].Tipo, ListaCardapio[1].Preco, ListaCardapio[1].Descricao, ListaCardapio[1].Img, ListaCardapio[1].Complexidade);
            Menu Tacos = new Menu(ListaCardapio[2].Nome, ListaCardapio[2].Tipo, ListaCardapio[2].Preco, ListaCardapio[2].Descricao, ListaCardapio[2].Img, ListaCardapio[2].Complexidade);
            Menu Pizza = new Menu(ListaCardapio[3].Nome, ListaCardapio[3].Tipo, ListaCardapio[3].Preco, ListaCardapio[3].Descricao, ListaCardapio[3].Img, ListaCardapio[3].Complexidade);
            Menu Refrigerante = new Menu(ListaCardapio[4].Nome, ListaCardapio[4].Tipo, ListaCardapio[4].Preco, ListaCardapio[4].Descricao, ListaCardapio[4].Img, ListaCardapio[4].Complexidade);
            Menu Cerveja = new Menu(ListaCardapio[5].Nome, ListaCardapio[5].Tipo, ListaCardapio[5].Preco, ListaCardapio[5].Descricao, ListaCardapio[5].Img, ListaCardapio[5].Complexidade);
            Menu CarneAssada = new Menu(ListaCardapio[6].Nome, ListaCardapio[6].Tipo, ListaCardapio[6].Preco, ListaCardapio[6].Descricao, ListaCardapio[6].Img, ListaCardapio[6].Complexidade);
            //____________________________________________________________________________________
            //MESAS
            Mesa mesa1 = new Mesa("Raquel Angelica", 10, 4);
            Mesa mesa2 = new Mesa("Joel Santana", 5, 6);
            Mesa mesa3 = new Mesa("Gustavo Henrique", 7, 10);
            //____________________________________________________________________________________
            //PEDIDOS
            Pedido p1 = new Pedido(mesa1, f1);
            Pedido p2 = new Pedido(mesa2, f2);
            Pedido p3 = new Pedido(mesa3, f2);

            p1.AdicionarItens(Sanduiche);
            p2.AdicionarItens(Cerveja);
            p3.AdicionarItens(Pizza);
            //____________________________________________________________________________________
            //TEMPOS DE ENTREGA
            List<Pedido> pedidos2 = new List<Pedido>()
            {
                p1,
                p2,
                p3
            };
            CalculoDeTempoDeEntrega c1 = new CalculoDeTempoDeEntrega();
            int i = 0;
            foreach (Pedido pedido in pedidos2) {
                pedidos2.ElementAt(i).PrazoDoPedido = c1.CalcularTempo(pedidos2);
                i++;
            }
            //____________________________________________________________________________________
            //COPA

            
            List<Pedido> PedidosCopa = new List<Pedido>();
            i = 0;
            foreach(Pedido pedido in pedidos2)
            {
                if(pedidos2.ElementAt(i).TipoDoPedido == "Bebida")
                {
                    PedidosCopa.Add(pedidos2.ElementAt(i));
                }
                i++;
            }
            int x = 0;
            foreach(Pedido pedido in PedidosCopa)
            {
                _context.Add(PedidosCopa.ElementAt(x).AdicionarCopa((PedidosCopa.ElementAt(x).ItensDoPedido)));
                x++;
            }

            //____________________________________________________________________________________
            //COZINHA

            
            List<Pedido> PedidosCozinha = new List<Pedido>();
            i = 0;
            foreach (Pedido pedido in pedidos2)
            {
                if (pedidos2.ElementAt(i).TipoDoPedido == "Comida")
                {
                    PedidosCozinha.Add(pedidos2.ElementAt(i));
                }
                i++;
            }
            x = 0;
            foreach (Pedido pedido in PedidosCozinha)
            {
                _context.Add(PedidosCozinha.ElementAt(x).AdicionarCozinha((PedidosCozinha.ElementAt(x).ItensDoPedido)));
                x++;
            }


            //____________________________________________________________________________________
            //ADICIONANDO AO BANCO DE DADOS

            _context.Funcionario.AddRange(f1, f2);
            _context.Menu.AddRange(Sanduiche, Nachos, Tacos, Pizza, Refrigerante, Cerveja, CarneAssada);
            _context.Mesa.AddRange(mesa1, mesa2, mesa3);
            _context.Pedido.AddRange(p1, p2, p3);
            _context.SaveChanges();
        }
    }
}
