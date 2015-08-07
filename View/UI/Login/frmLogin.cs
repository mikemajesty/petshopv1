using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Windows.Forms;

namespace View.Enum.UI.ViewUsuario
{
    public partial class frmLogin : Form
    {
        private const bool Existe = true;
        private KeyGenRepositorio _keyGenRepositorio;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

            try
            {
                this.FocoNoTxt(txt: txtNome);
                InstanciarKeyGenRepositorio();
                if (_keyGenRepositorio.GetDiasTrail() == 0)
                {
                    lblExpirar.Text = "Atenção sua licença expirou";
                }
                else
                {
                    lblExpirar.Text = "Atenção " + _keyGenRepositorio.GetDiasTrail().ToString("00") + " para expirar o Programa";
                   
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

        private void InstanciarKeyGenRepositorio()
        {
            _keyGenRepositorio = new KeyGenRepositorio();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Logar();
                new UsuarioRepositorio().AdicionarUltimoAcesso(PreencherLogin().Nome);
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: erro.Message, title: "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(message: erro.Message, title: "Erro");
            }


        }

        private void Logar()
        {
            UsuarioRepositorio _usuarioRepositorio = new UsuarioRepositorio();
            OpenMdiForm.OpenForWithShow
           (
            formParaAbrir:
            _usuarioRepositorio.Logar(PreencherLogin()) == Existe ?
            new frmMenu(_usuarioRepositorio.GetUsuarioPorNome(PreencherLogin().Nome)) : new Form().FormException("Usuário ou senha incorretos"),
            formParaFechar: this
           );
        }

        private Usuarios PreencherLogin()
        {
            return new Usuarios() { Nome = txtNome.Text, Senha = txtSenha.Text };
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FecharForm();
        }

        private void FecharForm()
        {
            Application.Exit();
        }

      




    }
}
