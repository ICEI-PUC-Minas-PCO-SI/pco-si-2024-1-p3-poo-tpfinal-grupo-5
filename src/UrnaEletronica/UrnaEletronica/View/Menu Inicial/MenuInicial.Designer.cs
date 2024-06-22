namespace UrnaEletronica.View.Menu_Inicial
{
    partial class MenuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            cadastrarEleicao = new Button();
            cadastrarColigacao = new Button();
            cadastrarPartido = new Button();
            cadastrarCandidato = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cadastrarEleicao
            // 
            cadastrarEleicao.FlatStyle = FlatStyle.Popup;
            cadastrarEleicao.Font = new Font("Inter", 9F);
            cadastrarEleicao.ImageAlign = ContentAlignment.BottomLeft;
            cadastrarEleicao.ImageKey = "(nenhum)";
            cadastrarEleicao.Location = new Point(233, 152);
            cadastrarEleicao.Name = "cadastrarEleicao";
            cadastrarEleicao.Size = new Size(268, 41);
            cadastrarEleicao.TabIndex = 1;
            cadastrarEleicao.Text = "Cadastrar eleição";
            cadastrarEleicao.UseVisualStyleBackColor = true;
            // 
            // cadastrarColigacao
            // 
            cadastrarColigacao.FlatStyle = FlatStyle.Popup;
            cadastrarColigacao.Font = new Font("Inter", 9F);
            cadastrarColigacao.Location = new Point(233, 222);
            cadastrarColigacao.Name = "cadastrarColigacao";
            cadastrarColigacao.Size = new Size(268, 41);
            cadastrarColigacao.TabIndex = 3;
            cadastrarColigacao.Text = "Cadastrar coligação";
            cadastrarColigacao.UseVisualStyleBackColor = true;
            // 
            // cadastrarPartido
            // 
            cadastrarPartido.FlatStyle = FlatStyle.Popup;
            cadastrarPartido.Font = new Font("Inter", 9F);
            cadastrarPartido.Location = new Point(233, 290);
            cadastrarPartido.Name = "cadastrarPartido";
            cadastrarPartido.Size = new Size(268, 41);
            cadastrarPartido.TabIndex = 4;
            cadastrarPartido.Text = "Cadastrar partido";
            cadastrarPartido.UseVisualStyleBackColor = true;
            // 
            // cadastrarCandidato
            // 
            cadastrarCandidato.FlatStyle = FlatStyle.Popup;
            cadastrarCandidato.Font = new Font("Inter", 9F);
            cadastrarCandidato.Location = new Point(233, 361);
            cadastrarCandidato.Name = "cadastrarCandidato";
            cadastrarCandidato.Size = new Size(268, 41);
            cadastrarCandidato.TabIndex = 5;
            cadastrarCandidato.Text = "Cadastrar candidato";
            cadastrarCandidato.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-35, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(821, 593);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // MenuInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(731, 516);
            Controls.Add(cadastrarCandidato);
            Controls.Add(cadastrarPartido);
            Controls.Add(cadastrarColigacao);
            Controls.Add(cadastrarEleicao);
            Controls.Add(pictureBox1);
            Name = "MenuInicial";
            Text = "MenuInicial";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button cadastrarColigacao;
        private Button cadastrarPartido;
        private Button cadastrarCandidato;
        protected Button cadastrarEleicao;
        private PictureBox pictureBox1;
    }
}