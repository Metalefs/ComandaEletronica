using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace Ia_ComandaRestaurante.Models.ViewModels
{


    public class Pedido
    {
        private Ia_ComandaRestauranteContext _context;

        public Pedido(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }
        public Copa copa;
        public Cozinha cozinha;
        [Key]
        public int IdPedido { get; set; }
        public string PrazoDoPedido { get; set; }
        public Mesa MesaDoPedido { get; set; }
        public string TipoDoPedido { get; set; }

        private Funcionario funcionarioResponsavel;

        public Funcionario GetFuncionarioResponsavel()
        {
            return funcionarioResponsavel;
        }

        public void SetFuncionarioResponsavel(Funcionario value)
        {
            funcionarioResponsavel = value;
        }

        public float PrecoDoPedido { get; set; }
        public Menu ItensDoPedido { get; set; } 
        public EstadoDePedido Estado { get; set; }
        
        public string Observacoes { get; set; }
        

        public Pedido() { }

        public Pedido(Mesa mesaDoPedido, Funcionario funcionarioResponsavel)
        {
            MesaDoPedido = mesaDoPedido;
            SetFuncionarioResponsavel(funcionarioResponsavel);
            Estado = EstadoDePedido.ABERTO;
        }

        public void AdicionarItens(Menu menu)
        {
            ItensDoPedido = menu;
            PrecoDoPedido += menu.Preco;
            TipoDoPedido = menu.Tipo;

            if (TipoDoPedido == "Bebida")
            {
                AdicionarCopa(menu);
            }
            else
            {
                AdicionarCozinha(menu);
            }
            
        }
        public void AdicionarItens(Menu menu,string observacao)
        {
            ItensDoPedido = menu;
            //ItensDoPedido Itens2 = new ItensDoPedido(this,menu);
            PrecoDoPedido += menu.Preco;
            
            Observacoes = observacao;
            
            //_context.ItensDoPedido.AddRange(Itens2);
            
        }
        
        public Copa AdicionarCopa(Menu menu)
        {
           return new Copa(this, menu);
         
        }
        public Cozinha AdicionarCozinha(Menu menu)
        {
            return new Cozinha(this, menu);
            
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
            ItensDoPedido = null;
           
        }
        public List<Pedido> ListAll()
        {
            return _context.Pedido.ToList();
            
        }


    }
    
}
