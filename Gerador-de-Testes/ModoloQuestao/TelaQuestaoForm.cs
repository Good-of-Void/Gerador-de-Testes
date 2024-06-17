using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.WinApp.ModoloMateria;

namespace Gerador_de_Testes.ModoloQuestao
{
    public partial class TelaQuestaoForm : Form
    {
        private Questao questao;
        private IRepositorioMateria repositorioMateria;
        private List<string> erros;

        public Questao Questao
        {
            set
            {
                this.txtId.Text = value.Id.ToString();

                for (int i = 0; i < cboxMateria.Items.Count; i++)
                {
                    if (this.cboxMateria.Items[i].ToString().Equals(value.Materia.Nome + ", " + value.Materia.Serie))
                    {
                        this.cboxMateria.SelectedIndex = i;
                    }
                }

                this.txtEnunciado.Text = value.Enunciado;

                for (int i = 0; i < value.Alternativas.Count; i++)
                {
                    this.alternativasCheckedList.Items[i] = value.Alternativas[i];
                    if (value.Alternativas[i] == value.Resposta)
                    {
                        this.alternativasCheckedList.SelectedIndex = i;
                        this.alternativasCheckedList.SetItemChecked(i, true);
                    }
                }
            }
            get
            {
                return questao;
            }
        }
        //contrutor
        public TelaQuestaoForm(string tipo, IRepositorioMateria repositorioMateria)
        {
            InitializeComponent();
            this.Text = tipo;
            this.repositorioMateria = repositorioMateria;
            carregarMateria();
        }

        private void carregarMateria()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            cboxMateria.Items.Clear();

            foreach (Materia m in materias)
            {
                this.cboxMateria.Items.Add(m.Nome + ", " + m.Serie);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (alternativasCheckedList.Items[0].Equals("a) "))
                alternativasCheckedList.Items[0] = "a) " + this.textAlternativa.Text;

            else if (alternativasCheckedList.Items[1].Equals("b) "))
                alternativasCheckedList.Items[1] = "b) " + this.textAlternativa.Text;

            else if (alternativasCheckedList.Items[2].Equals("c) "))
                alternativasCheckedList.Items[2] = "c) " + this.textAlternativa.Text;

            else if (alternativasCheckedList.Items[3].Equals("d) "))
                alternativasCheckedList.Items[3] = "d) " + this.textAlternativa.Text;

            this.textAlternativa.Text = null;
            this.textAlternativa.Select();
        }

        private void brnRemover_Click(object sender, EventArgs e)
        {
            if (alternativasCheckedList.SelectedIndex == 0)
                alternativasCheckedList.Items[0] = "a) ";

            else if (alternativasCheckedList.SelectedIndex == 1)
                alternativasCheckedList.Items[1] = "b) ";

            else if (alternativasCheckedList.SelectedIndex == 2)
                alternativasCheckedList.Items[2] = "c) ";

            else if (alternativasCheckedList.SelectedIndex == 3)
                alternativasCheckedList.Items[3] = "d) ";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {


            this.EntradaDados();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void EntradaDados()
        {
            this.questao = new Questao(
                this.PegarMateria(),
                this.txtEnunciado.Text,
                this.alternativasCheckedList.SelectedItem.ToString(),
                this.PegarListaAlternativas()
                );
            erros = questao.Validar();
        }

        private List<string> PegarListaAlternativas()
        {
            List<string> alt = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (alternativasCheckedList.Items[i].ToString().Length > 3)
                    alt.Add(alternativasCheckedList.Items[i].ToString());
            }
            return alt;
        }

        private Materia PegarMateria()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            string item;
            foreach (Materia m in materias)
            {
                item = m.Nome + ", " + m.Serie;
                if (item.Equals(this.cboxMateria.SelectedItem))
                    return m;
                
            }
            return null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void alternativasCheckedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarque todos os outros itens
                for (int i = 0; i < alternativasCheckedList.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        alternativasCheckedList.SetItemChecked(i, false);
                    }
                }
            }
            this.btnGravar.Enabled = true;
        }
    }
}
