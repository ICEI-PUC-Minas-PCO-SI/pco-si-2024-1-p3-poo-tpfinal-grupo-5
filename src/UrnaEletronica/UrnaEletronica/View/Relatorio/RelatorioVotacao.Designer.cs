namespace UrnaEletronica.View.Relatorio
{
    partial class RelatorioVotacao
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
            label5 = new Label();
            btnCarregaDados = new Button();
            dataGridResultado = new DataGridView();
            comboCargo = new ComboBox();
            btnVagas = new Button();
            dataGridViewCarregaVagas = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResultado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarregaVagas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 111, 51);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 61);
            panel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(257, 29);
            label4.TabIndex = 0;
            label4.Text = "Relatório da Votação";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 86);
            label5.Name = "label5";
            label5.Size = new Size(183, 26);
            label5.TabIndex = 30;
            label5.Text = "Escolha o cargo";
            // 
            // btnCarregaDados
            // 
            btnCarregaDados.BackColor = SystemColors.ButtonHighlight;
            btnCarregaDados.Cursor = Cursors.Hand;
            btnCarregaDados.FlatStyle = FlatStyle.Popup;
            btnCarregaDados.Font = new Font("Microsoft Sans Serif", 9F);
            btnCarregaDados.Location = new Point(414, 111);
            btnCarregaDados.Margin = new Padding(3, 2, 3, 2);
            btnCarregaDados.Name = "btnCarregaDados";
            btnCarregaDados.RightToLeft = RightToLeft.No;
            btnCarregaDados.Size = new Size(118, 27);
            btnCarregaDados.TabIndex = 40;
            btnCarregaDados.Text = "Carrega Dados";
            btnCarregaDados.UseVisualStyleBackColor = false;
            btnCarregaDados.Click += button2_Click;
            // 
            // dataGridResultado
            // 
            dataGridResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResultado.Location = new Point(45, 182);
            dataGridResultado.Name = "dataGridResultado";
            dataGridResultado.Size = new Size(642, 217);
            dataGridResultado.TabIndex = 41;
            // 
            // comboCargo
            // 
            comboCargo.FormattingEnabled = true;
            comboCargo.Location = new Point(45, 115);
            comboCargo.Name = "comboCargo";
            comboCargo.Size = new Size(240, 23);
            comboCargo.TabIndex = 42;
            // 
            // btnVagas
            // 
            btnVagas.BackColor = SystemColors.ButtonHighlight;
            btnVagas.Cursor = Cursors.Hand;
            btnVagas.FlatStyle = FlatStyle.Popup;
            btnVagas.Font = new Font("Microsoft Sans Serif", 9F);
            btnVagas.Location = new Point(414, 465);
            btnVagas.Margin = new Padding(3, 2, 3, 2);
            btnVagas.Name = "btnVagas";
            btnVagas.RightToLeft = RightToLeft.No;
            btnVagas.Size = new Size(118, 27);
            btnVagas.TabIndex = 43;
            btnVagas.Text = "Carrega Vagas";
            btnVagas.UseVisualStyleBackColor = false;
            btnVagas.Click += btnVagas_Click;
            // 
            // dataGridViewCarregaVagas
            // 
            dataGridViewCarregaVagas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarregaVagas.Location = new Point(45, 512);
            dataGridViewCarregaVagas.Name = "dataGridViewCarregaVagas";
            dataGridViewCarregaVagas.Size = new Size(642, 217);
            dataGridViewCarregaVagas.TabIndex = 44;
            // 
            // RelatorioVotacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 1061);
            Controls.Add(dataGridViewCarregaVagas);
            Controls.Add(btnVagas);
            Controls.Add(comboCargo);
            Controls.Add(dataGridResultado);
            Controls.Add(btnCarregaDados);
            Controls.Add(label5);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RelatorioVotacao";
            Text = "RelatorioVotacao";
            Load += RelatorioVotacao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResultado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarregaVagas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Button btnCarregaDados;
        private DataGridView dataGridResultado;
        private ComboBox comboCargo;
        private Button btnVagas;
        private DataGridView dataGridViewCarregaVagas;
    }
}