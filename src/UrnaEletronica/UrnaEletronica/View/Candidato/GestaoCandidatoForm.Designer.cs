namespace UrnaEletronica.View.Candidato
{
    partial class GestaoCandidatoForm
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
            panel1 = new Panel();
            label4 = new Label();
            btnEnviar = new Button();
            btnExcluir = new Button();
            dgvCandidatos = new DataGridView();
            btnEditar = new Button();
            button1 = new Button();
            txtNumeroPartido = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtApelido = new TextBox();
            comboBoxCandidatos = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            txtNumero = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 111, 51);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 61);
            panel1.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(284, 29);
            label4.TabIndex = 0;
            label4.Text = "Gestão das Candidatos";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(35, 92, 40);
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Microsoft Sans Serif", 9F);
            btnEnviar.ForeColor = SystemColors.ButtonHighlight;
            btnEnviar.Location = new Point(512, 405);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.RightToLeft = RightToLeft.No;
            btnEnviar.Size = new Size(148, 27);
            btnEnviar.TabIndex = 32;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(184, 16, 20);
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9F);
            btnExcluir.ForeColor = SystemColors.ActiveCaptionText;
            btnExcluir.Location = new Point(60, 405);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(139, 27);
            btnExcluir.TabIndex = 31;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvCandidatos
            // 
            dgvCandidatos.BackgroundColor = Color.LightGray;
            dgvCandidatos.BorderStyle = BorderStyle.Fixed3D;
            dgvCandidatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidatos.Location = new Point(60, 244);
            dgvCandidatos.Margin = new Padding(3, 2, 3, 2);
            dgvCandidatos.Name = "dgvCandidatos";
            dgvCandidatos.RowHeadersWidth = 51;
            dgvCandidatos.Size = new Size(600, 141);
            dgvCandidatos.TabIndex = 30;
            dgvCandidatos.CellContentClick += dgvCandidatos_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ButtonHighlight;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Microsoft Sans Serif", 9F);
            btnEditar.Location = new Point(512, 190);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.RightToLeft = RightToLeft.No;
            btnEditar.Size = new Size(148, 27);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.Location = new Point(60, 190);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(148, 27);
            button1.TabIndex = 28;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNumeroPartido
            // 
            txtNumeroPartido.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroPartido.Enabled = false;
            txtNumeroPartido.Location = new Point(159, 127);
            txtNumeroPartido.Margin = new Padding(3, 2, 3, 2);
            txtNumeroPartido.Name = "txtNumeroPartido";
            txtNumeroPartido.Size = new Size(63, 23);
            txtNumeroPartido.TabIndex = 27;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(376, 126);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(127, 23);
            txtNome.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(376, 109);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 25;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(159, 109);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 24;
            label1.Text = "Nª partido";
            // 
            // txtApelido
            // 
            txtApelido.BorderStyle = BorderStyle.FixedSingle;
            txtApelido.Location = new Point(533, 126);
            txtApelido.Margin = new Padding(3, 2, 3, 2);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(127, 23);
            txtApelido.TabIndex = 33;
            // 
            // comboBoxCandidatos
            // 
            comboBoxCandidatos.FormattingEnabled = true;
            comboBoxCandidatos.Location = new Point(60, 126);
            comboBoxCandidatos.Name = "comboBoxCandidatos";
            comboBoxCandidatos.Size = new Size(63, 23);
            comboBoxCandidatos.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(533, 109);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 35;
            label3.Text = "Apelido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(60, 108);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 36;
            label5.Text = "Partido";
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(265, 126);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(63, 23);
            txtNumero.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(265, 109);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 38;
            label6.Text = "Número";
            // 
            // GestaoCandidatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 446);
            Controls.Add(label6);
            Controls.Add(txtNumero);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(comboBoxCandidatos);
            Controls.Add(txtApelido);
            Controls.Add(panel1);
            Controls.Add(btnEnviar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvCandidatos);
            Controls.Add(btnEditar);
            Controls.Add(button1);
            Controls.Add(txtNumeroPartido);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestaoCandidatoForm";
            Text = "GestaoCandidatoForm";
            Load += GestaoCandidatoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button btnEnviar;
        private Button btnExcluir;
        private DataGridView dgvCandidatos;
        private Button btnEditar;
        private Button button1;
        private TextBox txtNumeroPartido;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private TextBox txtApelido;
        private ComboBox comboBoxCandidatos;
        private Label label3;
        private Label label5;
        private TextBox txtNumero;
        private Label label6;
    }
}