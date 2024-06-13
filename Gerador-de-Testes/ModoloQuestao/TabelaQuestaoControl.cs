using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.WinApp.Compartilhado;

namespace Gerador_de_Testes.ModoloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();

            this.grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Questao> Questoes)
        {
            grid.Rows.Clear();

            foreach (Questao q in Questoes)
                grid.Rows.Add(q.Id, q.Materia.Nome,q.Enunciado, q.Resposta);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Resposta", HeaderText = "Resposta" },
                        };
        }
    }
}
