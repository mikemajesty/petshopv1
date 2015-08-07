﻿using Controller.Enum;
using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Windows.Forms;

namespace View.Enum.UI.ViewCaixa
{
    public partial class frmReceberFiado : Form
    {
        private Fiado _fiado;
        private TipoPagamentoRepositorio _tipoPagamentoRepositorio;
        private FiadoRepositorio _fiadoRepositorio;
        private CaixaRepositorio _caixaRepositorio;
        private const int Sucesso = 1, Insucesso = 0;
        private MovimentacaoCaixaRepositorio _movimentacaoCaixaRepositorio;
        public frmReceberFiado(Fiado fiado)
        {
            _fiado = fiado;
            InitializeComponent();
        }
        private void InstanciarCaixaRepositorio()
        {
            _caixaRepositorio = new CaixaRepositorio();
        }
        private void InstanciarFiadoRepositorio()
        {
            _fiadoRepositorio = new FiadoRepositorio();
        }
        private void InstanciarTipodePagamentoRepositorio()
        {
            _tipoPagamentoRepositorio = new TipoPagamentoRepositorio();
        }
        private void frmReceberFiado_Load(object sender, EventArgs e)
        {

            try
            {
                InstanciarTipodePagamentoRepositorio();
                _tipoPagamentoRepositorio.Listar(cbb: cbbTipoDePagamento);
                lblTotalVenda.Text = JogarValorTotalParaLabel();
                EsconderBotao();
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

        private void EsconderBotao()
        {
            btnConcluirVenda.Visible = false;
        }

        private string JogarValorTotalParaLabel()
        {
            try
            {
                return _fiado.Valor.ToString("C2");
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

        private string AtualizarValorDaDivida(decimal valor)
        {
            try
            {
                _fiado.Valor -= valor;
                return _fiado.Valor.ToString("C2");
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

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {

            try
            {
                if (DialogMessage.MessageFullQuestion("Deseja confirmar essa forma de pagamento " + cbbTipoDePagamento.Text.ToUpper(), "Aviso") == DialogResult.Yes)
                {

                    InstanciarCaixaRepositorio();
                    InstanciarFiadoRepositorio();
                    switch (cbbTipoDePagamento.Text)
                    {
                        case "Dinheiro":
                            decimal valor = Decimal.Parse(txtValorPago.Text);

                            _caixaRepositorio.Cadastrar(new Caixa() { IDUsuario = Usuarios.IDStatic, Valor = valor });
                            InstanciarMovimentacaoCaixa();
                            _movimentacaoCaixaRepositorio.Salvar(new MovimentacaoCaixa() { Valor = valor, Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) });
                            _fiado.Valor = GetTxtValorPago();
                            if (_fiadoRepositorio.Alterar(_fiado) == Sucesso)
                            {
                                DialogMessage.MessageFullComButtonOkIconeDeInformacao("Opercação concluída com sucesso.", "Aviso");
                                PosSalvamento();

                            }

                            break;
                        case "Cartão":
                            _fiado.Valor = GetTxtValorPago();
                            if (_fiadoRepositorio.Alterar(_fiado) == Sucesso)
                            {
                                DialogMessage.MessageFullComButtonOkIconeDeInformacao("Opercação concluída com sucesso.", "Aviso");
                                PosSalvamento();

                            }
                            break;

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
            finally { EsconderBotao(); LimparTxt(); };
        }

        private void InstanciarMovimentacaoCaixa()
        {
            _movimentacaoCaixaRepositorio = new MovimentacaoCaixaRepositorio();
        }

        private void PosSalvamento()
        {
            this.DialogResult = DialogResult.Yes;
        }

        private decimal GetTxtValorPago()
        {

            try
            {
                return decimal.Parse(txtValorPago.Text);
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

        private void FocoNoTextBox()
        {
            this.FocoNoTxt(txtValorPago);
        }

        private void CarregarComboBoxComDinheiro()
        {
            cbbTipoDePagamento.SelectedIndex = 0;
        }

        private void LimparTxt()
        {
            txtValorPago.Text = string.Empty;
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.NoVirgula(e, sender);
            ValidatorField.Money(e);
        }


        public void AtualizarValor()
        {
            try
            {
                InstanciarFiadoRepositorio();
                lblTotalVenda.Text = _fiadoRepositorio.GetValorPeloIDDoCliente(_fiado.IDCliente).ToString("C2");

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

        private void frmReceberFiado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {

            try
            {


                if ((sender as TextBox).Text.Length > 0)
                {
                    decimal valorPago = Decimal.Parse((sender as TextBox).Text);
                    decimal ValorTotal = _fiado.Valor;

                    if (valorPago > ValorTotal)
                    {
                        throw new CustomException("Digite um valor menor ou igual ao valor da dívida.");

                    }
                    else
                    {
                        MostrarBotao();
                    }
                }
                else
                {
                    EsconderBotao();

                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                txtValorPago.LimparTxtNoEventoChanged(txtValorPago_TextChanged);
                return;

            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void MostrarBotao()
        {
            btnConcluirVenda.Visible = true;
        }

        private void cbbTipoDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                switch (cbbTipoDePagamento.Text)
                {
                    case "Cartão":
                        EsconderBotao();
                        MostrarGruopBox(gpbValorPago);
                        LimparTxt();
                        FocoNoTextBox();
                        break;
                    case "Dinheiro":
                        EsconderBotao();
                        LimparTxt();
                        MostrarGruopBox(gpbValorPago);
                        FocoNoTextBox();
                        break;
                    case "Creditar":
                        EsconderBotao();
                        EsconderGroupBox(gpb: gpbValorPago);
                        LimparTxt();
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

        private void FocarNoBotao()
        {
            this.FocoNoBotao(btnConcluirVenda);
        }

        private void MostrarGruopBox(GroupBox gpb)
        {
            gpb.Visible = true;
        }

        private void EsconderGroupBox(GroupBox gpb)
        {
            gpb.Visible = false;
        }


    }
}
