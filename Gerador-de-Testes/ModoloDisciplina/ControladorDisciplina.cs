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
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
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
