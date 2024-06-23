namespace UrnaEletronica.View.Eleicao
{
    partial class GestaoEleicaoForm
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
            txtAno = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnEnviar = new Button();
            btnExcluir = new Button();
            dgvEleicao = new DataGridView();
            btnEditar = new Button();
            button1 = new Button();
            txtTipo = new TextBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEleicao).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 111, 51);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 61);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(254, 29);
            label4.TabIndex = 0;
            label4.Text = "Gestão das Eleições";
            // 
            // txtAno
            // 
            txtAno.BorderStyle = BorderStyle.FixedSingle;
            txtAno.Location = new Point(60, 114);
            txtAno.Margin = new Padding(3, 2, 3, 2);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(170, 23);
            txtAno.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(274, 97);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 13;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(60, 97);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 12;
            label1.Text = "Ano";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(35, 92, 40);
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Microsoft Sans Serif", 9F);
            btnEnviar.ForeColor = SystemColors.ButtonHighlight;
            btnEnviar.Location = new Point(512, 110);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.RightToLeft = RightToLeft.No;
            btnEnviar.Size = new Size(148, 27);
            btnEnviar.TabIndex = 22;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += button4_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(184, 16, 20);
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9F);
            btnExcluir.ForeColor = SystemColors.ActiveCaptionText;
            btnExcluir.Location = new Point(60, 392);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(139, 27);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // dgvEleicao
            // 
            dgvEleicao.BackgroundColor = Color.LightGray;
            dgvEleicao.BorderStyle = BorderStyle.Fixed3D;
            dgvEleicao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEleicao.Location = new Point(60, 231);
            dgvEleicao.Margin = new Padding(3, 2, 3, 2);
            dgvEleicao.Name = "dgvEleicao";
            dgvEleicao.RowHeadersWidth = 51;
            dgvEleicao.Size = new Size(600, 141);
            dgvEleicao.TabIndex = 20;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ButtonHighlight;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Microsoft Sans Serif", 9F);
            btnEditar.Location = new Point(512, 177);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.RightToLeft = RightToLeft.No;
            btnEditar.Size = new Size(148, 27);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.Location = new Point(60, 177);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(148, 27);
            button1.TabIndex = 18;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTipo
            // 
            txtTipo.BorderStyle = BorderStyle.FixedSingle;
            txtTipo.Location = new Point(274, 113);
            txtTipo.Margin = new Padding(3, 2, 3, 2);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(171, 23);
            txtTipo.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(289, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 23;
            // 
            // GestaoEleicaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(715, 454);
            Controls.Add(comboBox1);
            Controls.Add(btnEnviar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvEleicao);
            Controls.Add(btnEditar);
            Controls.Add(button1);
            Controls.Add(txtAno);
            Controls.Add(txtTipo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestaoEleicaoForm";
            Text = "GestaoEleicaoForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEleicao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private TextBox txtAno;
        private Label label2;
        private Label label1;
        private Button btnEnviar;
        private Button btnExcluir;
        private DataGridView dgvEleicao;
        private Button btnEditar;
        private Button button1;
        private TextBox txtTipo;
        private ComboBox comboBox1;
    }
}