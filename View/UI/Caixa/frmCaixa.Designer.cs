﻿namespace View.Enum.UI.ViewCaixa
{
    partial class frmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.gpbCodigoDaComanda = new System.Windows.Forms.GroupBox();
            this.ptbCodigo = new System.Windows.Forms.PictureBox();
            this.txtCodigoDaComanda = new System.Windows.Forms.TextBox();
            this.gpbCodigoDoProduto = new System.Windows.Forms.GroupBox();
            this.ptbCodigoDoProduto = new System.Windows.Forms.PictureBox();
            this.txtCodigoDoProduto = new System.Windows.Forms.TextBox();
            this.gpbValorPago = new System.Windows.Forms.GroupBox();
            this.ptbValorTotalPago = new System.Windows.Forms.PictureBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.gpbGerarTroco = new System.Windows.Forms.GroupBox();
            this.ptbTroco = new System.Windows.Forms.PictureBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.gpbTotalNocaixa = new System.Windows.Forms.GroupBox();
            this.lblTotalNoCaixa = new System.Windows.Forms.Label();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.gpbQuantidadeDoProduto = new System.Windows.Forms.GroupBox();
            this.ptbQuantidade = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.gpbTipoDePagamento = new System.Windows.Forms.GroupBox();
            this.cbbTipoDePagamento = new System.Windows.Forms.ComboBox();
            this.rodape = new System.Windows.Forms.StatusStrip();
            this.lblProfissao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpbValorPorPeso = new System.Windows.Forms.GroupBox();
            this.ptbKilograma = new System.Windows.Forms.PictureBox();
            this.txtPesoDoProduto = new System.Windows.Forms.TextBox();
            this.ckbPorPeso = new System.Windows.Forms.CheckBox();
            this.ltvProdutos = new System.Windows.Forms.ListView();
            this.MenuCaixa = new System.Windows.Forms.MenuStrip();
            this.menuOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReceberCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDividirComanda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbrirCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFecharCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gpbCodigoDaComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigo)).BeginInit();
            this.gpbCodigoDoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigoDoProduto)).BeginInit();
            this.gpbValorPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbValorTotalPago)).BeginInit();
            this.gpbGerarTroco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroco)).BeginInit();
            this.gpbTotal.SuspendLayout();
            this.gpbTotalNocaixa.SuspendLayout();
            this.gpbQuantidadeDoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuantidade)).BeginInit();
            this.gpbTipoDePagamento.SuspendLayout();
            this.rodape.SuspendLayout();
            this.gpbValorPorPeso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKilograma)).BeginInit();
            this.MenuCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCodigoDaComanda
            // 
            this.gpbCodigoDaComanda.Controls.Add(this.ptbCodigo);
            this.gpbCodigoDaComanda.Controls.Add(this.txtCodigoDaComanda);
            this.gpbCodigoDaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCodigoDaComanda.Location = new System.Drawing.Point(446, 33);
            this.gpbCodigoDaComanda.Name = "gpbCodigoDaComanda";
            this.gpbCodigoDaComanda.Size = new System.Drawing.Size(10, 10);
            this.gpbCodigoDaComanda.TabIndex = 1;
            this.gpbCodigoDaComanda.TabStop = false;
            this.gpbCodigoDaComanda.Text = "Código da comanda";
            // 
            // ptbCodigo
            // 
            this.ptbCodigo.Image = ((System.Drawing.Image)(resources.GetObject("ptbCodigo.Image")));
            this.ptbCodigo.Location = new System.Drawing.Point(4, 34);
            this.ptbCodigo.Name = "ptbCodigo";
            this.ptbCodigo.Size = new System.Drawing.Size(31, 38);
            this.ptbCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCodigo.TabIndex = 13;
            this.ptbCodigo.TabStop = false;
            // 
            // txtCodigoDaComanda
            // 
            this.txtCodigoDaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDaComanda.Location = new System.Drawing.Point(40, 34);
            this.txtCodigoDaComanda.MaxLength = 20;
            this.txtCodigoDaComanda.Name = "txtCodigoDaComanda";
            this.txtCodigoDaComanda.Size = new System.Drawing.Size(366, 38);
            this.txtCodigoDaComanda.TabIndex = 1;
            this.txtCodigoDaComanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtCodigoDaComanda, "Digite o código de barra da comanda\r\n");
            this.txtCodigoDaComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDaComanda_KeyPress);
            // 
            // gpbCodigoDoProduto
            // 
            this.gpbCodigoDoProduto.Controls.Add(this.ptbCodigoDoProduto);
            this.gpbCodigoDoProduto.Controls.Add(this.txtCodigoDoProduto);
            this.gpbCodigoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCodigoDoProduto.Location = new System.Drawing.Point(156, 133);
            this.gpbCodigoDoProduto.Name = "gpbCodigoDoProduto";
            this.gpbCodigoDoProduto.Size = new System.Drawing.Size(275, 78);
            this.gpbCodigoDoProduto.TabIndex = 3;
            this.gpbCodigoDoProduto.TabStop = false;
            this.gpbCodigoDoProduto.Text = "Código do produto";
            // 
            // ptbCodigoDoProduto
            // 
            this.ptbCodigoDoProduto.Image = ((System.Drawing.Image)(resources.GetObject("ptbCodigoDoProduto.Image")));
            this.ptbCodigoDoProduto.Location = new System.Drawing.Point(6, 34);
            this.ptbCodigoDoProduto.Name = "ptbCodigoDoProduto";
            this.ptbCodigoDoProduto.Size = new System.Drawing.Size(31, 38);
            this.ptbCodigoDoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCodigoDoProduto.TabIndex = 13;
            this.ptbCodigoDoProduto.TabStop = false;
            // 
            // txtCodigoDoProduto
            // 
            this.txtCodigoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDoProduto.Location = new System.Drawing.Point(40, 34);
            this.txtCodigoDoProduto.MaxLength = 20;
            this.txtCodigoDoProduto.Name = "txtCodigoDoProduto";
            this.txtCodigoDoProduto.Size = new System.Drawing.Size(228, 38);
            this.txtCodigoDoProduto.TabIndex = 3;
            this.txtCodigoDoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtCodigoDoProduto, "Digite o código de barra do produto");
            this.txtCodigoDoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDoProduto_KeyPress);
            // 
            // gpbValorPago
            // 
            this.gpbValorPago.Controls.Add(this.ptbValorTotalPago);
            this.gpbValorPago.Controls.Add(this.txtValorPago);
            this.gpbValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValorPago.Location = new System.Drawing.Point(12, 297);
            this.gpbValorPago.Name = "gpbValorPago";
            this.gpbValorPago.Size = new System.Drawing.Size(210, 72);
            this.gpbValorPago.TabIndex = 4;
            this.gpbValorPago.TabStop = false;
            this.gpbValorPago.Text = "Valor pago pelo cliente";
            // 
            // ptbValorTotalPago
            // 
            this.ptbValorTotalPago.Image = ((System.Drawing.Image)(resources.GetObject("ptbValorTotalPago.Image")));
            this.ptbValorTotalPago.Location = new System.Drawing.Point(5, 27);
            this.ptbValorTotalPago.Name = "ptbValorTotalPago";
            this.ptbValorTotalPago.Size = new System.Drawing.Size(31, 38);
            this.ptbValorTotalPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbValorTotalPago.TabIndex = 13;
            this.ptbValorTotalPago.TabStop = false;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(41, 27);
            this.txtValorPago.MaxLength = 7;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(160, 38);
            this.txtValorPago.TabIndex = 4;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtValorPago, "Digite o Valor pago pelo cliente");
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // gpbGerarTroco
            // 
            this.gpbGerarTroco.Controls.Add(this.ptbTroco);
            this.gpbGerarTroco.Controls.Add(this.txtTroco);
            this.gpbGerarTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGerarTroco.Location = new System.Drawing.Point(225, 297);
            this.gpbGerarTroco.Name = "gpbGerarTroco";
            this.gpbGerarTroco.Size = new System.Drawing.Size(204, 72);
            this.gpbGerarTroco.TabIndex = 5;
            this.gpbGerarTroco.TabStop = false;
            this.gpbGerarTroco.Text = "Troco";
            // 
            // ptbTroco
            // 
            this.ptbTroco.Image = ((System.Drawing.Image)(resources.GetObject("ptbTroco.Image")));
            this.ptbTroco.Location = new System.Drawing.Point(6, 28);
            this.ptbTroco.Name = "ptbTroco";
            this.ptbTroco.Size = new System.Drawing.Size(31, 38);
            this.ptbTroco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTroco.TabIndex = 13;
            this.ptbTroco.TabStop = false;
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.Color.Yellow;
            this.txtTroco.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.Color.Black;
            this.txtTroco.Location = new System.Drawing.Point(43, 28);
            this.txtTroco.MaxLength = 20;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(155, 39);
            this.txtTroco.TabIndex = 0;
            this.txtTroco.TabStop = false;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtTroco, "Valor do troco para cliente");
            // 
            // gpbTotal
            // 
            this.gpbTotal.BackColor = System.Drawing.Color.White;
            this.gpbTotal.Controls.Add(this.lblTotalVenda);
            this.gpbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotal.Location = new System.Drawing.Point(435, 375);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Size = new System.Drawing.Size(416, 71);
            this.gpbTotal.TabIndex = 4;
            this.gpbTotal.TabStop = false;
            this.gpbTotal.Text = "Total da venda";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalVenda.Location = new System.Drawing.Point(5, 16);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(404, 49);
            this.lblTotalVenda.TabIndex = 1;
            this.lblTotalVenda.Text = "00 R$";
            this.lblTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlp.SetToolTip(this.lblTotalVenda, "Valor total da venda");
            // 
            // gpbTotalNocaixa
            // 
            this.gpbTotalNocaixa.Controls.Add(this.lblTotalNoCaixa);
            this.gpbTotalNocaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotalNocaixa.Location = new System.Drawing.Point(14, 375);
            this.gpbTotalNocaixa.Name = "gpbTotalNocaixa";
            this.gpbTotalNocaixa.Size = new System.Drawing.Size(210, 71);
            this.gpbTotalNocaixa.TabIndex = 4;
            this.gpbTotalNocaixa.TabStop = false;
            this.gpbTotalNocaixa.Text = "Total  no caixa";
            // 
            // lblTotalNoCaixa
            // 
            this.lblTotalNoCaixa.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalNoCaixa.Location = new System.Drawing.Point(2, 16);
            this.lblTotalNoCaixa.Name = "lblTotalNoCaixa";
            this.lblTotalNoCaixa.Size = new System.Drawing.Size(201, 52);
            this.lblTotalNoCaixa.TabIndex = 0;
            this.lblTotalNoCaixa.Text = "00 R$";
            this.lblTotalNoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlp.SetToolTip(this.lblTotalNoCaixa, "Valor total no Caixa");
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnConcluirVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnConcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluirVenda.Image")));
            this.btnConcluirVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConcluirVenda.Location = new System.Drawing.Point(227, 383);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(204, 63);
            this.btnConcluirVenda.TabIndex = 6;
            this.btnConcluirVenda.Text = "Concluir Venda";
            this.tlp.SetToolTip(this.btnConcluirVenda, "Concluir a venda");
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // gpbQuantidadeDoProduto
            // 
            this.gpbQuantidadeDoProduto.Controls.Add(this.ptbQuantidade);
            this.gpbQuantidadeDoProduto.Controls.Add(this.txtQuantidade);
            this.gpbQuantidadeDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbQuantidadeDoProduto.Location = new System.Drawing.Point(14, 133);
            this.gpbQuantidadeDoProduto.Name = "gpbQuantidadeDoProduto";
            this.gpbQuantidadeDoProduto.Size = new System.Drawing.Size(136, 78);
            this.gpbQuantidadeDoProduto.TabIndex = 2;
            this.gpbQuantidadeDoProduto.TabStop = false;
            this.gpbQuantidadeDoProduto.Text = "Quantidade";
            // 
            // ptbQuantidade
            // 
            this.ptbQuantidade.Image = ((System.Drawing.Image)(resources.GetObject("ptbQuantidade.Image")));
            this.ptbQuantidade.Location = new System.Drawing.Point(6, 34);
            this.ptbQuantidade.Name = "ptbQuantidade";
            this.ptbQuantidade.Size = new System.Drawing.Size(31, 38);
            this.ptbQuantidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbQuantidade.TabIndex = 13;
            this.ptbQuantidade.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(41, 34);
            this.txtQuantidade.MaxLength = 3;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(86, 38);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtQuantidade, "Digite a quantidade do produto vendido");
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // gpbTipoDePagamento
            // 
            this.gpbTipoDePagamento.Controls.Add(this.cbbTipoDePagamento);
            this.gpbTipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoDePagamento.Location = new System.Drawing.Point(13, 217);
            this.gpbTipoDePagamento.Name = "gpbTipoDePagamento";
            this.gpbTipoDePagamento.Size = new System.Drawing.Size(417, 74);
            this.gpbTipoDePagamento.TabIndex = 6;
            this.gpbTipoDePagamento.TabStop = false;
            this.gpbTipoDePagamento.Text = "Tipo de pagamento";
            // 
            // cbbTipoDePagamento
            // 
            this.cbbTipoDePagamento.BackColor = System.Drawing.Color.White;
            this.cbbTipoDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoDePagamento.FormattingEnabled = true;
            this.cbbTipoDePagamento.Location = new System.Drawing.Point(6, 30);
            this.cbbTipoDePagamento.Name = "cbbTipoDePagamento";
            this.cbbTipoDePagamento.Size = new System.Drawing.Size(405, 39);
            this.cbbTipoDePagamento.TabIndex = 7;
            this.cbbTipoDePagamento.TabStop = false;
            this.tlp.SetToolTip(this.cbbTipoDePagamento, "Escolha a forma de pagamento\r\n");
            this.cbbTipoDePagamento.SelectedIndexChanged += new System.EventHandler(this.cbbTipoDePagamento_SelectedIndexChanged);
            // 
            // rodape
            // 
            this.rodape.BackColor = System.Drawing.Color.White;
            this.rodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProfissao,
            this.lblUsuarioLogado});
            this.rodape.Location = new System.Drawing.Point(0, 448);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(860, 22);
            this.rodape.TabIndex = 9;
            this.rodape.Text = "statusStrip1";
            // 
            // lblProfissao
            // 
            this.lblProfissao.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(105, 17);
            this.lblProfissao.Text = "Funcionario: ";
            this.lblProfissao.ToolTipText = "Nome do funcionario\r\n";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(0, 17);
            // 
            // gpbValorPorPeso
            // 
            this.gpbValorPorPeso.Controls.Add(this.ptbKilograma);
            this.gpbValorPorPeso.Controls.Add(this.txtPesoDoProduto);
            this.gpbValorPorPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValorPorPeso.Location = new System.Drawing.Point(156, 49);
            this.gpbValorPorPeso.Name = "gpbValorPorPeso";
            this.gpbValorPorPeso.Size = new System.Drawing.Size(275, 78);
            this.gpbValorPorPeso.TabIndex = 3;
            this.gpbValorPorPeso.TabStop = false;
            this.gpbValorPorPeso.Text = "Peso do produto";
            // 
            // ptbKilograma
            // 
            this.ptbKilograma.Image = ((System.Drawing.Image)(resources.GetObject("ptbKilograma.Image")));
            this.ptbKilograma.Location = new System.Drawing.Point(228, 33);
            this.ptbKilograma.Name = "ptbKilograma";
            this.ptbKilograma.Size = new System.Drawing.Size(41, 38);
            this.ptbKilograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbKilograma.TabIndex = 14;
            this.ptbKilograma.TabStop = false;
            // 
            // txtPesoDoProduto
            // 
            this.txtPesoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoDoProduto.Location = new System.Drawing.Point(6, 33);
            this.txtPesoDoProduto.MaxLength = 6;
            this.txtPesoDoProduto.Name = "txtPesoDoProduto";
            this.txtPesoDoProduto.Size = new System.Drawing.Size(218, 38);
            this.txtPesoDoProduto.TabIndex = 3;
            this.txtPesoDoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtPesoDoProduto, "Digite o valor do produto");
            this.txtPesoDoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDoProdutoPorpeso_KeyPress);
            // 
            // ckbPorPeso
            // 
            this.ckbPorPeso.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbPorPeso.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPorPeso.Image = ((System.Drawing.Image)(resources.GetObject("ckbPorPeso.Image")));
            this.ckbPorPeso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbPorPeso.Location = new System.Drawing.Point(14, 55);
            this.ckbPorPeso.Name = "ckbPorPeso";
            this.ckbPorPeso.Size = new System.Drawing.Size(132, 72);
            this.ckbPorPeso.TabIndex = 12;
            this.ckbPorPeso.TabStop = false;
            this.ckbPorPeso.Text = "Por Peso";
            this.tlp.SetToolTip(this.ckbPorPeso, "Digitar o preço manualmente para produtos não vendidos por unidade");
            this.ckbPorPeso.UseVisualStyleBackColor = true;
            this.ckbPorPeso.CheckedChanged += new System.EventHandler(this.ckbPorPeso_CheckedChanged);
            // 
            // ltvProdutos
            // 
            this.ltvProdutos.BackColor = System.Drawing.Color.White;
            this.ltvProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvProdutos.FullRowSelect = true;
            this.ltvProdutos.GridLines = true;
            this.ltvProdutos.Location = new System.Drawing.Point(435, 49);
            this.ltvProdutos.MultiSelect = false;
            this.ltvProdutos.Name = "ltvProdutos";
            this.ltvProdutos.Size = new System.Drawing.Size(416, 320);
            this.ltvProdutos.TabIndex = 8;
            this.ltvProdutos.TabStop = false;
            this.tlp.SetToolTip(this.ltvProdutos, "Detalhes dos produtos vendidos");
            this.ltvProdutos.UseCompatibleStateImageBehavior = false;
            this.ltvProdutos.View = System.Windows.Forms.View.Details;
            this.ltvProdutos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ltvProdutos_ColumnWidthChanging);
            this.ltvProdutos.DoubleClick += new System.EventHandler(this.ltvProdutos_DoubleClick);
            // 
            // MenuCaixa
            // 
            this.MenuCaixa.AllowMerge = false;
            this.MenuCaixa.AutoSize = false;
            this.MenuCaixa.BackColor = System.Drawing.Color.White;
            this.MenuCaixa.GripMargin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.MenuCaixa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOperacoes,
            this.btnCalculadora});
            this.MenuCaixa.Location = new System.Drawing.Point(0, 0);
            this.MenuCaixa.Name = "MenuCaixa";
            this.MenuCaixa.Size = new System.Drawing.Size(860, 35);
            this.MenuCaixa.TabIndex = 14;
            this.MenuCaixa.TabStop = true;
            this.MenuCaixa.Text = "Menu";
            // 
            // menuOperacoes
            // 
            this.menuOperacoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuOperacoes.BackColor = System.Drawing.Color.LightGray;
            this.menuOperacoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuOperacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReceberCredito,
            this.btnDividirComanda,
            this.btnAbrirCaixa,
            this.btnFecharCaixa});
            this.menuOperacoes.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOperacoes.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.menuOperacoes.Name = "menuOperacoes";
            this.menuOperacoes.Size = new System.Drawing.Size(148, 31);
            this.menuOperacoes.Text = "Operações extras";
            this.menuOperacoes.ToolTipText = "Operações extras\r\n";
            // 
            // btnReceberCredito
            // 
            this.btnReceberCredito.Name = "btnReceberCredito";
            this.btnReceberCredito.Size = new System.Drawing.Size(236, 22);
            this.btnReceberCredito.Text = "Receber Credito";
            this.btnReceberCredito.Click += new System.EventHandler(this.btnReceberCredito_Click);
            // 
            // btnDividirComanda
            // 
            this.btnDividirComanda.Name = "btnDividirComanda";
            this.btnDividirComanda.Size = new System.Drawing.Size(236, 22);
            this.btnDividirComanda.Text = "Dividir a Comanda";
            this.btnDividirComanda.Click += new System.EventHandler(this.btnDividirComanda_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(236, 22);
            this.btnAbrirCaixa.Text = "Abrir\\Adicionar Caixa";
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(236, 22);
            this.btnFecharCaixa.Text = "Fechar Caixa";
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.Color.LightGray;
            this.btnCalculadora.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(113, 31);
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.ToolTipText = "Calculadora\r\n";
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // tlp
            // 
            this.tlp.AutomaticDelay = 100;
            this.tlp.AutoPopDelay = 1000;
            this.tlp.InitialDelay = 500;
            this.tlp.ReshowDelay = 200;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 470);
            this.Controls.Add(this.ckbPorPeso);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.MenuCaixa);
            this.Controls.Add(this.ltvProdutos);
            this.Controls.Add(this.gpbTipoDePagamento);
            this.Controls.Add(this.gpbQuantidadeDoProduto);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.gpbTotalNocaixa);
            this.Controls.Add(this.gpbTotal);
            this.Controls.Add(this.gpbGerarTroco);
            this.Controls.Add(this.gpbValorPago);
            this.Controls.Add(this.gpbValorPorPeso);
            this.Controls.Add(this.gpbCodigoDoProduto);
            this.Controls.Add(this.gpbCodigoDaComanda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuCaixa;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.gpbCodigoDaComanda.ResumeLayout(false);
            this.gpbCodigoDaComanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigo)).EndInit();
            this.gpbCodigoDoProduto.ResumeLayout(false);
            this.gpbCodigoDoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigoDoProduto)).EndInit();
            this.gpbValorPago.ResumeLayout(false);
            this.gpbValorPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbValorTotalPago)).EndInit();
            this.gpbGerarTroco.ResumeLayout(false);
            this.gpbGerarTroco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroco)).EndInit();
            this.gpbTotal.ResumeLayout(false);
            this.gpbTotalNocaixa.ResumeLayout(false);
            this.gpbQuantidadeDoProduto.ResumeLayout(false);
            this.gpbQuantidadeDoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuantidade)).EndInit();
            this.gpbTipoDePagamento.ResumeLayout(false);
            this.rodape.ResumeLayout(false);
            this.rodape.PerformLayout();
            this.gpbValorPorPeso.ResumeLayout(false);
            this.gpbValorPorPeso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKilograma)).EndInit();
            this.MenuCaixa.ResumeLayout(false);
            this.MenuCaixa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCodigoDaComanda;
        private System.Windows.Forms.TextBox txtCodigoDaComanda;
        private System.Windows.Forms.GroupBox gpbCodigoDoProduto;
        private System.Windows.Forms.TextBox txtCodigoDoProduto;
        private System.Windows.Forms.GroupBox gpbValorPago;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.GroupBox gpbGerarTroco;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.GroupBox gpbTotalNocaixa;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Label lblTotalNoCaixa;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.GroupBox gpbQuantidadeDoProduto;
        private System.Windows.Forms.GroupBox gpbTipoDePagamento;
        private System.Windows.Forms.ComboBox cbbTipoDePagamento;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.StatusStrip rodape;
        private System.Windows.Forms.ToolStripStatusLabel lblProfissao;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioLogado;
        private System.Windows.Forms.GroupBox gpbValorPorPeso;
        private System.Windows.Forms.TextBox txtPesoDoProduto;
        private System.Windows.Forms.CheckBox ckbPorPeso;
        private System.Windows.Forms.ListView ltvProdutos;
        private System.Windows.Forms.PictureBox ptbValorTotalPago;
        private System.Windows.Forms.PictureBox ptbTroco;
        private System.Windows.Forms.PictureBox ptbCodigo;
        private System.Windows.Forms.PictureBox ptbCodigoDoProduto;
        private System.Windows.Forms.PictureBox ptbQuantidade;
        private System.Windows.Forms.MenuStrip MenuCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuOperacoes;
        private System.Windows.Forms.ToolStripMenuItem btnReceberCredito;
        private System.Windows.Forms.ToolStripMenuItem btnDividirComanda;
        private System.Windows.Forms.ToolStripMenuItem btnCalculadora;
        private System.Windows.Forms.ToolTip tlp;
        private System.Windows.Forms.ToolStripMenuItem btnAbrirCaixa;
        private System.Windows.Forms.ToolStripMenuItem btnFecharCaixa;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox ptbKilograma;
    }
}