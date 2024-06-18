using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.WinApp.Compartilhado;
using Gerador_de_Testes.WinApp.ModoloMateria;

namespace Gerador_de_Testes.ModoloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private IRepositorioQuestao RepositorioQuestao;
        private IRepositorioMateria RepositorioMateria;
        private TabelaQuestaoControl tabelaQuestao;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao,IRepositorioMateria repositorioMateria)
        {
            this.RepositorioQuestao = repositorioQuestao;
            this.RepositorioMateria = repositorioMateria;
        }

        public override string TipoCadastro { get { return "Questão"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova questão"; } }

        public override string ToolTipEditar { get { return "Editar uma questão existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma questão existente"; } }

        public override void Adicionar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm("Cadastro de Questão", RepositorioMateria);
            
            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao novaQuestao = telaQuestao.Questao;

            this.AddEmMateria(novaQuestao);

            this.RepositorioQuestao.Cadastrar(novaQuestao);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"Uma nova questão cadastrada em \"{novaQuestao.Materia.Nome}\" foi criado com sucesso!");
        }
    

        public override void Editar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm("Cadastro de Questão", RepositorioMateria);

            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada = RepositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaQuestao.Questao = questaoSelecionada;

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao questaoEditada = telaQuestao.Questao;

            this.EditarEmMateria(questaoSelecionada, questaoEditada);

            RepositorioQuestao.Editar(questaoSelecionada.Id, questaoEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A questão \"{questaoSelecionada.Enunciado}\" foi editada com sucesso!");
        }

        public override void Excluir()
        {

            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada = RepositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
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
               $"Você deseja realmente excluir a questão \"{questaoSelecionada.Enunciado}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (resposta != DialogResult.Yes)
                return;

            this.ExcluirEmMateria(questaoSelecionada);

            RepositorioQuestao.Excluir(questaoSelecionada.Id);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A questão \"{questaoSelecionada.Enunciado}\" foi excluida com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if(tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestaoControl();

            CarregarDadosTabela();

            return tabelaQuestao;
        }

        private void CarregarDadosTabela()
        {
            List<Questao> questoes = RepositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(questoes);
        }

        private void AddEmMateria(Questao questao)
        {
            List<Materia> materias = RepositorioMateria.SelecionarTodos();

            foreach (Materia m in materias)
            {
                if (questao.Materia.Equals(m))
                    d.Materias.Add(questao);
            }
        }

        private void EditarEmMateria(Questao questaoSele, Questao questaoEditada)
        {
            this.ExcluirEmMateria(questaoSele);
            this.AddEmMateria(questaoEditada);
        }

        private void ExcluirEmMateria(Questao questao)
        {
            List<Materia> materias = RepositorioMateria.SelecionarTodos();

            foreach (Materia m in materias)
            {
                if (questao.Materia.Id.Equals(m.Id))
                {
                    foreach (Questao q in m.Questoes)
                    {
                        if (questao.Id.Equals(q.Id))
                        {
                            m.Questoes.Remove(q);
                            return;
                        }
                    }
                }
            }
        }

    }
}
