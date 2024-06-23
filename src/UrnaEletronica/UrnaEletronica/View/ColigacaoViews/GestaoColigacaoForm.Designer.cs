namespace UrnaEletronica.View.Coligacao
{
    partial class GestaoColigacaoForm
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
            button1 = new Button();
            button2 = new Button();
            dgvColigacao = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            txtNome = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvColigacao).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.Location = new Point(66, 178);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(158, 27);
            button1.TabIndex = 0;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 9F);
            button2.Location = new Point(508, 178);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(158, 27);
            button2.TabIndex = 1;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // dgvColigacao
            // 
            dgvColigacao.BackgroundColor = Color.LightGray;
            dgvColigacao.BorderStyle = BorderStyle.Fixed3D;
            dgvColigacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColigacao.Location = new Point(66, 232);
            dgvColigacao.Margin = new Padding(3, 2, 3, 2);
            dgvColigacao.Name = "dgvColigacao";
            dgvColigacao.RowHeadersWidth = 51;
            dgvColigacao.Size = new Size(600, 141);
            dgvColigacao.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(66, 95);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(184, 16, 20);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 9F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(66, 393);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(139, 27);
            button3.TabIndex = 4;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(66, 112);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(171, 23);
            txtNome.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 111, 51);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 61);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(20, 17);
            label4.Name = "label4";
            label4.Size = new Size(284, 29);
            label4.TabIndex = 0;
            label4.Text = "Gestão das Coligações";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(35, 92, 40);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Microsoft Sans Serif", 9F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(508, 107);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(158, 27);
            button4.TabIndex = 11;
            button4.Text = "Enviar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // GestaoColigacaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(715, 454);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(txtNome);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(dgvColigacao);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestaoColigacaoForm";
            Text = "GestaoColigacaoForm";
            ((System.ComponentModel.ISupportInitialize)dgvColigacao).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dgvColigacao;
        private Label label1;
        private Button button3;
        private TextBox txtNome;
        private Panel panel1;
        private Label label4;
        private Button button4;
    }
}