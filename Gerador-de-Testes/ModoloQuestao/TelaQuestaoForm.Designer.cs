namespace Gerador_de_Testes.ModoloQuestao
{
    partial class TelaQuestaoForm
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
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            brnRemover = new Button();
            alternativasCheckedList = new CheckedListBox();
            textAlternativa = new TextBox();
            cboxMateria = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtEnunciado = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 70);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(textAlternativa);
            panel1.Controls.Add(cboxMateria);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtEnunciado);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 737);
            panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(0, 173, 181);
            btnAdd.Location = new Point(606, 277);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 48);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(brnRemover);
            groupBox1.Controls.Add(alternativasCheckedList);
            groupBox1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 173, 181);
            groupBox1.Location = new Point(49, 367);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 283);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas";
            // 
            // brnRemover
            // 
            brnRemover.FlatAppearance.BorderSize = 0;
            brnRemover.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnRemover.ForeColor = Color.FromArgb(0, 173, 181);
            brnRemover.Location = new Point(557, 223);
            brnRemover.Name = "brnRemover";
            brnRemover.Size = new Size(130, 45);
            brnRemover.TabIndex = 7;
            brnRemover.Text = "Remover";
            brnRemover.UseVisualStyleBackColor = true;
            brnRemover.Click += brnRemover_Click;
            // 
            // alternativasCheckedList
            // 
            alternativasCheckedList.BackColor = Color.FromArgb(57, 62, 70);
            alternativasCheckedList.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alternativasCheckedList.ForeColor = Color.FromArgb(0, 173, 181);
            alternativasCheckedList.FormattingEnabled = true;
            alternativasCheckedList.Items.AddRange(new object[] { "a) ", "b) ", "c) ", "d) " });
            alternativasCheckedList.Location = new Point(20, 48);
            alternativasCheckedList.Name = "alternativasCheckedList";
            alternativasCheckedList.Size = new Size(676, 169);
            alternativasCheckedList.TabIndex = 0;
            // 
            // textAlternativa
            // 
            textAlternativa.BackColor = Color.FromArgb(238, 238, 238);
            textAlternativa.Cursor = Cursors.IBeam;
            textAlternativa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textAlternativa.ForeColor = Color.FromArgb(0, 173, 181);
            textAlternativa.Location = new Point(159, 283);
            textAlternativa.Name = "textAlternativa";
            textAlternativa.Size = new Size(421, 39);
            textAlternativa.TabIndex = 4;
            // 
            // cboxMateria
            // 
            cboxMateria.BackColor = Color.FromArgb(238, 238, 238);
            cboxMateria.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxMateria.ForeColor = Color.FromArgb(0, 173, 181);
            cboxMateria.FormattingEnabled = true;
            cboxMateria.Location = new Point(159, 78);
            cboxMateria.Name = "cboxMateria";
            cboxMateria.Size = new Size(381, 39);
            cboxMateria.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.ForeColor = Color.FromArgb(0, 173, 181);
            btnGravar.Location = new Point(484, 673);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 48);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(0, 173, 181);
            btnCancelar.Location = new Point(632, 673);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEnunciado
            // 
            txtEnunciado.BackColor = Color.FromArgb(238, 238, 238);
            txtEnunciado.Cursor = Cursors.IBeam;
            txtEnunciado.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEnunciado.ForeColor = Color.FromArgb(0, 173, 181);
            txtEnunciado.Location = new Point(159, 156);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(603, 97);
            txtEnunciado.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 173, 181);
            label4.Location = new Point(9, 286);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 0;
            label4.Text = "Alternativa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 173, 181);
            label3.Location = new Point(19, 186);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 0;
            label3.Text = "Enunciado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 173, 181);
            label2.Location = new Point(49, 81);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 0;
            label2.Text = "Matéria";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(238, 238, 238);
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(0, 173, 181);
            txtId.Location = new Point(159, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 39);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 173, 181);
            label1.Location = new Point(116, 21);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(800, 761);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestaoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaQuestaoForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboxMateria;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private TextBox textAlternativa;
        private TextBox txtEnunciado;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private CheckedListBox alternativasCheckedList;
        private Button btnAdd;
        private Button brnRemover;
    }
}