using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class Pedido
    {
        

        [Key]
        public int IdPedido { get; set; }
        public string PrazoDoPedido { get; set; }
        public Mesa MesaDoPedido { get; set; }
        public Funcionario FuncionarioResponsavel { get; set; }
        public float PrecoDoPedido { get; set; }
        public ICollection<Menu> ItensDoPedido { get; set; } = new List<Menu>();
        public EstadoDePedido Estado { get; set; }
        public ICollection<Menu> ItensCozinha { get; private set; }
        public ICollection<Menu> ItensCopa { get; private set; }
        public int SomaItensCozinha { get; set; }
        public int SomaItensCopa { get; set; }
        public string Observacoes { get; set; }

        public Pedido() { }

        public Pedido(Mesa mesaDoPedido, Funcionario funcionarioResponsavel)
        {
            MesaDoPedido = mesaDoPedido;
            FuncionarioResponsavel = funcionarioResponsavel;
            Estado = EstadoDePedido.ABERTO;
        }

        public void AdicionarItens(Menu menu)
        {
            ItensDoPedido.Add(menu);
            PrecoDoPedido += menu.Preco;

            if (menu.Tipo == "Bebida")
            {
                ItensCopa.Add(menu);
                SomaItensCopa++;
            }
            else
            {
                ItensCozinha.Add(menu);
                SomaItensCozinha++;
            }

        }
        public void AdicionarItens(Menu menu,string observacao)
        {
            ItensDoPedido.Add(menu);
            PrecoDoPedido += menu.Preco;

            if (menu.Tipo == "Bebida")
            {
                SomaItensCopa++;
            }
            else
            {
                SomaItensCozinha++;
            }
            Observacoes = observacao;
        }
        public void AdicionarItens(Menu menu, Menu menu2, Menu menu3)
        {
            ItensDoPedido.Add(menu);
            PrecoDoPedido += menu.Preco; PrecoDoPedido += menu2.Preco; PrecoDoPedido += menu3.Preco;
        }
        public void RemoverItens(Menu menu)
        {
            if (PrecoDoPedido >= menu.Preco)
            {
                PrecoDoPedido -= menu.Preco;
            } else
            {
                return;
            }
            ItensDoPedido.Remove(menu);
        }
        public void RemoverItens(Menu menu, Menu menu2, Menu menu3)
        {
            if (PrecoDoPedido >= menu.Preco && PrecoDoPedido >= menu2.Preco && PrecoDoPedido >= menu3.Preco)
            {
                PrecoDoPedido -= menu.Preco;
            }
            else
            {
                return;
            }
            ItensDoPedido.Remove(menu);
        }


    }
    
}
