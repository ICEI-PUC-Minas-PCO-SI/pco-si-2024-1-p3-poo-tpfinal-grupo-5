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
<<<<<<< HEAD
            button1.Location = new Point(190, 178);
=======
            button1.Location = new Point(66, 178);
>>>>>>> origin/CrudRafael
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
<<<<<<< HEAD
            button2.Location = new Point(378, 178);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(148, 27);
=======
            button2.Location = new Point(508, 178);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(158, 27);
>>>>>>> origin/CrudRafael
            button2.TabIndex = 1;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // dgvColigacao
            // 
<<<<<<< HEAD
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 232);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 141);
            dataGridView1.TabIndex = 2;
=======
            dgvColigacao.BackgroundColor = Color.LightGray;
            dgvColigacao.BorderStyle = BorderStyle.Fixed3D;
            dgvColigacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColigacao.Location = new Point(66, 232);
            dgvColigacao.Margin = new Padding(3, 2, 3, 2);
            dgvColigacao.Name = "dgvColigacao";
            dgvColigacao.RowHeadersWidth = 51;
            dgvColigacao.Size = new Size(600, 141);
            dgvColigacao.TabIndex = 2;
>>>>>>> origin/CrudRafael
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
<<<<<<< HEAD
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(279, 95);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Partido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(495, 95);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Número";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(279, 112);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(495, 112);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(66, 112);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 9;
=======
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(66, 112);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(171, 23);
            txtNome.TabIndex = 9;
>>>>>>> origin/CrudRafael
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
<<<<<<< HEAD
            button4.Location = new Point(508, 393);
=======
            button4.Location = new Point(508, 107);
>>>>>>> origin/CrudRafael
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