namespace UrnaEletronica.View.Votacao
{
    partial class Urna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urna));
            panelPrincipal = new Panel();
            lblPartidoCandidato = new Label();
            lblNomeCandidato = new Label();
            label3 = new Label();
            label2 = new Label();
            picFotoCandidato = new PictureBox();
            txtVoto = new TextBox();
            label1 = new Label();
            tipoCandidato = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            btnBranco = new Button();
            btnCorrige = new Button();
            btnConfirma = new Button();
            btn_terminarVotacao = new Button();
            lblAno = new Label();
            Tipo = new Label();
            test = new Label();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoCandidato).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(lblPartidoCandidato);
            panelPrincipal.Controls.Add(lblNomeCandidato);
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(picFotoCandidato);
            panelPrincipal.Controls.Add(txtVoto);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(tipoCandidato);
            panelPrincipal.Location = new Point(35, 197);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(408, 229);
            panelPrincipal.TabIndex = 0;
            // 
            // lblPartidoCandidato
            // 
            lblPartidoCandidato.AutoSize = true;
            lblPartidoCandidato.Location = new Point(72, 174);
            lblPartidoCandidato.Name = "lblPartidoCandidato";
            lblPartidoCandidato.Size = new Size(16, 15);
            lblPartidoCandidato.TabIndex = 12;
            lblPartidoCandidato.Text = "...";
            // 
            // lblNomeCandidato
            // 
            lblNomeCandidato.AutoSize = true;
            lblNomeCandidato.Location = new Point(72, 142);
            lblNomeCandidato.Name = "lblNomeCandidato";
            lblNomeCandidato.Size = new Size(16, 15);
            lblNomeCandidato.TabIndex = 11;
            lblNomeCandidato.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 174);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 10;
            label3.Text = "Partido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 144);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Nome:";
            // 
            // picFotoCandidato
            // 
            picFotoCandidato.Location = new Point(261, 20);
            picFotoCandidato.Name = "picFotoCandidato";
            picFotoCandidato.Size = new Size(132, 139);
            picFotoCandidato.TabIndex = 8;
            picFotoCandidato.TabStop = false;
            // 
            // txtVoto
            // 
            txtVoto.Enabled = false;
            txtVoto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVoto.Location = new Point(13, 88);
            txtVoto.Name = "txtVoto";
            txtVoto.Size = new Size(200, 33);
            txtVoto.TabIndex = 3;
            txtVoto.TextChanged += txtVoto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 70);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Número:";
            label1.Click += label1_Click;
            // 
            // tipoCandidato
            // 
            tipoCandidato.Enabled = false;
            tipoCandidato.Location = new Point(70, 20);
            tipoCandidato.Name = "tipoCandidato";
            tipoCandidato.Size = new Size(113, 23);
            tipoCandidato.TabIndex = 1;
            tipoCandidato.Text = "PRESIDENTE";
            tipoCandidato.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(489, 239);
            button1.Name = "button1";
            button1.Size = new Size(38, 27);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(536, 239);
            button2.Name = "button2";
            button2.Size = new Size(38, 27);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(591, 239);
            button3.Name = "button3";
            button3.Size = new Size(38, 27);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(489, 282);
            button4.Name = "button4";
            button4.Size = new Size(38, 27);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.Window;
            button5.Location = new Point(535, 282);
            button5.Name = "button5";
            button5.Size = new Size(38, 27);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = SystemColors.Window;
            button6.Location = new Point(591, 281);
            button6.Name = "button6";
            button6.Size = new Size(38, 27);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = SystemColors.Window;
            button7.Location = new Point(489, 327);
            button7.Name = "button7";
            button7.Size = new Size(38, 27);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(64, 64, 64);
            button8.FlatStyle = FlatStyle.Popup;
            button8.ForeColor = SystemColors.Window;
            button8.Location = new Point(536, 327);
            button8.Name = "button8";
            button8.Size = new Size(38, 27);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(64, 64, 64);
            button9.FlatStyle = FlatStyle.Popup;
            button9.ForeColor = SystemColors.Window;
            button9.Location = new Point(589, 325);
            button9.Name = "button9";
            button9.Size = new Size(38, 27);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(64, 64, 64);
            button10.FlatStyle = FlatStyle.Popup;
            button10.ForeColor = SystemColors.Window;
            button10.Location = new Point(538, 362);
            button10.Name = "button10";
            button10.Size = new Size(38, 27);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // btnBranco
            // 
            btnBranco.Cursor = Cursors.Hand;
            btnBranco.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBranco.Location = new Point(468, 402);
            btnBranco.Name = "btnBranco";
            btnBranco.Size = new Size(52, 28);
            btnBranco.TabIndex = 11;
            btnBranco.Text = "BRANCO";
            btnBranco.UseVisualStyleBackColor = true;
            btnBranco.Click += btnBranco_Click;
            // 
            // btnCorrige
            // 
            btnCorrige.BackColor = Color.FromArgb(255, 128, 0);
            btnCorrige.Cursor = Cursors.Hand;
            btnCorrige.FlatStyle = FlatStyle.Flat;
            btnCorrige.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorrige.Location = new Point(526, 400);
            btnCorrige.Name = "btnCorrige";
            btnCorrige.Size = new Size(55, 30);
            btnCorrige.TabIndex = 12;
            btnCorrige.Text = "CORRIGE";
            btnCorrige.UseVisualStyleBackColor = false;
            btnCorrige.Click += btnCorrige_Click;
            // 
            // btnConfirma
            // 
            btnConfirma.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirma.Cursor = Cursors.Hand;
            btnConfirma.FlatStyle = FlatStyle.Flat;
            btnConfirma.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirma.Location = new Point(591, 393);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(56, 37);
            btnConfirma.TabIndex = 13;
            btnConfirma.Text = "CONFIRMA";
            btnConfirma.TextAlign = ContentAlignment.TopCenter;
            btnConfirma.UseVisualStyleBackColor = false;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // btn_terminarVotacao
            // 
            btn_terminarVotacao.Location = new Point(538, 12);
            btn_terminarVotacao.Name = "btn_terminarVotacao";
            btn_terminarVotacao.Size = new Size(130, 23);
            btn_terminarVotacao.TabIndex = 14;
            btn_terminarVotacao.Text = "Terminar votação";
            btn_terminarVotacao.UseVisualStyleBackColor = true;
            btn_terminarVotacao.Click += btn_terminarVotacao_Click;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAno.ForeColor = SystemColors.ActiveCaptionText;
            lblAno.Location = new Point(135, 5);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(181, 29);
            lblAno.TabIndex = 15;
            lblAno.Text = "Iniciar votação";
            // 
            // Tipo
            // 
            Tipo.AutoSize = true;
            Tipo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tipo.ForeColor = SystemColors.ActiveCaptionText;
            Tipo.Location = new Point(346, 5);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(181, 29);
            Tipo.TabIndex = 16;
            Tipo.Text = "Iniciar votação";
            // 
            // test
            // 
            test.AutoSize = true;
            test.Location = new Point(609, 75);
            test.Name = "test";
            test.Size = new Size(38, 15);
            test.TabIndex = 17;
            test.Text = "label4";
            // 
            // Urna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(696, 450);
            Controls.Add(test);
            Controls.Add(Tipo);
            Controls.Add(lblAno);
            Controls.Add(btn_terminarVotacao);
            Controls.Add(btnConfirma);
            Controls.Add(btnCorrige);
            Controls.Add(btnBranco);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panelPrincipal);
            Name = "Urna";
            Text = "Urna";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoCandidato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private TextBox tipoCandidato;
        private Label label1;
        private TextBox txtVoto;
        private Label lblPartidoCandidato;
        private Label lblNomeCandidato;
        private Label label3;
        private Label label2;
        private PictureBox picFotoCandidato;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btnBranco;
        private Button btnCorrige;
        private Button btnConfirma;
        private Button btn_terminarVotacao;
        private Label lblAno;
        private Label Tipo;
        private Label test;
    }
}