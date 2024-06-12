namespace Gerador_de_Testes
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            telasToolStripMenuItem = new ToolStripMenuItem();
            stripMenuDisciplina = new ToolStripMenuItem();
            stripMenuMateria = new ToolStripMenuItem();
            stripMenuQuestoes = new ToolStripMenuItem();
            stripMenuTeste = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            pnlRegistros = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { telasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // telasToolStripMenuItem
            // 
            telasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuDisciplina, stripMenuMateria, stripMenuQuestoes, stripMenuTeste });
            telasToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            telasToolStripMenuItem.Image = Properties.Resources.computador;
            telasToolStripMenuItem.Name = "telasToolStripMenuItem";
            telasToolStripMenuItem.Size = new Size(90, 32);
            telasToolStripMenuItem.Text = "Telas";
            // 
            // stripMenuDisciplina
            // 
            stripMenuDisciplina.Image = Properties.Resources.pilha_de_tres_livros;
            stripMenuDisciplina.Name = "stripMenuDisciplina";
            stripMenuDisciplina.Size = new Size(193, 32);
            stripMenuDisciplina.Text = "Disciplinas";
            stripMenuDisciplina.Click += stripMenuDisciplina_Click;
            // 
            // stripMenuMateria
            // 
            stripMenuMateria.Image = Properties.Resources.abra_o_livro;
            stripMenuMateria.Name = "stripMenuMateria";
            stripMenuMateria.Size = new Size(193, 32);
            stripMenuMateria.Text = "Materias";
            stripMenuMateria.Click += stripMenuMateria_Click;
            // 
            // stripMenuQuestoes
            // 
            stripMenuQuestoes.Image = Properties.Resources.questoes;
            stripMenuQuestoes.Name = "stripMenuQuestoes";
            stripMenuQuestoes.Size = new Size(193, 32);
            stripMenuQuestoes.Text = "Questões";
            stripMenuQuestoes.Click += stripMenuQuestoes_Click;
            // 
            // stripMenuTeste
            // 
            stripMenuTeste.Image = Properties.Resources.teste;
            stripMenuTeste.Name = "stripMenuTeste";
            stripMenuTeste.Size = new Size(193, 32);
            stripMenuTeste.Text = "Testes";
            stripMenuTeste.Click += stripMenuTeste_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEditar, btnExcluir, toolStripSeparator1, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 36);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(905, 54);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.adicionar_ficheiro;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(44, 44);
            btnAdd.Text = "toolStripButton1";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(44, 51);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(44, 51);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(116, 51);
            lblTipoCadastro.Text = "Tipo Cadastro";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 527);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(905, 34);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(167, 28);
            statusLabelPrincipal.Text = "Gerador de Testes";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 90);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(905, 437);
            pnlRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 561);
            Controls.Add(pnlRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Testes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem telasToolStripMenuItem;
        private ToolStripMenuItem stripMenuDisciplina;
        private ToolStripMenuItem stripMenuMateria;
        private ToolStripMenuItem stripMenuQuestoes;
        private ToolStripMenuItem stripMenuTeste;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private Panel pnlRegistros;
    }
}
