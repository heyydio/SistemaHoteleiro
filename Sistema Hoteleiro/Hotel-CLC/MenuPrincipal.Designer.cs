namespace Hotel_CLC
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóspedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasESaídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.novaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadroDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.btRelatorios = new System.Windows.Forms.Button();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.btCheckIn = new System.Windows.Forms.Button();
            this.btQuadroReservas = new System.Windows.Forms.Button();
            this.btMovimentacoes = new System.Windows.Forms.Button();
            this.btProdutos = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btReservas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuProdutos,
            this.MenuMovimentacoes,
            this.MenuCheck,
            this.MenuReservas,
            this.MenuRelatorios,
            this.MenuSair,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.hóspedesToolStripMenuItem,
            this.quartosToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.MenuCadastros.Image = ((System.Drawing.Image)(resources.GetObject("MenuCadastros.Image")));
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(87, 23);
            this.MenuCadastros.Text = "&Cadastros";
            this.MenuCadastros.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.funcionariosToolStripMenuItem.Text = "&Funcionários";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // hóspedesToolStripMenuItem
            // 
            this.hóspedesToolStripMenuItem.Name = "hóspedesToolStripMenuItem";
            this.hóspedesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.hóspedesToolStripMenuItem.Text = "&Hóspedes";
            // 
            // quartosToolStripMenuItem
            // 
            this.quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            this.quartosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.quartosToolStripMenuItem.Text = "&Quartos";
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cargosToolStripMenuItem.Text = "&Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "&Fornecedores";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProdutoToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.MenuProdutos.Image = ((System.Drawing.Image)(resources.GetObject("MenuProdutos.Image")));
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(83, 23);
            this.MenuProdutos.Text = "&Produtos";
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.novoProdutoToolStripMenuItem.Text = "&Novo Produto";
            this.novoProdutoToolStripMenuItem.Click += new System.EventHandler(this.novoProdutoToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.estoqueToolStripMenuItem.Text = "&Estoque";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.novoServiçoToolStripMenuItem,
            this.entradasESaídasToolStripMenuItem});
            this.MenuMovimentacoes.Image = ((System.Drawing.Image)(resources.GetObject("MenuMovimentacoes.Image")));
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(120, 23);
            this.MenuMovimentacoes.Text = "&Movimentações";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.novaVendaToolStripMenuItem.Text = "&Nova Venda";
            // 
            // novoServiçoToolStripMenuItem
            // 
            this.novoServiçoToolStripMenuItem.Name = "novoServiçoToolStripMenuItem";
            this.novoServiçoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.novoServiçoToolStripMenuItem.Text = "&Novo Serviço";
            // 
            // entradasESaídasToolStripMenuItem
            // 
            this.entradasESaídasToolStripMenuItem.Name = "entradasESaídasToolStripMenuItem";
            this.entradasESaídasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.entradasESaídasToolStripMenuItem.Text = "&Entradas e Saídas";
            // 
            // MenuCheck
            // 
            this.MenuCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.MenuCheck.Image = ((System.Drawing.Image)(resources.GetObject("MenuCheck.Image")));
            this.MenuCheck.Name = "MenuCheck";
            this.MenuCheck.Size = new System.Drawing.Size(143, 23);
            this.MenuCheck.Text = "&Check In/ Check out";
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.checkInToolStripMenuItem.Text = "&Check In";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.checkOutToolStripMenuItem.Text = "&Check Out";
            // 
            // MenuReservas
            // 
            this.MenuReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaReservaToolStripMenuItem,
            this.quadroDeReservasToolStripMenuItem,
            this.consultarReservasToolStripMenuItem});
            this.MenuReservas.Image = ((System.Drawing.Image)(resources.GetObject("MenuReservas.Image")));
            this.MenuReservas.Name = "MenuReservas";
            this.MenuReservas.Size = new System.Drawing.Size(80, 23);
            this.MenuReservas.Text = "&Reservas";
            // 
            // novaReservaToolStripMenuItem
            // 
            this.novaReservaToolStripMenuItem.Name = "novaReservaToolStripMenuItem";
            this.novaReservaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.novaReservaToolStripMenuItem.Text = "&Nova Reserva";
            // 
            // quadroDeReservasToolStripMenuItem
            // 
            this.quadroDeReservasToolStripMenuItem.Name = "quadroDeReservasToolStripMenuItem";
            this.quadroDeReservasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.quadroDeReservasToolStripMenuItem.Text = "&Quadro de Reservas";
            // 
            // consultarReservasToolStripMenuItem
            // 
            this.consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            this.consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.consultarReservasToolStripMenuItem.Text = "&Consultar Reservas";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("MenuRelatorios.Image")));
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(87, 23);
            this.MenuRelatorios.Text = "&Relatórios";
            // 
            // MenuSair
            // 
            this.MenuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.MenuSair.Image = ((System.Drawing.Image)(resources.GetObject("MenuSair.Image")));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(54, 23);
            this.MenuSair.Text = "&Sair";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.Thistle;
            this.pnlTopo.Controls.Add(this.btRelatorios);
            this.pnlTopo.Controls.Add(this.btCheckOut);
            this.pnlTopo.Controls.Add(this.btCheckIn);
            this.pnlTopo.Controls.Add(this.btQuadroReservas);
            this.pnlTopo.Controls.Add(this.btMovimentacoes);
            this.pnlTopo.Controls.Add(this.btProdutos);
            this.pnlTopo.Controls.Add(this.pnl1);
            this.pnlTopo.Controls.Add(this.btReservas);
            this.pnlTopo.Location = new System.Drawing.Point(0, 30);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(598, 107);
            this.pnlTopo.TabIndex = 2;
            this.pnlTopo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopo_Paint);
            // 
            // btRelatorios
            // 
            this.btRelatorios.BackColor = System.Drawing.Color.Thistle;
            this.btRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRelatorios.FlatAppearance.BorderSize = 0;
            this.btRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btRelatorios.Image")));
            this.btRelatorios.Location = new System.Drawing.Point(496, 22);
            this.btRelatorios.Name = "btRelatorios";
            this.btRelatorios.Size = new System.Drawing.Size(75, 64);
            this.btRelatorios.TabIndex = 6;
            this.btRelatorios.UseVisualStyleBackColor = false;
            // 
            // btCheckOut
            // 
            this.btCheckOut.BackColor = System.Drawing.Color.Thistle;
            this.btCheckOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCheckOut.BackgroundImage")));
            this.btCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCheckOut.FlatAppearance.BorderSize = 0;
            this.btCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckOut.Location = new System.Drawing.Point(415, 22);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(75, 64);
            this.btCheckOut.TabIndex = 5;
            this.btCheckOut.UseVisualStyleBackColor = false;
            // 
            // btCheckIn
            // 
            this.btCheckIn.BackColor = System.Drawing.Color.Thistle;
            this.btCheckIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCheckIn.BackgroundImage")));
            this.btCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCheckIn.FlatAppearance.BorderSize = 0;
            this.btCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckIn.Location = new System.Drawing.Point(334, 22);
            this.btCheckIn.Name = "btCheckIn";
            this.btCheckIn.Size = new System.Drawing.Size(75, 64);
            this.btCheckIn.TabIndex = 4;
            this.btCheckIn.UseVisualStyleBackColor = false;
            // 
            // btQuadroReservas
            // 
            this.btQuadroReservas.BackColor = System.Drawing.Color.Thistle;
            this.btQuadroReservas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btQuadroReservas.BackgroundImage")));
            this.btQuadroReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btQuadroReservas.FlatAppearance.BorderSize = 0;
            this.btQuadroReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuadroReservas.Location = new System.Drawing.Point(255, 22);
            this.btQuadroReservas.Name = "btQuadroReservas";
            this.btQuadroReservas.Size = new System.Drawing.Size(75, 64);
            this.btQuadroReservas.TabIndex = 3;
            this.btQuadroReservas.UseVisualStyleBackColor = false;
            // 
            // btMovimentacoes
            // 
            this.btMovimentacoes.BackColor = System.Drawing.Color.Thistle;
            this.btMovimentacoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMovimentacoes.BackgroundImage")));
            this.btMovimentacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMovimentacoes.FlatAppearance.BorderSize = 0;
            this.btMovimentacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMovimentacoes.Location = new System.Drawing.Point(93, 22);
            this.btMovimentacoes.Name = "btMovimentacoes";
            this.btMovimentacoes.Size = new System.Drawing.Size(75, 64);
            this.btMovimentacoes.TabIndex = 1;
            this.btMovimentacoes.Text = "button2";
            this.btMovimentacoes.UseVisualStyleBackColor = false;
            // 
            // btProdutos
            // 
            this.btProdutos.BackColor = System.Drawing.Color.Thistle;
            this.btProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btProdutos.BackgroundImage")));
            this.btProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProdutos.FlatAppearance.BorderSize = 0;
            this.btProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProdutos.Location = new System.Drawing.Point(12, 22);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(75, 64);
            this.btProdutos.TabIndex = 0;
            this.btProdutos.UseVisualStyleBackColor = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Plum;
            this.pnl1.Controls.Add(this.flowLayoutPanel1);
            this.pnl1.Location = new System.Drawing.Point(604, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(196, 408);
            this.pnl1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btReservas
            // 
            this.btReservas.BackColor = System.Drawing.Color.Thistle;
            this.btReservas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReservas.BackgroundImage")));
            this.btReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btReservas.FlatAppearance.BorderSize = 0;
            this.btReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReservas.Location = new System.Drawing.Point(174, 22);
            this.btReservas.Name = "btReservas";
            this.btReservas.Size = new System.Drawing.Size(75, 64);
            this.btReservas.TabIndex = 2;
            this.btReservas.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(597, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 428);
            this.panel1.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Quartos ocupados: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "13:00:00";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nome:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Quartos disponíveis:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "DATA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "10/11/2023";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reservas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Morax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DATA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "13:00:00";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox3.BackgroundImage = global::Hotel_CLC.Properties.Resources.iconreservas;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(69, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 78);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 78);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(69, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 78);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(761, 4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(27, 23);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "X";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTEL PORTIOLI";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuCheck;
        private System.Windows.Forms.ToolStripMenuItem MenuReservas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóspedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasESaídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadroDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.Button btRelatorios;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Button btCheckIn;
        private System.Windows.Forms.Button btQuadroReservas;
        private System.Windows.Forms.Button btMovimentacoes;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Button btReservas;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btSair;
    }
}