using Gerador_de_Testes.WinApp.Compartilhado;


namespace Gerador_de_Testes.ModoloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private TabelaDisciplinaUser TabelaDisciplina;
        public override string TipoCadastro { get { return "Disciplina"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma disciplina existente"; } }

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm("Cadastro de Disciplina",repositorioDisciplina);

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina novaDisciplina = telaDisciplina.Disciplina;

            this.repositorioDisciplina.Cadastrar(novaDisciplina);

            CarregarDadosTabela();

            //tela principal istancia
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
            throw new NotImplementedException();
        }

        private void CarregarDadosTabela()
        {
            List<Disciplina> disciplina = repositorioDisciplina.SelecionarTodos();

            TabelaDisciplina.AtualizarRegistros(disciplina);
        }
    }
}
