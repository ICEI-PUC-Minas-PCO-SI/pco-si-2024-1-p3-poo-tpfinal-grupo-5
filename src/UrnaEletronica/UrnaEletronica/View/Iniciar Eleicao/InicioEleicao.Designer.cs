namespace UrnaEletronica.View.Iniciar_Eleicao
{
    partial class InicioEleicao
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
            textBoxID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnStatus = new Label();
            lblStatus = new Label();
            btnInicia = new Button();
            lblTipo = new Label();
            label8 = new Label();
            lblAno = new Label();
            label6 = new Label();
            lblId = new Label();
            label4 = new Label();
            label3 = new Label();
            btnPesquisar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(14, 165);
            textBoxID.Multiline = true;
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(259, 31);
            textBoxID.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(14, 109);
            label1.Name = "label1";
            label1.Size = new Size(218, 29);
            label1.TabIndex = 13;
            label1.Text = "Pesquise por ano";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(181, 29);
            label2.TabIndex = 0;
            label2.Text = "Iniciar votação";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 111, 51);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-2, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 65);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnStatus);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(btnInicia);
            panel2.Controls.Add(lblTipo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblAno);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblId);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(15, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 162);
            panel2.TabIndex = 15;
            // 
            // btnStatus
            // 
            btnStatus.AutoSize = true;
            btnStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = SystemColors.ActiveCaptionText;
            btnStatus.Location = new Point(357, 55);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(62, 20);
            btnStatus.TabIndex = 25;
            btnStatus.Text = "Status";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ActiveCaptionText;
            lblStatus.Location = new Point(357, 98);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(126, 24);
            lblStatus.TabIndex = 24;
            lblStatus.Text = "Não iniciada";
            // 
            // btnInicia
            // 
            btnInicia.BackColor = SystemColors.ActiveCaption;
            btnInicia.Enabled = false;
            btnInicia.FlatStyle = FlatStyle.Popup;
            btnInicia.Font = new Font("Microsoft Sans Serif", 9F);
            btnInicia.ImageAlign = ContentAlignment.BottomLeft;
            btnInicia.ImageKey = "(nenhum)";
            btnInicia.Location = new Point(506, 91);
            btnInicia.Margin = new Padding(3, 2, 3, 2);
            btnInicia.Name = "btnInicia";
            btnInicia.Size = new Size(165, 31);
            btnInicia.TabIndex = 16;
            btnInicia.Text = "Iniciar votação";
            btnInicia.UseVisualStyleBackColor = false;
            btnInicia.Click += btnInicia_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.ForeColor = SystemColors.ActiveCaptionText;
            lblTipo.Location = new Point(251, 98);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(21, 24);
            lblTipo.TabIndex = 22;
            lblTipo.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(251, 55);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 21;
            label8.Text = "Tipo";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAno.ForeColor = SystemColors.ActiveCaptionText;
            lblAno.Location = new Point(95, 98);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(54, 24);
            lblAno.TabIndex = 20;
            lblAno.Text = "0000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(95, 55);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 19;
            label6.Text = "Ano";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.ActiveCaptionText;
            lblId.Location = new Point(3, 98);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 24);
            lblId.TabIndex = 18;
            lblId.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(3, 55);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 17;
            label4.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(143, 24);
            label3.TabIndex = 16;
            label3.Text = "Dados eleição";
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9F);
            btnPesquisar.ImageAlign = ContentAlignment.BottomLeft;
            btnPesquisar.ImageKey = "(nenhum)";
            btnPesquisar.Location = new Point(521, 165);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(165, 31);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // InicioEleicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBoxID);
            Controls.Add(btnPesquisar);
            Name = "InicioEleicao";
            Text = "InicioEleicao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxID;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        protected Button btnInicia;
        private Label lblTipo;
        private Label label8;
        private Label lblAno;
        private Label label6;
        private Label lblId;
        private Label label4;
        private Label label3;
        protected Button btnPesquisar;
        private Label lblStatus;
        private Label btnStatus;
    }
}