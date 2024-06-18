namespace Gerador_de_Testes.ModoloTeste
{
    partial class TelaTesteForm
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
            grid = new DataGridView();
            chbRecuperacao = new CheckBox();
            txtNQuestoes = new DomainUpDown();
            cboxMateria = new ComboBox();
            btnSortear = new Button();
            brnGravar = new Button();
            cboxDisciplina = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 70);
            panel1.Controls.Add(grid);
            panel1.Controls.Add(chbRecuperacao);
            panel1.Controls.Add(txtNQuestoes);
            panel1.Controls.Add(cboxMateria);
            panel1.Controls.Add(btnSortear);
            panel1.Controls.Add(brnGravar);
            panel1.Controls.Add(cboxDisciplina);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 783);
            panel1.TabIndex = 1;
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(27, 287);
            grid.Name = "grid";
            grid.RowHeadersWidth = 51;
            grid.Size = new Size(746, 415);
            grid.TabIndex = 6;
            // 
            // chbRecuperacao
            // 
            chbRecuperacao.AutoSize = true;
            chbRecuperacao.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbRecuperacao.ForeColor = Color.FromArgb(0, 173, 181);
            chbRecuperacao.Location = new Point(478, 177);
            chbRecuperacao.Name = "chbRecuperacao";
            chbRecuperacao.Size = new Size(282, 35);
            chbRecuperacao.TabIndex = 4;
            chbRecuperacao.Text = "Teste de Recuperação";
            chbRecuperacao.UseVisualStyleBackColor = true;
            // 
            // txtNQuestoes
            // 
            txtNQuestoes.Enabled = false;
            txtNQuestoes.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNQuestoes.ForeColor = Color.FromArgb(0, 173, 181);
            txtNQuestoes.Location = new Point(654, 101);
            txtNQuestoes.Name = "txtNQuestoes";
            txtNQuestoes.Size = new Size(106, 38);
            txtNQuestoes.TabIndex = 3;
            txtNQuestoes.Text = "1";
            // 
            // cboxMateria
            // 
            cboxMateria.BackColor = Color.FromArgb(238, 238, 238);
            cboxMateria.Enabled = false;
            cboxMateria.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxMateria.ForeColor = Color.FromArgb(0, 173, 181);
            cboxMateria.FormattingEnabled = true;
            cboxMateria.Location = new Point(137, 173);
            cboxMateria.Name = "cboxMateria";
            cboxMateria.Size = new Size(304, 39);
            cboxMateria.TabIndex = 2;
            cboxMateria.SelectedIndexChanged += cboxMateria_SelectedIndexChanged;
            // 
            // btnSortear
            // 
            btnSortear.FlatAppearance.BorderSize = 0;
            btnSortear.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSortear.ForeColor = Color.FromArgb(0, 173, 181);
            btnSortear.Location = new Point(27, 233);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(266, 48);
            btnSortear.TabIndex = 5;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // brnGravar
            // 
            brnGravar.FlatAppearance.BorderSize = 0;
            brnGravar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnGravar.ForeColor = Color.FromArgb(0, 173, 181);
            brnGravar.Location = new Point(496, 723);
            brnGravar.Name = "brnGravar";
            brnGravar.Size = new Size(130, 48);
            brnGravar.TabIndex = 6;
            brnGravar.Text = "Gravar";
            brnGravar.UseVisualStyleBackColor = true;
            brnGravar.Click += brnGravar_Click;
            // 
            // cboxDisciplina
            // 
            cboxDisciplina.BackColor = Color.FromArgb(238, 238, 238);
            cboxDisciplina.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxDisciplina.ForeColor = Color.FromArgb(0, 173, 181);
            cboxDisciplina.FormattingEnabled = true;
            cboxDisciplina.Location = new Point(137, 100);
            cboxDisciplina.Name = "cboxDisciplina";
            cboxDisciplina.Size = new Size(304, 39);
            cboxDisciplina.TabIndex = 1;
            cboxDisciplina.SelectedIndexChanged += cboxDisciplina_SelectedIndexChanged;
            // 
            // btnGravar
            // 
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.ForeColor = Color.FromArgb(0, 173, 181);
            btnGravar.Location = new Point(496, 723);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 48);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(0, 173, 181);
            btnCancelar.Location = new Point(643, 723);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 48);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 173, 181);
            label4.Location = new Point(461, 103);
            label4.Name = "label4";
            label4.Size = new Size(187, 32);
            label4.TabIndex = 0;
            label4.Text = "Qtn.  Questões";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 173, 181);
            label3.Location = new Point(27, 176);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 0;
            label3.Text = "Matéria";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(238, 238, 238);
            txtTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = Color.FromArgb(0, 173, 181);
            txtTitulo.Location = new Point(137, 22);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(623, 39);
            txtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 173, 181);
            label1.Location = new Point(4, 103);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 0;
            label1.Text = "Disciplina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 173, 181);
            label2.Location = new Point(48, 25);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 0;
            label2.Text = "Titulo";
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(816, 807);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTesteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaTesteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtTitulo;
        private Label label2;
        private Label label1;
        private ComboBox cboxMateria;
        private ComboBox cboxDisciplina;
        private Label label3;
        private CheckBox chbRecuperacao;
        private DomainUpDown txtNQuestoes;
        private Label label4;
        private DataGridView grid;
        private Button btnSortear;
        private Button brnGravar;
    }
}