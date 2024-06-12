using Gerador_de_Testes.WinApp.Compartilhado;


namespace Gerador_de_Testes.ModoloDisciplina
{
    public partial class TabelaDisciplinaUser : UserControl
    {
        public TabelaDisciplinaUser()
        {
            InitializeComponent();

            this.grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Disciplina> Disciplinas)
        {
            grid.Rows.Clear();

            foreach (Disciplina i in Disciplinas)
                grid.Rows.Add(i.Id, i.Nome, i.Materias.Count);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Disciplina" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Materias", HeaderText = "Total de Materias" },
                        };
        }
    }
}
