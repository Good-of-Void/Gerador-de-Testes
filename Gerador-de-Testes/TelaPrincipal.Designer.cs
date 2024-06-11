namespace Gerador_de_Testes
{
    partial class TelaPrincipal
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
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { telasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 36);
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
            stripMenuDisciplina.Size = new Size(224, 32);
            stripMenuDisciplina.Text = "Disciplinas";
            // 
            // stripMenuMateria
            // 
            stripMenuMateria.Image = Properties.Resources.abra_o_livro;
            stripMenuMateria.Name = "stripMenuMateria";
            stripMenuMateria.Size = new Size(224, 32);
            stripMenuMateria.Text = "Materias";
            // 
            // stripMenuQuestoes
            // 
            stripMenuQuestoes.Image = Properties.Resources.questoes;
            stripMenuQuestoes.Name = "stripMenuQuestoes";
            stripMenuQuestoes.Size = new Size(224, 32);
            stripMenuQuestoes.Text = "Questões";
            // 
            // stripMenuTeste
            // 
            stripMenuTeste.Image = Properties.Resources.teste;
            stripMenuTeste.Name = "stripMenuTeste";
            stripMenuTeste.Size = new Size(224, 32);
            stripMenuTeste.Text = "Testes";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEditar, btnExcluir });
            toolStrip1.Location = new Point(0, 36);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
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
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Testes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
    }
}
