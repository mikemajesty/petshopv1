﻿using Controller.Repositorio;
using Mike.Utilities.Desktop;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View.Enum.UI.ViewCliente
{
    public partial class frmCadastrarCliente : Form
    {
        private Model.Entidades.Cliente _cliente;
        private EnumTipoOperacao _tipoOperacao;
        private ClienteRepositorio _clienteRepositorio;
        private const int Sucesso = 1;
        public frmCadastrarCliente(Model.Entidades.Cliente cliente, EnumTipoOperacao tipoOpercacao)
        {
           
            InitializeComponent();
            CarregaClienteTipoOperacao(cliente, tipoOpercacao);
        }

        private void CarregaClienteTipoOperacao(Model.Entidades.Cliente cliente, EnumTipoOperacao tipoOpercacao)
        {
            _cliente = cliente;
            _tipoOperacao = tipoOpercacao;
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {

            try
            {


                this.FocoNoTxt(txt: txtNome);
                switch (_tipoOperacao)
                {

                    case EnumTipoOperacao.Alterar:
                        MudarTextoDoForm(texto: "Alterar Cliente");
                        MudarTextoDoBotao(texto: "Alterar");
                        MudarCorDoBotao(color: Color.LightGreen);
                        PopularTxt();
                        break;
                    case EnumTipoOperacao.Deletar:
                        MudarTextoDoForm(texto: "Deletar Cliente");
                        MudarTextoDoBotao(texto: "Deletar");
                        MudarCorDoBotao(color: Color.LightCoral);
                        PopularTxt();
                        DesabilitarGroupBox(gpbDadosDoCliente);
                        break;
                    case EnumTipoOperacao.Detalhes:
                        MudarTextoDoForm(texto: "Detalhes do Cliente");
                        MudarTextoDoBotao(texto: "Sair");
                        MudarCorDoBotao(color: Color.Gray);
                        PopularTxt();
                        DesabilitarGroupBox(gpbDadosDoCliente);
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

        private void DesabilitarGroupBox(GroupBox gpb)
        {
            gpb.Enabled = false;
        }

        private void PopularTxt()
        {
            txtNome.Text = _cliente.Nome;
            mtbCpf.Text = _cliente.CPF;
            mtbTelefone.Text = _cliente.Celular;
        }

        private void MudarCorDoBotao(Color color)
        {
            btnCadastrar.BackColor = color;
        }

        private void MudarTextoDoBotao(string texto)
        {
            btnCadastrar.Text = texto;
        }

        private void MudarTextoDoForm(string texto)
        {
            this.Text = texto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {

                switch (_tipoOperacao)
                {
                    case EnumTipoOperacao.Salvar:
                        if (SeTxtEstaVazio() == 0)
                        {
                            InstanciarClienteRepositorio();
                            if (_clienteRepositorio.Salvar(PreencheCliente()) == Sucesso)
                            {
                                MesagemDeAviso(mensagem: "Cliente cadastrado com sucesso.");
                                PosSalvamento();
                            }
                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }

                        break;
                    case EnumTipoOperacao.Alterar:
                        if (SeTxtEstaVazio() == 0)
                        {
                            InstanciarClienteRepositorio();
                            if (_clienteRepositorio.Alterar(PreencheCliente()) == Sucesso)
                            {
                                MesagemDeAviso(mensagem: "Cliente alterado com sucesso.");
                                PosSalvamento();
                            }
                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }

                        break;
                    case EnumTipoOperacao.Deletar:
                        if (SeTxtEstaVazio() == 0)
                        {
                            InstanciarClienteRepositorio();
                            if (_clienteRepositorio.Deletar(PreencheCliente()) == Sucesso)
                            {
                                MesagemDeAviso(mensagem: "Cliente deletado com sucesso.");
                                PosSalvamento();
                            }
                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }

                        break;
                    case EnumTipoOperacao.Detalhes:
                        FecharForm();
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

        private int SeTxtEstaVazio()
        {

            try
            {
                int retorno = 0;
                MaskedTextBox[] mtbList = {mtbCpf,mtbTelefone };
                if (txtNome.Text == string.Empty)
                {
                    retorno = 1;
                    
                }
                foreach (MaskedTextBox mtb in mtbList)
                {
                    if (mtb.Text == string.Empty)
                    {
                         retorno = 1;
                         break;
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

        private void FecharForm()
        {
            this.Close();
        }

        private void MesagemDeAviso(string mensagem)
        {
            DialogMessage.MessageFullComButtonOkIconeDeInformacao(mensagem, "Aviso");
        }

        private void PosSalvamento()
        {
            this.DialogResult = DialogResult.Yes;
        }

        private Model.Entidades.Cliente PreencheCliente()
        {


            try
            {

                return new Model.Entidades.Cliente()
                {
                    ID = _cliente.ID,
                    Nome = txtNome.Text.UpperCaseOnlyFirst(),
                    Celular = mtbTelefone.Text,
                    CPF = mtbCpf.Text
                };

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

        private void InstanciarClienteRepositorio()
        {
            _clienteRepositorio = new ClienteRepositorio();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Letter(e: e);
        }

        private void mtbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e: e);
        }

        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
        }
    }
}
