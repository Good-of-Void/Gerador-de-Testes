namespace Gerador_de_Testes.ModoloMateria
{
    partial class TelaMateriaForm
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
            rbn2 = new RadioButton();
            rbn1 = new RadioButton();
            cboxDisciplina = new ComboBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 70);
            panel1.Controls.Add(rbn2);
            panel1.Controls.Add(rbn1);
            panel1.Controls.Add(cboxDisciplina);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 426);
            panel1.TabIndex = 0;
            // 
            // rbn2
            // 
            rbn2.AutoSize = true;
            rbn2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbn2.ForeColor = Color.FromArgb(0, 173, 181);
            rbn2.Location = new Point(273, 275);
            rbn2.Name = "rbn2";
            rbn2.Size = new Size(115, 35);
            rbn2.TabIndex = 6;
            rbn2.TabStop = true;
            rbn2.Text = "2ª Serie";
            rbn2.UseVisualStyleBackColor = true;
            // 
            // rbn1
            // 
            rbn1.AutoSize = true;
            rbn1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbn1.ForeColor = Color.FromArgb(0, 173, 181);
            rbn1.Location = new Point(156, 273);
            rbn1.Name = "rbn1";
            rbn1.Size = new Size(111, 35);
            rbn1.TabIndex = 6;
            rbn1.TabStop = true;
            rbn1.Text = "1ª Serie";
            rbn1.UseVisualStyleBackColor = true;
            // 
            // cboxDisciplina
            // 
            cboxDisciplina.BackColor = Color.FromArgb(238, 238, 238);
            cboxDisciplina.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxDisciplina.ForeColor = Color.FromArgb(0, 173, 181);
            cboxDisciplina.FormattingEnabled = true;
            cboxDisciplina.Location = new Point(156, 190);
            cboxDisciplina.Name = "cboxDisciplina";
            cboxDisciplina.Size = new Size(304, 39);
            cboxDisciplina.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(0, 173, 181);
            btnCancelar.Location = new Point(447, 366);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 48);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.ForeColor = Color.FromArgb(0, 173, 181);
            btnGravar.Location = new Point(297, 366);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 48);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(238, 238, 238);
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(0, 173, 181);
            txtId.Location = new Point(156, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 39);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(238, 238, 238);
            txtNome.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(0, 173, 181);
            txtNome.Location = new Point(156, 109);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(421, 39);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 173, 181);
            label1.Location = new Point(106, 28);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 173, 181);
            label4.Location = new Point(72, 275);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 0;
            label4.Text = "Serie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 173, 181);
            label3.Location = new Point(23, 193);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);
            label3.TabIndex = 0;
            label3.Text = "Disciplina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 173, 181);
            label2.Location = new Point(59, 112);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(616, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMateriaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaMateriaForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private ComboBox cboxDisciplina;
        private Label label3;
        private Label label4;
        private RadioButton rbn2;
        private RadioButton rbn1;
    }
}