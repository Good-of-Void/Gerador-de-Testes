using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.ModoloQuestao;
using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.ModoloTestes;
using Gerador_de_Testes.WinApp.Compartilhado;

namespace Gerador_de_Testes.ModoloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioQuestao repositorioQuestao;
        private IRepositorioTeste repositorioTeste;
        private TabelaTesteControl TabelaTeste;

        public ControladorTeste(IRepositorioDisciplina disciplina, IRepositorioMateria materia, IRepositorioQuestao questao, IRepositorioTeste teste)
        {
            this.repositorioDisciplina = disciplina;
            this.repositorioMateria = materia;
            this.repositorioQuestao = questao;
            this.repositorioTeste = teste;
        }

        public override string TipoCadastro { get { return "Teste"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo teste"; } }

        public override string ToolTipEditar { get { return "Editar um teste existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um teste existente"; } }

        public override void Adicionar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorioDisciplina,repositorioMateria,repositorioQuestao);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            this.repositorioTeste.Cadastrar(novoTeste);
            this.AddEmQuestao(novoTeste);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O teste \"{novoTeste.Titulo}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorioDisciplina, repositorioMateria, repositorioQuestao);

            int idSelecionado = TabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaTeste.Teste = testeSelecionado;

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste testeEditado = telaTeste.Teste;

            this.repositorioTeste.Editar(testeSelecionado.Id,testeEditado);
            this.EditarEmQuestao(testeSelecionado,testeEditado);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O teste \"{testeEditado.Titulo}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = TabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
               $"Você deseja realmente excluir a materia \"{testeSelecionado.Titulo}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (resposta != DialogResult.Yes)
                return;

            this.ExcluirEmQuestao(testeSelecionado);
            this.repositorioTeste.Excluir(testeSelecionado.Id);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O teste \"{testeSelecionado.Titulo}\" foi excluido com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (TabelaTeste == null)
                TabelaTeste = new TabelaTesteControl();

            CarregarDadosTabela();

            return TabelaTeste;
        }

        private void CarregarDadosTabela()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();

            TabelaTeste.AtualizarRegistros(testes);
        }

        private void AddEmQuestao(Teste teste)
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            foreach (Questao q in questoes)
            {
                if (teste.Questoes.Equals(q))
                    q.Testes.Add(teste);
            }
        }

        private void EditarEmQuestao(Teste testeSele, Teste testeEditada)
        {
            this.ExcluirEmQuestao(testeSele);
            this.AddEmQuestao(testeEditada);
        }

        private void ExcluirEmQuestao(Teste teste)
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            foreach (Questao q in questoes)
            {
                foreach (Questao tq in teste.Questoes)
                {
                    if (tq.Id.Equals(q.Id))
                    {
                        foreach (Teste t in q.Testes)
                        {
                            if (teste.Id.Equals(t.Id))
                            {
                                q.Testes.Remove(t);
                                return;
                            }
                        }
                    }
                }
                
            }
        }

        public override void Dublicar()
        {
            MessageBox.Show(
                     "Não é possível realizar esta ação sem uma disciplina selecionada.",
                     "Aviso",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
        }

        public override void PDF()
        {
            throw new NotImplementedException();
        }
    }
}
