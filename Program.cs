using PadroesDeProjeto.Comportamentais.Aula_1__Strategy;
using PadroesDeProjeto.Comportamentais.Aula_2__Template_Method;
using PadroesDeProjeto.Comportamentais.Aula_3___Observer;
using PadroesDeProjeto.Comportamentais.Aula_4__State;
using PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.BancoDoBrasil;
using PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.Caixa;
using PadroesDeProjeto.Estruturais.Aula_5___Adapter;
using PadroesDeProjeto.Estruturais.Aula_5___Adapter.Terceiros;
using PadroesDeProjeto.Estruturais.Aula_6___Decorator;
using PadroesDeProjeto.Estruturais.Aula_7___Facade;
using PadroesDeProjeto.Estruturais.Aula_7___Facade.Vendas;
using PagamentoCredito = PadroesDeProjeto.Comportamentais.Aula_2__Template_Method.PagamentoCredito;

//-------------------------------------------------------------//
//Template Method//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Template Method");
var gateway = new Gateway();

var pagamentoDinheiro = new PagamentoDinheiro(1000, gateway);
var pagamentoCartao = new PagamentoCartao(1000, gateway);
var pagamentoCredito = new PagamentoCredito(1000, gateway);

Console.WriteLine(pagamentoDinheiro.RealizarCobranca());
Console.WriteLine(pagamentoCartao.RealizarCobranca());
Console.WriteLine(pagamentoCredito.RealizarCobranca());

//-------------------------------------------------------------//
//Strategy//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Strategy");
var freteComum = new FreteComum();
var freteExpresso = new FreteExpresso();

var pedidoEletronicos = new PedidoEletronicos();
pedidoEletronicos.SetValorPedido(100);

//Cálculo do frete comum para pedido eletrônico.
pedidoEletronicos.SetTipoFrete(freteComum);
Console.WriteLine($"Eletrônicos com frete comum - R$:{pedidoEletronicos.CalcularValorFrete()}");

//Cálculo do frete expresso para pedido eletrônico.
pedidoEletronicos.SetTipoFrete(freteExpresso);
Console.WriteLine($"Eletrônicos com frete expresso - R$:{pedidoEletronicos.CalcularValorFrete()}");

var pedidoMoveis = new PedidoMoveis();
pedidoMoveis.SetValorPedido(100);

//Cálculo do frete comum para pedido móvel.
pedidoMoveis.SetTipoFrete(freteComum);
Console.WriteLine($"Móveis com frete comum - R$:{pedidoMoveis.CalcularValorFrete()}");

//Cálculo do frete expresso para pedido móvel.
pedidoMoveis.SetTipoFrete(freteExpresso);
Console.WriteLine($"Móveis com frete expresso - R$:{pedidoMoveis.CalcularValorFrete()}");

//-------------------------------------------------------------//
//Observer//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Observer");

var newsletter = new Newsletter();

var funcionario1 = new Funcionario("Funcionario1", "funcionario1@email.com", newsletter);
var funcionario2 = new Funcionario("Funcionario2", "funcionario2@email.com", newsletter);

var cliente = new Cliente("cliente", "cliente@email.com", newsletter);

var fornecedor = new Fornecedor("fornecedor", "forn@email.com", newsletter);

newsletter.AddMensagem("Primeira mensagem");
Console.WriteLine("##########\n\n");

newsletter.RemoveObserver(funcionario2);
newsletter.AddMensagem("Segunda mensagem");
Console.WriteLine("##########\n\n");

newsletter.RemoveObserver(funcionario1);
newsletter.AddMensagem("Terceira mensagem");

newsletter.RegisterObserver(funcionario1);
newsletter.AddMensagem("Quarta mensagem");

//-------------------------------------------------------------//
//State//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("State");

var pedidoState1 = new PedidoState();
pedidoState1.RealizarPagamento();
pedidoState1.CancelarPedido();

var pedidoState2 = new PedidoState();
pedidoState2.RealizarPagamento();
pedidoState2.DespacharPedido();

//var pedidoState3 = new PedidoState();
//pedidoState3.DespacharPedido(); comentado para evitar de lançar exceção

//-------------------------------------------------------------//
//Adapter//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Adapter");

//==== Classes dos fornecedores ====
//E uma instância da classe de TopPagamentos.
var topPagamentos = new TopPagamentos();
//==== Adapters ====
//Criação do adaptador de PagFacil.
var pagFacilAdapter = new PagFacilAdapter();
//Criação do adaptador de TopPagamentos.
var topPagamentosAdapter = new TopPagamentosAdapter(topPagamentos);

Console.WriteLine("Cobrança com PagFacil");
var cobranca = new Cobranca(pagFacilAdapter);

cobranca.SetValor(100);
cobranca.SetParcelas(3);
cobranca.SetNumeroCartao("123455678");
cobranca.SetCvv("123");
cobranca.RealizarPagamento();

Console.WriteLine("Cobrança com TopPagamentos");
cobranca.SetGateway(topPagamentosAdapter);

cobranca.SetValor(100);
cobranca.SetParcelas(3);
cobranca.SetNumeroCartao("123455678");
cobranca.SetCvv("123");
cobranca.RealizarPagamento();

//-------------------------------------------------------------//
//Decorator//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Decorator");

var pizzaCalabresa = new PizzaCalabresa();
var bordaRequeijao1 = new BordaRequeijao(pizzaCalabresa);
var massaIntegral1 = new MassaIntegral(bordaRequeijao1);
Console.WriteLine(massaIntegral1.GetDescricao());
Console.WriteLine(massaIntegral1.GetPreco());

var pizzaQueijo = new PizzaQueijo();
var massaIntegral2 = new MassaIntegral(pizzaQueijo);
Console.WriteLine(massaIntegral2.GetDescricao());
Console.WriteLine(massaIntegral2.GetPreco());

var pizzaFrango = new PizzaFrango();
var massa3 = new MassaIntegral(pizzaFrango);
var bordaRequeijao3 = new BordaRequeijao(massa3);

Console.WriteLine(bordaRequeijao3.GetDescricao());
Console.WriteLine(bordaRequeijao3.GetPreco());

//-------------------------------------------------------------//
//Facade//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Facade");

var consumidor = new Consumidor("Luis", "123456", "luis@email.com");

var produto1 = new Produto("Calça jeans", "Calça jeans masculina", 100.0m);
var produto2 = new Produto("Camiseta Preta", "Camiseta masculina preta", 75.0m);
var produto3 = new Produto("Blusa branca", "Blusa branca feminina", 40.90m);

var vendaFacade = new VendaFacade(consumidor);

vendaFacade.AddProduto(produto1);
vendaFacade.AddProduto(produto2);
vendaFacade.AddProduto(produto3);

vendaFacade.PedidoBoleto();

//-------------------------------------------------------------//
//Factory Method//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Factory Method");

var bancoCaixa = new BancoCaixa();
bancoCaixa.GerarBoleto(10, 100);
bancoCaixa.GerarBoleto(30, 100);
bancoCaixa.GerarBoleto(60, 100);

var bancoDoBrasil = new BancoDoBrasil();
bancoDoBrasil.GerarBoleto(10, 100);
bancoDoBrasil.GerarBoleto(30, 100);
bancoDoBrasil.GerarBoleto(60, 100);
