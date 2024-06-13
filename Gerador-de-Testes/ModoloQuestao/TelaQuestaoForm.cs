
using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.ModoloQuestoes;

namespace Gerador_de_Testes.ModoloQuestao
{
    public partial class TelaQuestaoForm : Form
    {
        private Questao questao;
        //pirvate repositorioMateria
        private List<string> erros;

        public Questao Questao
        {
            set
            {
                this.txtId.Text = value.Id.ToString();
                this.cboxMateria.SelectedItem = value.Materia;
                this.txtEnunciado.Text = value.Enunciado;
                for (int i = 0; i < value.Alternativas.Count; i++)
                {
                    this.alternativasCheckedList.Items[i] = value.Alternativas[i];
                    if (value.Alternativas[i] == value.Resposta)
                    {
                        this.alternativasCheckedList.SelectedIndex = i;
                    }
                }
            }
            get
            {
                return questao;
            }
        }
        public TelaQuestaoForm(string tipo)
        {
            InitializeComponent();
            this.Text = tipo;
            //this.repositorio = repositorio;
            carregarMateria();
        }

        private void carregarMateria()
        {
            List<Materia> materias = new List<Materia>();

            cboxMateria.Items.Clear();
            foreach (Materia m in materias)
            {
                //m.nome
                this.cboxMateria.Items.Add(m);
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
            this.questao.Materia = (Materia)cboxMateria.SelectedItem;
            
            this.questao.Enunciado = this.txtEnunciado.Text;
            
            this.questao.Resposta = this.alternativasCheckedList.SelectedItem.ToString();
            
            for (int i = 0; i < 4; i++)
            {
                if (alternativasCheckedList.Items[i].ToString().Length > 3)
                    this.questao.Alternativas.Add(alternativasCheckedList.Items[i].ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
