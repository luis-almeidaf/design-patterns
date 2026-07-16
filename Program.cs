using System.Diagnostics;
using PadroesDeProjeto.Comportamentais.Aula_1__Strategy;
using PadroesDeProjeto.Comportamentais.Aula_11___Chain_of_Responsibility;
using PadroesDeProjeto.Comportamentais.Aula_12___Iterator;
using PadroesDeProjeto.Comportamentais.Aula_13___Command;
using PadroesDeProjeto.Comportamentais.Aula_13___Command.Fabricante;
using PadroesDeProjeto.Comportamentais.Aula_17___Visitor;
using PadroesDeProjeto.Comportamentais.Aula_18___Memento;
using PadroesDeProjeto.Comportamentais.Aula_19___Mediator;
using PadroesDeProjeto.Comportamentais.Aula_2__Template_Method;
using PadroesDeProjeto.Comportamentais.Aula_3___Observer;
using PadroesDeProjeto.Comportamentais.Aula_4__State;
using PadroesDeProjeto.Criacionais.Aula_10___Builder;
using PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.BancoDoBrasil;
using PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.Caixa;
using PadroesDeProjeto.Criacionais.Aula_9___Abstract_Factory;
using PadroesDeProjeto.Criacionais.Aula_9___Abstract_Factory.BancoDoBrasil;
using PadroesDeProjeto.Criacionais.Aula_9___Abstract_Factory.Caixa;
using PadroesDeProjeto.Estruturais.Aula_14___Bridge;
using PadroesDeProjeto.Estruturais.Aula_15___Proxy;
using PadroesDeProjeto.Estruturais.Aula_16___Composite;
using PadroesDeProjeto.Estruturais.Aula_5___Adapter;
using PadroesDeProjeto.Estruturais.Aula_5___Adapter.Terceiros;
using PadroesDeProjeto.Estruturais.Aula_6___Decorator;
using PadroesDeProjeto.Estruturais.Aula_7___Facade;
using PadroesDeProjeto.Estruturais.Aula_7___Facade.Vendas;
using Email = PadroesDeProjeto.Estruturais.Aula_14___Bridge.Email;
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

//-------------------------------------------------------------//
//Abstract Factory//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Abstract Factory");

var banco = new Banco();

Console.WriteLine("Boleto Caixa");
var factoryCaixa = new CaixaCalculosFactory();
banco.GerarBoleto(100, factoryCaixa);

Console.WriteLine("Boleto BB");
var factoryBb = new BBCalculosFactory();
banco.GerarBoleto(100, factoryBb);

//-------------------------------------------------------------//
//Builder//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Builder");

Console.WriteLine("a4");
var builderA4 = new BuilderA4();
var director = new GeradorPdfDirector(builderA4);
director.CriarGeradorPdfNoHeaderNoHeader();
var pdf = builderA4.GetGeradorPdf();
Console.WriteLine(pdf);

Console.WriteLine("a3");
var builderA3 = new BuilderA3();
director.SetBuilderGeradorPdf(builderA3);
director.CriarGeradorPdfNoHeaderNoHeader();
pdf = builderA3.GetGeradorPdf();
Console.WriteLine(pdf);

//-------------------------------------------------------------//
//Chain of Responsability//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Chain of Responsibility");

var pedidoCor = new PedidoCoR();
var calculadoraDePontos = new CalculadoraDePontos();

pedidoCor.SetValor(21);
Console.WriteLine("Dia 15: " + calculadoraDePontos.CalcularPontosDoPedido(pedidoCor, 15));
Console.WriteLine("Dia 16: " + calculadoraDePontos.CalcularPontosDoPedido(pedidoCor, 16));

pedidoCor.SetValor(100);
Console.WriteLine("Dia 15: " + calculadoraDePontos.CalcularPontosDoPedido(pedidoCor, 15));
Console.WriteLine("Dia 16: " + calculadoraDePontos.CalcularPontosDoPedido(pedidoCor, 16));

//-------------------------------------------------------------//
//Iterator//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Iterator");

var lista = new Lista(9);
lista.AddItem(1);
lista.AddItem(2);
lista.AddItem(3);
lista.AddItem(4);
lista.AddItem(5);
lista.AddItem(6);
lista.AddItem(7);
lista.AddItem(8);
lista.AddItem(9);
lista.AddItem(10);

var matriz = new Matriz(3, 3);

matriz.AddItem(1);
matriz.AddItem(2);
matriz.AddItem(3);
matriz.AddItem(4);
matriz.AddItem(5);
matriz.AddItem(6);
matriz.AddItem(7);
matriz.AddItem(8);
matriz.AddItem(11);
matriz.AddItem(12);

Console.WriteLine("Elementos da lista");
ImpressoraDeAgregado.Iterar(lista);

Console.WriteLine("Elementos da matriz");
ImpressoraDeAgregado.Iterar(matriz);

//-------------------------------------------------------------//
//Command//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Command");

var lampadaSala = new Lampada("Lampada Sala", false);
var lampadaQuarto = new Lampada("Lampada Quarto", false);
var arCondicionado = new ArCondicionado("Ar Condicionado", false, 25);

var aplicativo = new Aplicativo();

var ligarLampadaSala = new LigarLampada(lampadaSala);
var desligarLampadaSala = new DesligarLampada(lampadaSala);

var ligarLampadaQuarto = new LigarLampada(lampadaQuarto);
var desligarLampadaQuarto = new DesligarLampada(lampadaQuarto);

var ligarAr = new LigarArCondicionado(arCondicionado);
var desligarAr = new DesligarArCondicionado(arCondicionado);
var mudarTemperatura = new MudarTemperaturaArCondicionado(arCondicionado);

var idLigarLampadaSala = aplicativo.SetComando(ligarLampadaSala);
var idDesligarLampadaSala = aplicativo.SetComando(desligarLampadaSala);

var idLigarLampadaQuarto = aplicativo.SetComando(ligarLampadaQuarto);
var idDesligarLampadaQuarto = aplicativo.SetComando(desligarLampadaQuarto);

var idLigarAr = aplicativo.SetComando(ligarAr);
var idDesligarAr = aplicativo.SetComando(desligarAr);

var idMudarTemperaturaAr = aplicativo.SetComando(mudarTemperatura);

aplicativo.AoPressionarBotao(idLigarLampadaSala);
aplicativo.AoPressionarBotao(idDesligarLampadaSala);

aplicativo.AoPressionarBotao(idLigarLampadaQuarto);
aplicativo.AoPressionarBotao(idDesligarLampadaQuarto);

aplicativo.AoPressionarBotao(idLigarAr);
//cast para o tipo certo, para poder chamar a função SetTemperatura
((MudarTemperaturaArCondicionado)aplicativo.GetComando(idMudarTemperaturaAr)).SetTemperatura(30);
aplicativo.AoPressionarBotao(idMudarTemperaturaAr);

aplicativo.AoPressionarBotao(idDesligarAr);

Console.WriteLine("Desfazer comandos");

aplicativo.DuploCliqueBotao(idDesligarAr);
aplicativo.DuploCliqueBotao(idMudarTemperaturaAr);
aplicativo.DuploCliqueBotao(idDesligarLampadaSala);
aplicativo.DuploCliqueBotao(idDesligarLampadaQuarto);

//-------------------------------------------------------------//
//Bridge//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Bridge");

var canalEnvioEmail = new Email();

var mensagemAdmin = new MensagemAdmin(canalEnvioEmail);
mensagemAdmin.SetAssunto("Primeira mensagem");
mensagemAdmin.SetMensagem("Olá usuário");
mensagemAdmin.Enviar();

var mensagemUsuario = new MensagemUsuario(canalEnvioEmail);
mensagemUsuario.SetAssunto("Primeira mensagem");
mensagemUsuario.SetMensagem("Olá administrador");
mensagemUsuario.Enviar();

var canalEnvioSms = new Sms();
mensagemAdmin = new MensagemAdmin(canalEnvioSms);
mensagemAdmin.SetAssunto("Segunda mensagem");
mensagemAdmin.SetMensagem("Olá Usuário");
mensagemAdmin.Enviar();

mensagemUsuario = new MensagemUsuario(canalEnvioSms);
mensagemUsuario.SetAssunto("Segunda mensagem");
mensagemUsuario.SetMensagem("Olá administrador");
mensagemUsuario.Enviar();


//-------------------------------------------------------------//
//Proxy//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Proxy");

var stopwatch = Stopwatch.StartNew();
var pessoaFisica = new Usuario("Luis Faria", "123456578", 33);
//Console.WriteLine(pessoaFisica.GetNome());
//Console.WriteLine(pessoaFisica.GetIdade());
//Console.WriteLine(pessoaFisica.VerificarMaioridade());
//Console.WriteLine(pessoaFisica.VerificarCpfAtivo());
stopwatch.Stop();
Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalMilliseconds} ms");

//-------------------------------------------------------------//
//Composite//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Composite");

var raiz = new Pasta("Raiz", "/");
var pasta1 = new Pasta("Pasta 1", "pasta1/");
var pasta2 = new Pasta("Pasta 2", "pasta2/");
var pasta2_1 = new Pasta("Pasta 2.1", "pasta2-1/");
var pasta3 = new Pasta("Pasta 3", "pasta3/");

raiz.Adicionar(pasta1);
raiz.Adicionar(pasta2);
raiz.Adicionar(pasta3);

pasta2.Adicionar(pasta2_1);

var arquivo1 = new Arquivo("Arquivo 1", "/arquivo1");
var arquivo2 = new Arquivo("Arquivo 2", "/arquivo2");
var arquivo3 = new Arquivo("Arquivo 3", "/arquivo3");
var arquivo4 = new Arquivo("Arquivo 4", "/arquivo4");
var arquivo5 = new Arquivo("Arquivo 5", "/arquivo5");
var arquivo6 = new Arquivo("Arquivo 6", "/arquivo6");
var arquivo7 = new Arquivo("Arquivo 7", "/arquivo7");


pasta1.Adicionar(arquivo1);
pasta1.Adicionar(arquivo2);
pasta2.Adicionar(arquivo3);
pasta2.Adicionar(arquivo4);
pasta2_1.Adicionar(arquivo5);
pasta2_1.Adicionar(arquivo7);
pasta3.Adicionar(arquivo6);

var gerenciador = new GerenciadorDeArquivos(raiz);

gerenciador.ExibirTodos();

//-------------------------------------------------------------//
//Visitor//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Visitor");

var supermercado = new SuperMercado("Supermercado 1");

var departamento1 = new Departamento("Alimentação básica");
var arroz = new ProdutoVisitor("Arroz 5kg", 18, 30);
var macarrao = new ProdutoVisitor("Macarrao", 3.20m, 15);

departamento1.AddProduto(arroz);
departamento1.AddProduto(macarrao);

var departamento2 = new Departamento("Higiene");
var papelHigienico = new ProdutoVisitor("Papel Higienico", 11, 35);
var sabonete = new ProdutoVisitor("Sabonete", 1.20m, 10);

departamento2.AddProduto(papelHigienico);
departamento2.AddProduto(sabonete);

supermercado.AddDepartamento(departamento1);
supermercado.AddDepartamento(departamento2);

var lucratividade = new Lucratividade();

var lucratividadeSupermercado = supermercado.Aceitar(lucratividade);
Console.WriteLine("Lucratividade supermercado R$: " + lucratividadeSupermercado);

var lucratividadeDepartamento1 = departamento1.Aceitar(lucratividade);
Console.WriteLine("Lucratividade departamento1 R$: " + lucratividadeDepartamento1);

var lucratividadeArroz = arroz.Aceitar(lucratividade);
Console.WriteLine("Lucratividade arroz R$: " + lucratividadeArroz);

var lucratividadeMacarrao = macarrao.Aceitar(lucratividade);
Console.WriteLine("Lucratividade macarrao R$: " + lucratividadeMacarrao);

var lucratividadeDepartamento2 = departamento2.Aceitar(lucratividade);
Console.WriteLine("Lucratividade departamento1 R$: " + lucratividadeDepartamento2);

var lucratividadePapelHigienico = papelHigienico.Aceitar(lucratividade);
Console.WriteLine("Lucratividade arroz R$: " + lucratividadePapelHigienico);

var lucratividadeSabonete = sabonete.Aceitar(lucratividade);
Console.WriteLine("Lucratividade arroz R$: " + lucratividadeSabonete);


//-------------------------------------------------------------//
//Memento//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Memento");

var textBox = new TextBox(20, 100);

var historico = new Historico();

textBox.Text = "Text 1";
textBox.FontWeight = "bold";
textBox.FontFamily = "Cursive";
textBox.FontSize = 25;

historico.CriarCheckPoint(textBox);

textBox.Text = "Text 2";
textBox.FontWeight = "normal";
textBox.FontFamily = "monospace";
textBox.FontSize = 15;
textBox.X = 40;
textBox.Y = 120;

historico.CriarCheckPoint(textBox);

textBox.Text = "Text 3";
textBox.FontWeight = "normal";
textBox.FontFamily = "fantasy";
textBox.FontSize = 12;
textBox.X = 60;
textBox.Y = 120;

textBox.Imprimir();
historico.Desfazer();

textBox.Imprimir();
historico.Desfazer();

textBox.Imprimir();


//-------------------------------------------------------------//
//Mediator//
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Mediator");

var chatBot1 = new ChatBot();
var salaDeChat1 = new SalaDeChatMediator(chatBot1, "Sala de chat 1");

var chatBot2 = new ChatBot();
var salaDeChat2 = new SalaDeChatMediator(chatBot2, "Sala de chat 2");

var joao = new Humano("João");
var pedro = new Humano("Pedro");
var paulo = new Humano("Paulo");
var maria = new Humano("Maria");

joao.SetMediator(salaDeChat1);
pedro.SetMediator(salaDeChat1);

paulo.SetMediator(salaDeChat2);
maria.SetMediator(salaDeChat2);

joao.Enviar("Olá pessoa da sala 1");
pedro.Enviar("Olá Joao, tudo bem?");
joao.Enviar("Tudo certo.");
joao.Enviar("E com você?");

joao.SetMediator(salaDeChat2);
paulo.Enviar("Alguem por ai?");
paulo.Enviar("Como estão?");
maria.Enviar("Olá");