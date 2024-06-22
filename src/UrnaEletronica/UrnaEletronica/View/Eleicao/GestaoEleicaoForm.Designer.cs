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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoEleicaoForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, -29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 111, 51);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 81);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(19, 23);
            label4.Name = "label4";
            label4.Size = new Size(310, 36);
            label4.TabIndex = 0;
            label4.Text = "Gestão das Eleições";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(69, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 27);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(560, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(313, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 27);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 9F);
            label3.Location = new Point(560, 129);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 14;
            label3.Text = "Número";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F);
            label2.Location = new Point(313, 129);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 13;
            label2.Text = "Partido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 9F);
            label1.Location = new Point(69, 129);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 12;
            label1.Text = "Nome";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(35, 92, 40);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Inter", 9F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(574, 523);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(181, 36);
            button4.TabIndex = 22;
            button4.Text = "Salvar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(184, 16, 20);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Inter", 9F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(69, 523);
            button3.Name = "button3";
            button3.Size = new Size(159, 36);
            button3.TabIndex = 21;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(686, 188);
            dataGridView1.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Inter", 9F);
            button2.Location = new Point(426, 236);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(169, 36);
            button2.TabIndex = 19;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Inter", 9F);
            button1.Location = new Point(211, 236);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(181, 36);
            button1.TabIndex = 18;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            // 
            // GestaoEleicaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(817, 606);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "GestaoEleicaoForm";
            Text = "GestaoEleicaoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
    }
}