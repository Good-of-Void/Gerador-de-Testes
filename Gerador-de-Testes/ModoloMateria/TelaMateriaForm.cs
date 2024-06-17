using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.WinApp.ModoloMateria;
using System.Diagnostics;

namespace Gerador_de_Testes.ModoloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioMateria repositorioMateria;
        private List<string> erros;
        private Materia materiaAntiga;

        public Materia Materia
        {
            set
            {
                this.materiaAntiga = value;
                this.txtId.Text = value.Id.ToString();
                this.txtNome.Text = value.Nome.ToString();

                for (int i = 0; i < cboxDisciplina.Items.Count; i++)
                {
                    if (this.cboxDisciplina.Items[i].ToString().Equals(value.Disciplina.Nome))
                    {
                        this.cboxDisciplina.SelectedIndex = i;
                    }
                }

                if (value.Serie.Equals("1ª Serie"))
                {
                    this.rbn1.Checked = true;
                    this.rbn2.Checked = false;
                }
                else
                {
                    this.rbn1.Checked = false;
                    this.rbn2.Checked = true;
                }
            }
            get
            {
                return materia;
            }
        }

        public TelaMateriaForm(string tipo, IRepositorioMateria materia, IRepositorioDisciplina disciplina)
        {
            InitializeComponent();
            this.Text = tipo;
            this.repositorioDisciplina = disciplina;
            this.repositorioMateria = materia;
            this.carregarDisciplinas();
            this.cboxDisciplina.SelectedIndex = 0;
            this.rbn1.Checked = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.EntradaDados();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                this.txtNome.Text = null;
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void EntradaDados()
        {
            //pegar disciplina
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            Disciplina disciplinaSelecionada = null;

            foreach (Disciplina d in disciplinas)
            {
                if (d.Nome.Equals(this.cboxDisciplina.SelectedItem.ToString()))
                    disciplinaSelecionada = d;
            }

            //pegar a serie
            string serie = null;
            if (this.rbn1.Checked.Equals(true))
                serie = this.rbn1.Text;
            else
                serie = this.rbn2.Text;

            this.materia = new(this.txtNome.Text, disciplinaSelecionada, serie);

            erros = materia.Validar();

            List<Materia> materias = repositorioMateria.SelecionarTodos();
            
            if(materias.Equals(this.materia))
                materias.Remove(this.materia);

            foreach (Materia m in materias)
            {
                if (!m.Equals(materiaAntiga))
                {
                    if (materia.Nome.Equals(m.Nome))
                    {
                        erros.Add($"Materia com mesmo nome ja cadastrada");
                        return;
                    }
                }      
            }
        }

        private void carregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            this.cboxDisciplina.Items.Clear();

            foreach (Disciplina d in disciplinas)
            {
                this.cboxDisciplina.Items.Add(d.Nome);
            }
        }
    }
}
