namespace Hotel_CLC.Cadastros
{
    partial class frFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.rbBuscarCPF = new System.Windows.Forms.RadioButton();
            this.rbBuscarNome = new System.Windows.Forms.RadioButton();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbBuscarCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbBuscarNome = new System.Windows.Forms.TextBox();
            this.dgvLerDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo:";
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(81, 74);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(414, 20);
            this.tbNome.TabIndex = 4;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Enabled = false;
            this.tbEndereco.Location = new System.Drawing.Point(108, 100);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(387, 20);
            this.tbEndereco.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Enabled = false;
            this.mtbCPF.Location = new System.Drawing.Point(583, 98);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(202, 20);
            this.mtbCPF.TabIndex = 10;
            // 
            // btNovo
            // 
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNovo.FlatAppearance.BorderSize = 0;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.Location = new System.Drawing.Point(194, 375);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 71);
            this.btNovo.TabIndex = 0;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Enabled = false;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(307, 375);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 71);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.Location = new System.Drawing.Point(420, 375);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 71);
            this.btEditar.TabIndex = 13;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(533, 375);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 71);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buscar:";
            // 
            // cbCargo
            // 
            this.cbCargo.Enabled = false;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(81, 126);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(414, 21);
            this.cbCargo.TabIndex = 17;
            // 
            // rbBuscarCPF
            // 
            this.rbBuscarCPF.AutoSize = true;
            this.rbBuscarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBuscarCPF.Location = new System.Drawing.Point(479, 32);
            this.rbBuscarCPF.Name = "rbBuscarCPF";
            this.rbBuscarCPF.Size = new System.Drawing.Size(52, 21);
            this.rbBuscarCPF.TabIndex = 18;
            this.rbBuscarCPF.TabStop = true;
            this.rbBuscarCPF.Text = "CPF";
            this.rbBuscarCPF.UseVisualStyleBackColor = true;
            this.rbBuscarCPF.CheckedChanged += new System.EventHandler(this.rbBuscarCPF_CheckedChanged);
            // 
            // rbBuscarNome
            // 
            this.rbBuscarNome.AutoSize = true;
            this.rbBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBuscarNome.Location = new System.Drawing.Point(468, 4);
            this.rbBuscarNome.Name = "rbBuscarNome";
            this.rbBuscarNome.Size = new System.Drawing.Size(63, 21);
            this.rbBuscarNome.TabIndex = 19;
            this.rbBuscarNome.TabStop = true;
            this.rbBuscarNome.Text = "Nome";
            this.rbBuscarNome.UseVisualStyleBackColor = true;
            this.rbBuscarNome.CheckedChanged += new System.EventHandler(this.rbBuscarNome_CheckedChanged);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Enabled = false;
            this.mtbTelefone.Location = new System.Drawing.Point(584, 127);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(202, 20);
            this.mtbTelefone.TabIndex = 20;
            // 
            // mtbBuscarCPF
            // 
            this.mtbBuscarCPF.Location = new System.Drawing.Point(537, 30);
            this.mtbBuscarCPF.Mask = "000,000,000-00";
            this.mtbBuscarCPF.Name = "mtbBuscarCPF";
            this.mtbBuscarCPF.Size = new System.Drawing.Size(248, 20);
            this.mtbBuscarCPF.TabIndex = 21;
            // 
            // tbBuscarNome
            // 
            this.tbBuscarNome.Location = new System.Drawing.Point(537, 4);
            this.tbBuscarNome.Name = "tbBuscarNome";
            this.tbBuscarNome.Size = new System.Drawing.Size(248, 20);
            this.tbBuscarNome.TabIndex = 22;
            // 
            // dgvLerDados
            // 
            this.dgvLerDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLerDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLerDados.Location = new System.Drawing.Point(24, 153);
            this.dgvLerDados.Name = "dgvLerDados";
            this.dgvLerDados.Size = new System.Drawing.Size(761, 216);
            this.dgvLerDados.TabIndex = 23;
            this.dgvLerDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLerDados_CellContentClick);
            // 
            // frFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLerDados);
            this.Controls.Add(this.tbBuscarNome);
            this.Controls.Add(this.mtbBuscarCPF);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.rbBuscarNome);
            this.Controls.Add(this.rbBuscarCPF);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frFuncionarios";
            this.Text = "CADASTRO DE FUNCIONÁRIOS";
            this.Load += new System.EventHandler(this.frFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.RadioButton rbBuscarCPF;
        private System.Windows.Forms.RadioButton rbBuscarNome;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbBuscarCPF;
        private System.Windows.Forms.TextBox tbBuscarNome;
        private System.Windows.Forms.DataGridView dgvLerDados;
    }
}