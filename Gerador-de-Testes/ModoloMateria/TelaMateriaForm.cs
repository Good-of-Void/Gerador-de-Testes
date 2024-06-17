using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.WinApp.ModoloMateria;

namespace Gerador_de_Testes.ModoloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;
        private IRepositorioDisciplina repositorioDisciplina;
        private List<string> erros;

        public Materia Materia
        {
            set 
            {
                this.txtId.Text = value.Id.ToString();
                this.txtNome.Text = value.Nome.ToString();

                for (int i = 0; i < cboxDisciplina.Items.Count; i++)
                {
                    if (this.cboxDisciplina.Items[i].ToString().Equals(value.Disciplina.Nome))
                    {
                        this.cboxDisciplina.SelectedIndex = i;
                    }
                }

                if(value.Serie.Equals("1ª Serie"))
                {
                    this.chb1.Checked = true;
                    this.chb2.Checked = false;
                }
                else
                {
                    this.chb1.Checked = false;
                    this.chb2.Checked = true;
                }
            }
            get 
            { 
                return materia; 
            }
        }

        public TelaMateriaForm(string tipo, IRepositorioDisciplina repositorio)
        {
            InitializeComponent();
            this.Text = tipo;
            this.repositorioDisciplina = repositorio;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.EntradaDados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void EntradaDados()
        {
            //pegar disciplina
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            Disciplina disciplinaSelecionada= null;

            foreach (Disciplina d in disciplinas)
            {
                if (d.Nome.Equals(this.cboxDisciplina.SelectedItem.ToString()))
                    disciplinaSelecionada = d;
            }

            //pegar a serie
            string serie;
            if(this.chb1.Equals(true))
                serie = this.chb1.Text;
            else
                serie = this.chb2.Text;

            this.materia = new(this.txtNome.Text, disciplinaSelecionada, serie);
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
