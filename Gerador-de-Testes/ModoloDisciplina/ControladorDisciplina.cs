using Gerador_de_Testes.WinApp.Compartilhado;


namespace Gerador_de_Testes.ModoloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorioDisciplina RepositorioDisciplina;
        private TabelaDisciplinaUser TabelaDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.RepositorioDisciplina = repositorioDisciplina;
        }
        public override string TipoCadastro { get { return "Disciplina"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma disciplina existente"; } }

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm("Cadastro de Disciplina",RepositorioDisciplina);

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina novaDisciplina = telaDisciplina.Disciplina;

            this.RepositorioDisciplina.Cadastrar(novaDisciplina);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A disciplina \"{novaDisciplina.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm("Edição de Disciplina", RepositorioDisciplina);
            
            int idSelecionado = TabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada = RepositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaDisciplina.Disciplina = disciplinaSelecionada;

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina disciplinaEditada = telaDisciplina.Disciplina;

            RepositorioDisciplina.Editar(disciplinaSelecionada.Id, disciplinaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A disciplina \"{disciplinaEditada.Nome}\" foi editada com sucesso!");
        }

        public override void Excluir()
        {

            int idSelecionado = TabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada = RepositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (disciplinaSelecionada.Materias.Count() != 0)
                return;

            DialogResult resposta = MessageBox.Show(
               $"Você deseja realmente excluir a diciplina \"{disciplinaSelecionada.Nome}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (resposta != DialogResult.Yes)
                return;

            RepositorioDisciplina.Excluir(disciplinaSelecionada.Id);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A disciplina \"{disciplinaSelecionada.Nome}\" foi excluida com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (TabelaDisciplina == null)
                TabelaDisciplina = new TabelaDisciplinaUser();

            CarregarDadosTabela();

            return TabelaDisciplina;
        }

        private void CarregarDadosTabela()
        {
            List<Disciplina> disciplina = RepositorioDisciplina.SelecionarTodos();

            TabelaDisciplina.AtualizarRegistros(disciplina);
        }
    }
}
