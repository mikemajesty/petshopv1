﻿using Controller.Enum;
using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Enum.UI.ViewCliente;
using View.Enum.UI.ViewProduto;
using View.UI.ViewEstoque;

namespace View.Enum.UI.ViewCaixa
{
    public partial class frmCaixa : Form
    {
        frmMensagemEstoque mensagem = null;
        private List<Comanda> comandList = new List<Comanda>();
        private TipoPagamentoRepositorio _tipoPagamentoRepositorio;
        private VendaComComandaAtivaRepositorio _vendaComComandaAtivaRepositorio;
        private ProdutoRepositorio _produtoRepositorio;
        private VendaRepositorio _vendaRepositorio;
        private UsuarioRepositorio _usuarioRepositorio;
        private CaixaRepositorio _caixaRepositorio;
        private EstoqueRepositorio _estoqueRepositorio;
        private List<Estoque> estoqueList = new List<Estoque>();
        private ComandaRepositorio _comandaRepositorio;
        private FiadoRepositorio _fiadoRepositorio;
        private ClienteRepositorio _clienteRepositorio;
        private List<Comanda> comandaLista;
        private MovimentacaoCaixaRepositorio _movimentacaoCaixaRepositorio;
        private MovimentacaoProdutoRepositorio _movimentacaoProdutoRepositorio;
        private const bool Esconder = false, Mostrar = true, NaoExiste = false;
        private decimal VendaTotal;
        private const int Sucesso = 1, Insucesso = 0;

        public frmCaixa()
        {
            InitializeComponent();

        }
        private void InstanciarMovimentacaoProdutoRepositorio()
        {
            _movimentacaoProdutoRepositorio = new MovimentacaoProdutoRepositorio();
        }
        private void InstanciarMovimentacaoCaixa()
        {
            _movimentacaoCaixaRepositorio = new MovimentacaoCaixaRepositorio();
        }
        private void InstanciarClienteRepositorio()
        {
            _clienteRepositorio = new ClienteRepositorio();
        }
        private void InstanciarFiadoRepositorio()
        {
            _fiadoRepositorio = new FiadoRepositorio();
        }
        private void InstanciarEstoqueRepositorio()
        {

            _estoqueRepositorio = new EstoqueRepositorio();
        }
        private void InstanciaCaixaRepositorio()
        {
            _caixaRepositorio = new CaixaRepositorio();
        }
        private void InstanciarComandaRepositorio()
        {
            _comandaRepositorio = new ComandaRepositorio();
        }
        private void InstanciaUsuarioRepositorio()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }
        private void InstanciarVendaRepositorio()
        {
            _vendaRepositorio = new VendaRepositorio();
        }
        private void frmCaixa_Load(object sender, EventArgs e)
        {
            

            try
            {
                EsconderButton(btn:btnDividirComanda);
                if (Properties.Settings.Default.CaixaAberto == true)
                {
                    Properties.Settings.Default.CaixaAberto = false;
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao("O Caixa esta aberto, verifique o valor correto para evitar futuros problemas.", "Aviso");
                    Form frmAdd = new frmAdicionarCaixa(EnumTipoOperacaoCaixa.Fechar);
                    if (frmAdd.ShowDialog() == DialogResult.Yes)
                    {
                        CarregarValorDoCaixaAtualiza();
                        frmAdd.Close();
                    }
                    else
                    {

                        while (frmAdd.ShowDialog() != DialogResult.Yes)
                        {
                            if (frmAdd.ShowDialog() == DialogResult.Yes)
                            {
                                break;
                            }
                        }
                    }
                }

                InstanciaCaixaRepositorio();
                if (_caixaRepositorio.GetValor() == null)
                {
                    _caixaRepositorio.Cadastrar(new Caixa() { IDUsuario = Usuarios.IDStatic, Valor = 0 });
                }
                comandaLista = new List<Comanda>();
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbCodigoDaComanda }, Esconder);
                CarregarValorDoCaixaAtualiza();
                EsconderGpb();
                AtribuirUsuarioAoRodape();
                CarregarTxtQuantidadeComUm();
                EsconderOuMostrarButtonVenda(Esconder);
                InstanciaTipoPagamentoRepositorio();
                _tipoPagamentoRepositorio.Listar(cbb: cbbTipoDePagamento);
                FocarNoTxt(txtCodigoDaComanda);

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void EsconderButton(ToolStripMenuItem btn)
        {
            btn.Visible = false;

        }



        private void CarregarValorDoCaixaAtualiza()
        {

            try
            {

                InstanciaCaixaRepositorio();
                if (_caixaRepositorio.GetValor() != null)
                {
                    lblTotalNoCaixa.Text = _caixaRepositorio.GetValor().Valor.ToString("C2");
                }
                else
                {
                    lblTotalNoCaixa.Text = (00.0).ToString("C2");
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void AtribuirUsuarioAoRodape()
        {

            try
            {
                lblUsuarioLogado.Text = Usuarios.NomeCompletoStatic;
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void CarregarTxtQuantidadeComUm()
        {
            txtQuantidade.Text = "1";
        }


        private void EsconderOuMostrarButtonVenda(bool esconder)
        {
            if (esconder == Esconder)
            {
                btnConcluirVenda.Visible = false;
            }
            else
            {
                btnConcluirVenda.Visible = true;
            }
        }

        private void FocarNoTxt(TextBox txt)
        {

            try
            {
                this.FocoNoTxt(txt: txt);
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }



        private void InstanciaTipoPagamentoRepositorio()
        {
            _tipoPagamentoRepositorio = new TipoPagamentoRepositorio();
        }
        public void run()
        {
            mensagem = new frmMensagemEstoque();
            mensagem.ShowDialog();
        }
        private void txtCodigoDaComanda_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {



                ValidatorField.IntegerAndLetter(e);
                ValidatorField.NoSpace(e);
              
                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    Espere espere = new Espere();    
                    CarregarComandaAtiva(espere);
                    MostrarBotaoVendaSeExisteItensNaComanda();
                    LimparTxt(new List<TextBox>() { txtCodigoDaComanda });
                    FocarNoTxt(txtQuantidade);
                    espere.CancelarTask();
                    if (espere.Cancel.IsCancellationRequested)
                    {
                        mensagem.Close();
                    }
                    
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void MostrarBotaoVendaSeExisteItensNaComanda()
        {


            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Cartão.ToString() ||
                cbbTipoDePagamento.Text == EnumTipoPagamento.Creditar.ToString())
                {
                    if (VerificarSeExisteItensNoListView() > 0)
                    {
                        EsconderOuMostrarButtonVenda(Mostrar);
                    }
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }


        private void CarregarComandaAtiva(/*Task task*/Espere task)
        {

            try
            {
                InstanciarVendaComComandaAtivaRepositorio();
                InstanciarComandaRepositorio();
                Comanda comanda = _comandaRepositorio.GetComandaPorCodigo(txtCodigoDaComanda.Text);
                if (comanda != null)
                {
                    if (_comandaRepositorio.Inserir(comandaLista, comanda))
                    {
                        //task.Start();
                        task.Start(run);
                        comandaLista.Add(comanda);
                        _vendaComComandaAtivaRepositorio.GetItensnaComandaPorCodigo(comanda.Codigo, ltvProdutos);
                        GetValorNaComanda();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Comanda não esta cadastrada.");
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }


        private int VerificarSeExisteItensNoListView()
        {

            try
            {
                return ltvProdutos.Items.Count;
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        private decimal GetValorNaComanda()
        {

            try
            {
                decimal sum = 0;

                foreach (ListViewItem lstItem in ltvProdutos.Items)
                {
                    sum += decimal.Parse(lstItem.SubItems[3].Text);
                }
                lblTotalVenda.Text = sum.ToString("C2");
                VendaTotal = sum;
                return sum;
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }
        private decimal GetValorLucroTotal()
        {

            try
            {
                decimal lucro = 0;
                foreach (ListViewItem lstItem in ltvProdutos.Items)
                {
                    lucro += decimal.Parse(lstItem.SubItems[4].Text);
                }
                return lucro;
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }
        private void InstanciarVendaComComandaAtivaRepositorio()
        {
            _vendaComComandaAtivaRepositorio = new VendaComComandaAtivaRepositorio();
        }



        private void cbbTipoDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                LimparTxt(new List<TextBox>() { txtValorPago, txtTroco });
                switch (cbbTipoDePagamento.Text)
                {
                    case "Dinheiro":
                        MostrarGpb();
                        if (VerificarSeExisteItensNoListView() > 0)
                        {
                            decimal valorPago = ValorPago.ValorPagoPeloCliente(txtValorPago);
                            decimal valorDaComanda = GetValorNaComanda();
                            if (valorPago >= valorDaComanda)
                            {
                                EsconderOuMostrarButtonVenda(Mostrar);
                                this.FocoNoBotao(btnConcluirVenda);
                            }
                            else
                            {
                                EsconderOuMostrarButtonVenda(Esconder);
                            }

                        }
                        FocarNoTxt(txtValorPago);
                        break;
                    case "Cartão":
                        EsconderGpb();
                        HabilitarBotaoVenda();
                        MostrarBotaoVendaSeExisteItensNaComanda();
                        break;
                    case "Creditar":
                        MostrarBotaoVendaSeExisteItensNaComanda();
                        HabilitarBotaoVenda();
                        EsconderGpb();
                        break;

                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void HabilitarBotaoVenda()
        {
            if (VerificarSeExisteItensNoListView() > 0)
            {
                EsconderOuMostrarButtonVenda(Mostrar);
            }
        }
        private void MostrarGpb()
        {
            EsconderGroupBoxOuMostrar(listGpb: new List<GroupBox>() { gpbGerarTroco, gpbValorPago }, esconder: Mostrar);
        }
        private void EsconderGpb()
        {
            EsconderGroupBoxOuMostrar(listGpb: new List<GroupBox>() { gpbGerarTroco, gpbValorPago }, esconder: Esconder);
        }

        private void EsconderGroupBoxOuMostrar(List<GroupBox> listGpb, bool esconder)
        {

            try
            {

                foreach (var gpb in listGpb)
                {
                    if (gpb is GroupBox)
                    {
                        if (esconder == Esconder)
                        {
                            gpb.Visible = Esconder;
                        }
                        else
                        {
                            gpb.Visible = Mostrar;
                        }
                    }
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            if (DialogMessage.MessageFullQuestion("Deseja confirmar essa forma de pagamento " + cbbTipoDePagamento.Text.ToUpper(), "Aviso") == DialogResult.Yes)
            {
                try
                {

                    InstanciarVendaRepositorio();
                    InstanciaCaixaRepositorio();
                    InstanciarProdutoRepositorio();
                    InstanciarEstoqueRepositorio();

                    if (_vendaRepositorio.Cadastrar(PopularVenda()) == Sucesso)
                    {
                        InstanciarMovimentacaoProdutoRepositorio();
                        DarBaixaNoEstoque();
                        InserirVendaNoCaixa();
                        if (cbbTipoDePagamento.Text == EnumTipoPagamento.Creditar.ToString())
                        {
                            if (ConcluirVendaComCreditar() == false)
                            {

                                _vendaRepositorio.ExcluirUltimaVenda();
                                DialogMessage.MessageFullComButtonOkIconeDeInformacao("Para concluir a venda no modo CREDITAR é necessário selecionar o cliente.", "Aviso");
                            }
                        }
                        ConcluirVendaComCartao();

                    }


                }
                catch (CustomException erro)
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                }
                catch (Exception erro)
                {
                    DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
                }

            }
        }

        private void ConcluirVendaComCartao()
        {

            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Cartão.ToString())
                {
                    PosSalvamentoPadrao();
                    MensagemDeAviso();
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void JogarNovoValorParaCaixa()
        {

            try
            {
                CarregarValorDoCaixaAtualiza();
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private bool ConcluirVendaComCreditar()
        {

            try
            {
                bool retorno = false;
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Creditar.ToString())
                {
                    if (OpenMdiForm.OpenForWithShowDialog(new frmClienteCreditar(EnumTipoCreditar.Vender)) == DialogResult.Yes)
                    {
                        InstanciarFiadoRepositorio();
                        _fiadoRepositorio.Cadastrar(new Fiado() { IDCliente = Cliente.ClienteIDStatic, IDFuncionario = Usuarios.IDStatic, Valor = VendaTotal });
                        PosSalvamentoPadrao();
                        MensagemDeAviso();
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;

                    }

                }
                return retorno;
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }


        }

        private void InserirVendaNoCaixa()
        {

            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Dinheiro.ToString())
                {

                    if (_caixaRepositorio.Cadastrar(caixa: new Caixa() { IDUsuario = Usuarios.IDStatic, Valor = VendaTotal }) == 1)
                    {
                        InstanciarMovimentacaoCaixa();
                        _movimentacaoCaixaRepositorio.Salvar(new MovimentacaoCaixa() { Valor = VendaTotal, Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) });
                        JogarNovoValorParaCaixa();
                        PosSalvamentoPadrao();
                        MensagemDeAviso();

                    }
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void MensagemDeAviso()
        {
            timer.Start();
            DialogMessage.MessageFullComButtonOkIconeDeInformacao("Venda concluída com sucesso.", "Aviso");

        }

        private void DarBaixaNoEstoque()
        {

            try
            {
                foreach (ListViewItem lstItem in ltvProdutos.Items)
                {
                    Produto produto = _produtoRepositorio.GetProdutoPorCodigoUnidade(lstItem.SubItems[1].Text);
                    if (produto != null)
                    {
                        Estoque estoque = new Estoque() { ProdutoCodigo = lstItem.SubItems[1].Text, Quantidade = Convert.ToInt32(lstItem.SubItems[2].Text) };
                        _estoqueRepositorio.DarBaixa(produto, estoque);
                    }
                    _movimentacaoProdutoRepositorio.Cadastrar(new MovimentacaoProduto()
                    {
                        Codigo = lstItem.SubItems[1].Text,
                        Data = DateTime.Now.DataNoFormatoDate(),
                        Quantidade = lstItem.SubItems[2].Text == "Peso" ? 0 : Convert.ToInt32(lstItem.SubItems[2].Text),
                        Valor = Convert.ToDecimal(lstItem.SubItems[3].Text)
                    });



                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void PosSalvamentoPadrao()
        {

            try
            {
                ExcluirComandaAtiva();
                LimparTxt(new List<TextBox>() { txtCodigoDaComanda, txtCodigoDoProduto, txtTroco, txtValorPago });
                CarregarTxtQuantidadeComUm();
                ZerarTotalVenda();
                ZerarListView();
                EsconderOuMostrarButtonVenda(Esconder);
                ZerarLabelTotalVenda();
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                DesmarcarCheckBox();
                FocarNoTxt(txtCodigoDaComanda);
                cbbTipoDePagamento.SelectedIndex = 0;

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void ExcluirComandaAtiva()
        {

            try
            {

                if (comandaLista.Count > 0)
                {
                    InstanciarVendaComComandaAtivaRepositorio();
                    int contador = 0;
                    foreach (var comanda in comandaLista)
                    {
                        contador = _vendaComComandaAtivaRepositorio.DeletaItensDaComandaPorCodigo(comanda.Codigo);
                    }
                    if (contador > 0)
                    {
                        comandaLista.Clear();
                    }
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void ZerarLabelTotalVenda()
        {
            lblTotalVenda.Text = "0,00 R$";
        }

        private void ZerarListView()
        {
            ltvProdutos.Items.Clear();
        }

        private void ZerarTotalVenda()
        {
            VendaTotal = 0;
        }


        private Venda PopularVenda()
        {

            try
            {
                Venda venda = null;
                switch (cbbTipoDePagamento.Text)
                {
                    case "Dinheiro":
                        venda = PopularVendaComDinheiro(venda);
                        break;
                    case "Cartão":
                        venda = PopularVendaSemDinheiro(venda);
                        break;
                    case "Creditar":
                        venda = PopularVendaSemDinheiro(venda);
                        break;

                }

                return venda;

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }


        }

        private Venda PopularVendaSemDinheiro(Venda venda)
        {

            try
            {
                venda = new Venda();
                venda.Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                venda.LucroTotal = GetValorLucroTotal();
                venda.IDTIPOPAGAMENTO = _tipoPagamentoRepositorio.GetIDPeloNome(cbbTipoDePagamento.Text);
                venda.VendaTotal = GetValorNaComanda();
                venda.IdUsuario = Usuarios.IDStatic;
                return venda;

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        private Venda PopularVendaComDinheiro(Venda venda)
        {
            try
            {
                InstanciaCaixaRepositorio();
                decimal valorTroco = Convert.ToDecimal(txtTroco.Text.Substring(2, txtTroco.Text.Length - 2));
                if (_caixaRepositorio.GetValor().Valor < valorTroco)
                {
                    MyErro.MyCustomException("É necessário abrir o caixa para a venda ocorrer corretamente.");
                }
                venda = new Venda();
                venda.Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                venda.LucroTotal = GetValorLucroTotal();
                venda.IDTIPOPAGAMENTO = _tipoPagamentoRepositorio.GetIDPeloNome(cbbTipoDePagamento.Text);
                venda.VendaTotal = VendaTotal;
                venda.IdUsuario = Usuarios.IDStatic;
                return venda;
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        private void txtCodigoDoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ValidatorField.IntegerAndLetter(e);
                ValidatorField.NoSpace(e);
                if ((Keys)e.KeyChar == Keys.Enter && txtCodigoDoProduto.Text.Length > 0)
                {
                    if (ckbPorPeso.Checked)
                    {
                        decimal peso = 0;
                        if (txtPesoDoProduto.Text.Contains("0,"))
                        {
                            string temp = txtPesoDoProduto.Text.Substring(2, txtPesoDoProduto.Text.Length - 2);
                            peso = txtPesoDoProduto.Text == "" ? 0 : Convert.ToDecimal(temp);
                        }
                        else
                        {
                            peso = txtPesoDoProduto.Text == "" ? 0 : Convert.ToDecimal(txtPesoDoProduto.Text.Replace(",", ""));
                        }

                        if (peso > 0)
                        {
                            InstanciarProdutoRepositorio();
                            _produtoRepositorio.AdicionarProdutoParaVendaPorPeso(ltvProdutos, txtCodigoDoProduto.Text, peso);
                            GetValorNaComanda();
                            LimparTxt(new List<TextBox>() { txtCodigoDoProduto });
                            MostrarBotaoVendaSeExisteItensNaComanda();
                            EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                            DesmarcarCheckBox();
                            LimparTxt(new List<TextBox>() { txtValorPago });
                        }
                        else
                        {
                            MyErro.MyCustomException("Digite o valor do item vendido.");
                            FocarNoTxt(txtPesoDoProduto);
                        }
                    }
                    else
                    {
                        if (txtQuantidade.Text == "0" || txtQuantidade.Text == "00" || txtQuantidade.Text == "000")
                        {
                            LimparTxt(new List<TextBox>() { txtQuantidade });
                            FocarNoTxt(txtQuantidade);
                            DialogMessage.MessageFullComButtonOkIconeDeInformacao("Não é possível vende um produto com o campo Quantidade com 0", "Aviso");
                        }
                        else if (txtQuantidade.Text.Length == 0)
                        {
                            FocarNoTxt(txtQuantidade);
                            DialogMessage.MessageFullComButtonOkIconeDeInformacao("Não é possível vende um produto com o campo Quantidade vazio.", "Aviso");
                        }
                        else
                        {
                            InstanciarProdutoRepositorio();
                            _produtoRepositorio.AdicionarProdutoParaVenda(ltvProdutos, txtCodigoDoProduto.Text, Convert.ToInt32(txtQuantidade.Text));
                            GetValorNaComanda();
                            LimparTxt(new List<TextBox>() { txtCodigoDoProduto });
                            MostrarBotaoVendaSeExisteItensNaComanda();
                            EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                            DesmarcarCheckBox();
                            LimparTxt(new List<TextBox>() { txtValorPago });
                        }

                    }

                }
                else if ((Keys)e.KeyChar == Keys.Enter && txtCodigoDoProduto.Text.Length == 0)
                {
                    FocarNoTxt(txtValorPago);
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                LimparTxt(new List<TextBox>() { txtCodigoDoProduto });
                FocarNoTxt(txtCodigoDoProduto);
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void DesmarcarCheckBox()
        {
            ckbPorPeso.Checked = false;
        }

        private void InstanciarProdutoRepositorio()
        {
            _produtoRepositorio = new ProdutoRepositorio();
        }




        private void LimparTxt(List<TextBox> txtList)
        {
            foreach (var txt in txtList)
            {
                txt.Text = string.Empty;
            }
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Dinheiro.ToString())
                {


                    decimal valorPago = ValorPago.ValorPagoPeloCliente(txtValorPago);
                    decimal valorDaComanda = GetValorNaComanda();
                    if (ltvProdutos.Items.Count > 0 && valorPago >= valorDaComanda)
                    {
                        txtTroco.Text = Troco.GerarTroco(valorPago, valorDaComanda);
                        EsconderOuMostrarButtonVenda(Mostrar);
                    }
                    else
                    {
                        LimparTxt(new List<TextBox>() { txtTroco });
                        EsconderOuMostrarButtonVenda(Esconder);
                    }


                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }


        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidatorField.Integer(e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoTxt(txtCodigoDoProduto);
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidatorField.NoVirgula(e: e, sender: sender);
            ValidatorField.Money(e: e);

        }

        private void txtValorDoProdutoPorpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if ((Keys)e.KeyChar == Keys.Enter)
            {
                e.Handled = false;
            } */
            ValidatorField.Peso(e: e, sender: sender);

        }

        private void ckbPorPeso_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbPorPeso.Checked)
            {
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                LimparTxt(new List<TextBox>() { txtPesoDoProduto });
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbQuantidadeDoProduto }, Mostrar);
                FocarNoTxt(txtQuantidade);
            }
            else
            {
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Mostrar);
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbQuantidadeDoProduto }, Esconder);
                FocarNoTxt(txtPesoDoProduto);
            }
        }




        private void ltvProdutos_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                InstanciarProdutoRepositorio();
                Produto produto = _produtoRepositorio.GetProdutoPorCodigo(MyListView.RetornarValorPeloIndexDaColuna(ltvProdutos, 1));
                if (produto != null)
                {
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(produto, EnumTipoOperacao.ListView)) == DialogResult.Yes)
                    {
                        if (MyListView.RemoverItem(ltvProdutos))
                        {
                            GetValorNaComanda();
                            LimparTxt(new List<TextBox>() { txtValorPago });
                            FocarNoTxt(txt: txtValorPago);
                        }
                    }
                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }



        }



        private void ltvProdutos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {

            try
            {

                MyListView.ColumnWidthChanging(e, ltvProdutos);
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }



        }



        private void btnReceberCredito_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMdiForm.OpenForWithShowDialog(new frmClienteCreditar(EnumTipoCreditar.Pagar));
                CarregarValorDoCaixaAtualiza();


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {

            try
            {
                Calculadora.ChamarCalculadora();
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void btnDividirComanda_Click(object sender, EventArgs e)
        {

            try
            {
                if (MyListView.VerificarSeExisteItensNoListView(ltvProdutos) > 0)
                {
                    InstanciarMovimentacaoProdutoRepositorio();
                    List<BaixarEstoque> lista = new List<BaixarEstoque>();
                    foreach (var item in MyListView.RetornarValoresParaDarBaixaNoEstoque(ltvProdutos))
                    {
                        lista.Add(item);
                        _movimentacaoProdutoRepositorio.Cadastrar(PopulaMovimentacaoProduto(item));
                    }

                    if (OpenMdiForm.OpenForWithShowDialog(new frmDividirComanda(lista/*, comandaLista*/)) == DialogResult.Yes)
                    {
                        CarregarValorDoCaixaAtualiza();
                        PosSalvamentoPadrao();
                        ExcluirComandaAtiva();
                    }
                }



            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private static MovimentacaoProduto PopulaMovimentacaoProduto(BaixarEstoque item)
        {
            MovimentacaoProduto produto = new MovimentacaoProduto();

            produto.Codigo = item.Codigo;
            produto.Data = DateTime.Now.DataNoFormatoDate();
            produto.Valor = item.ValorTotal;
            produto.Quantidade = item.Quantidade;
            return produto;

        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {

            try
            {

                if (OpenMdiForm.OpenForWithShowDialog(new frmAdicionarCaixa(EnumTipoOperacaoCaixa.Adicionar)) == DialogResult.Yes)
                {

                    CarregarValorDoCaixaAtualiza();
                    FocarNoTxt(txtCodigoDaComanda);
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {

            try
            {

                if (OpenMdiForm.OpenForWithShowDialog(new frmAdicionarCaixa(EnumTipoOperacaoCaixa.Fechar)) == DialogResult.Yes)
                {

                    CarregarValorDoCaixaAtualiza();
                    FocarNoTxt(txtCodigoDaComanda);
                    LimparTxt(new List<TextBox>() { txtValorPago, txtTroco, txtPesoDoProduto });
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            try
            {


                SendKeys.Send("{ENTER}");

                timer.Stop();

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }


    }
}
