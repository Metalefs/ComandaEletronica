
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }
        public string NomeDoFuncionario { get; set; }
        public string Cargo { get; set; }
        public string SenhaDeAcesso { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } 

        public Funcionario()
        {

        }

        public Funcionario(string nomeDoFuncionario, string cargo, string senhaDeAcesso)
        {
            NomeDoFuncionario = nomeDoFuncionario;
            Cargo = cargo;
            SenhaDeAcesso = senhaDeAcesso;
        }
        public void AdicionarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
            pedido.Estado = EstadoDePedido.ABERTO;
        }
        public void RemoverPedido(Pedido pedido)
        {
            Pedidos.Remove(pedido);
            pedido.Estado = EstadoDePedido.CANCELADO;
        }
        public void FecharPedido(Pedido pedido)
        {
            pedido.Estado = EstadoDePedido.CONCLUIDO;
        }
        
        public string CalcularTempoDeEntrega(Pedido pedido)
        {

            int QuantidadeDeMesas; 
            int QuantidadeDeClientes;
            int QuantidadePedidosCozinha;
            int QuantidadePedidosCopa;
            string ComplexidadeMediaDosPedidos;
            float PrecoTotal;
            int TempoDeEntrega = 0;
            string ARFFLocation;

            QuantidadeDeMesas = 100;
            QuantidadeDeClientes = Pedidos.Sum(ListaPedidos => ListaPedidos.MesaDoPedido.QuantidadeDePessoas);
            QuantidadePedidosCozinha = 40;
            QuantidadePedidosCopa = 20;
            ComplexidadeMediaDosPedidos = "baixa";
            TempoDeEntrega = 0; //DEFAULT
            PrecoTotal = 500;
            ARFFLocation = "http://eumotorista.portifoliotgm.esy.es/IA/TreinamentoRestaurante.arff";


            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = "~/bin/CalculaTempo.exe";

            //strCommandParameters are parameters to pass to program

            string args = string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", QuantidadeDeMesas, QuantidadeDeClientes, QuantidadePedidosCozinha, QuantidadePedidosCopa, ComplexidadeMediaDosPedidos, TempoDeEntrega, PrecoTotal, ARFFLocation);
            pProcess.StartInfo.Arguments = args;
            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Start the process
            pProcess.Start();

            //Get program output
            string strOutput = pProcess.StandardOutput.ReadToEnd();

            //Wait for process to finish
            pProcess.WaitForExit();


            return strOutput;


        }
    }
}
