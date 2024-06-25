namespace UrnaEletronica.View.Menu_Inicial
{
    partial class MenuPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            cadastrarEleicao = new Button();
            cadastrarColigacao = new Button();
            cadastrarPartido = new Button();
            cadastrarCandidato = new Button();
            pictureBox1 = new PictureBox();
            iniciaEleicao = new Button();
            btnResultado = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cadastrarEleicao
            // 
            cadastrarEleicao.FlatStyle = FlatStyle.Popup;
            cadastrarEleicao.Font = new Font("Microsoft Sans Serif", 9F);
            cadastrarEleicao.ImageAlign = ContentAlignment.BottomLeft;
            cadastrarEleicao.ImageKey = "(nenhum)";
            cadastrarEleicao.Location = new Point(204, 114);
            cadastrarEleicao.Margin = new Padding(3, 2, 3, 2);
            cadastrarEleicao.Name = "cadastrarEleicao";
            cadastrarEleicao.Size = new Size(234, 31);
            cadastrarEleicao.TabIndex = 1;
            cadastrarEleicao.Text = "Cadastrar eleição";
            cadastrarEleicao.UseVisualStyleBackColor = true;
            cadastrarEleicao.Click += cadastrarEleicao_Click;
            // 
            // cadastrarColigacao
            // 
            cadastrarColigacao.FlatStyle = FlatStyle.Popup;
            cadastrarColigacao.Font = new Font("Microsoft Sans Serif", 9F);
            cadastrarColigacao.Location = new Point(204, 166);
            cadastrarColigacao.Margin = new Padding(3, 2, 3, 2);
            cadastrarColigacao.Name = "cadastrarColigacao";
            cadastrarColigacao.Size = new Size(234, 31);
            cadastrarColigacao.TabIndex = 3;
            cadastrarColigacao.Text = "Cadastrar coligação";
            cadastrarColigacao.UseVisualStyleBackColor = true;
            cadastrarColigacao.Click += cadastrarColigacao_Click;
            // 
            // cadastrarPartido
            // 
            cadastrarPartido.FlatStyle = FlatStyle.Popup;
            cadastrarPartido.Font = new Font("Microsoft Sans Serif", 9F);
            cadastrarPartido.Location = new Point(204, 218);
            cadastrarPartido.Margin = new Padding(3, 2, 3, 2);
            cadastrarPartido.Name = "cadastrarPartido";
            cadastrarPartido.Size = new Size(234, 31);
            cadastrarPartido.TabIndex = 4;
            cadastrarPartido.Text = "Cadastrar partido";
            cadastrarPartido.UseVisualStyleBackColor = true;
            cadastrarPartido.Click += cadastrarPartido_Click;
            // 
            // cadastrarCandidato
            // 
            cadastrarCandidato.FlatStyle = FlatStyle.Popup;
            cadastrarCandidato.Font = new Font("Microsoft Sans Serif", 9F);
            cadastrarCandidato.Location = new Point(204, 271);
            cadastrarCandidato.Margin = new Padding(3, 2, 3, 2);
            cadastrarCandidato.Name = "cadastrarCandidato";
            cadastrarCandidato.Size = new Size(234, 31);
            cadastrarCandidato.TabIndex = 5;
            cadastrarCandidato.Text = "Cadastrar candidato";
            cadastrarCandidato.UseVisualStyleBackColor = true;
            cadastrarCandidato.Click += cadastrarCandidato_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-45, -5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(718, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // iniciaEleicao
            // 
            iniciaEleicao.FlatStyle = FlatStyle.Popup;
            iniciaEleicao.Font = new Font("Microsoft Sans Serif", 9F);
            iniciaEleicao.ImageAlign = ContentAlignment.BottomLeft;
            iniciaEleicao.ImageKey = "(nenhum)";
            iniciaEleicao.Location = new Point(204, 57);
            iniciaEleicao.Margin = new Padding(3, 2, 3, 2);
            iniciaEleicao.Name = "iniciaEleicao";
            iniciaEleicao.Size = new Size(234, 31);
            iniciaEleicao.TabIndex = 7;
            iniciaEleicao.Text = "Iniciar eleicao";
            iniciaEleicao.UseVisualStyleBackColor = true;
            iniciaEleicao.Click += iniciaEleicao_Click;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(204, 319);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(234, 34);
            btnResultado.TabIndex = 8;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(640, 387);
            Controls.Add(btnResultado);
            Controls.Add(iniciaEleicao);
            Controls.Add(cadastrarCandidato);
            Controls.Add(cadastrarPartido);
            Controls.Add(cadastrarColigacao);
            Controls.Add(cadastrarEleicao);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipalForm";
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
        protected Button iniciaEleicao;
        private Button btnResultado;
    }
}