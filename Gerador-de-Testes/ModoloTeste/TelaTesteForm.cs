using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.ModoloQuestao;
using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.ModoloTestes;
using Gerador_de_Testes.WinApp.Compartilhado;
using Gerador_de_Testes.WinApp.ModoloMateria;

namespace Gerador_de_Testes.ModoloTeste
{
    public partial class TelaTesteForm : Form
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioQuestao repositorioQuestao;

        private Random random;
        List<Questao> listaQuestoesSelecionada = new List<Questao>();
        private List<string> erros;
        private Teste teste;
        public Teste Teste
        {
            set
            {
                this.txtTitulo.Text = value.Titulo;

                if (value.Titulo.Contains("Recuperação"))
                    this.chbRecuperacao.Checked = true;

                for (int i = 0; i < this.cboxDisciplina.Items.Count; i++)
                {
                    if (this.cboxDisciplina.Items[i].Equals(value.Disciplina))
                    {
                        this.cboxDisciplina.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < this.cboxMateria.Items.Count; i++)
                {
                    if (this.cboxMateria.Items[i].Equals(value.Materia))
                    {
                        this.cboxMateria.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < this.txtNQuestoes.Items.Count; i++)
                {
                    if (this.txtNQuestoes.Items[i].ToString().Equals(value.Questoes.Count().ToString()))
                    {
                        this.txtNQuestoes.SelectedIndex = i;
                    }
                }

                this.listaQuestoesSelecionada = value.Questoes;
                this.CarregarDadosTabela();

            }
            get
            {
                return teste;
            }
        }
        //contrutor
        public TelaTesteForm(IRepositorioDisciplina disciplina, IRepositorioMateria materia, IRepositorioQuestao questao)
        {
            InitializeComponent();

            this.CarregarTabela();
            this.repositorioDisciplina = disciplina;
            this.repositorioMateria = materia;
            this.repositorioQuestao = questao;

            this.cboxDisciplina.DisplayMember = "Nome";
            this.cboxMateria.DisplayMember = "NomeESerie";

            this.cboxCarregarDisciplina();

        }

        //Botoes
        private void btnSortear_Click(object sender, EventArgs e)
        {
            GerarSelecaoQuestoes();
            this.CarregarDadosTabela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void brnGravar_Click(object sender, EventArgs e)
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

        //eventos relacionados a comboBox
        private void cboxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboxMateria.Enabled = true;

            Disciplina disciplinaSeleciona = this.cboxDisciplina.SelectedItem as Disciplina;

            this.cboxCarregarMateria(disciplinaSeleciona.Materias);
        }

        private void cboxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materiaSelecionada = this.cboxMateria.SelectedItem as Materia;

            int idSelecionado = materiaSelecionada.Id;

            materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);


            this.txtNQuestoes.Enabled = true;

            this.txttxtNQuestoesCarregarDados(materiaSelecionada.Questoes);
        }

        private void cboxCarregarDisciplina()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            cboxDisciplina.Items.Clear();

            foreach (Disciplina d in disciplinas)
            {
                this.cboxDisciplina.Items.Add(d);

            }
            if (this.cboxDisciplina.Items.Count != 0)
                this.cboxDisciplina.SelectedIndex = 0;
        }

        private void cboxCarregarMateria(List<Materia> materias)
        {
            cboxMateria.Items.Clear();

            foreach (Materia m in materias)
            {
                this.cboxMateria.Items.Add(m);
            }
            if (this.cboxMateria.Items.Count != 0)
                this.cboxMateria.SelectedIndex = 0;

        }

        //metados aleatorios
        private void txttxtNQuestoesCarregarDados(List<Questao> questoes)
        {
            for (int i = questoes.Count(); i >= 1; i--)
            {
                this.txtNQuestoes.Items.Add(i.ToString());
            }

            if (this.txtNQuestoes.Items.Count != 0)
                this.txtNQuestoes.SelectedIndex = 0;

        }
        private int GerarNumeroAleatorio(int min, int max)
        {
            random = new Random();
            return random.Next(min, max);
        }
        private void CarregarDadosTabela()
        {
            grid.Rows.Clear();
            if (this.listaQuestoesSelecionada.Count == 0)
                return;
            foreach (Questao q in this.listaQuestoesSelecionada)
                grid.Rows.Add(q.Enunciado);
        }
        private void CarregarTabela()
        {
            this.grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            this.CarregarDadosTabela();
        }
        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado" },
                        };
        }
        private void GerarSelecaoQuestoes()
        {
            listaQuestoesSelecionada = new List<Questao>();

            Materia materiaSelecionada = this.PegarMateria();

            List<Questao> questoes = materiaSelecionada.Questoes;

            int numeroQuestoes = Convert.ToInt32(txtNQuestoes.Text);
            Random random = new Random();

            while (numeroQuestoes > 0)
            {
                int indiceAleatorio = random.Next(questoes.Count); 
                Questao questaoSelecionada = questoes[indiceAleatorio];

                
                if (!listaQuestoesSelecionada.Contains(questaoSelecionada))
                {
                    listaQuestoesSelecionada.Add(questaoSelecionada);
                    numeroQuestoes--;
                }
            }
        }
        private void EntradaDados()
        {
            this.teste = new Teste(
                PegarTitulo(),
                PegarDisciplina(),
                PegarMateria(),
                this.listaQuestoesSelecionada
                );     
            erros = teste.Validar();
        }

        private Disciplina PegarDisciplina()
        {
            Disciplina disciplinaSelecionada = cboxDisciplina.SelectedItem as Disciplina;

            int idSelecionado = disciplinaSelecionada.Id;

            disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(idSelecionado);

            return disciplinaSelecionada;
        }

        private Materia PegarMateria()
        {
            Materia materiaSelecionada = cboxMateria.SelectedItem as Materia;

            int idSelecionado = materiaSelecionada.Id;

            materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);
            
            return materiaSelecionada;
        }

        private string PegarTitulo()
        {
            if(this.txtTitulo.Text.Contains("Recuperação"))
                return this.txtTitulo.Text;

            if (chbRecuperacao.Checked == true)
                return this.txtTitulo.Text + " Recuperação";

            return this.txtTitulo.Text;
        }
    }


}

