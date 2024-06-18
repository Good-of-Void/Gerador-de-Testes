using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.WinApp.Compartilhado;
using Gerador_de_Testes.WinApp.ModoloMateria;

namespace Gerador_de_Testes.ModoloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;

        private TabelaMateriaControl tabelaMateria;

        public ControladorMateria(IRepositorioMateria materia,IRepositorioDisciplina disciplina)
        {
            this.repositorioMateria = materia;
            this.repositorioDisciplina = disciplina;
        }
        public override string TipoCadastro { get { return "Mateira"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova mateira"; } }

        public override string ToolTipEditar { get { return "Editar uma mateira existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma mateira existente"; } }

        public override void Adicionar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm("Cadastro de Materia",repositorioMateria,repositorioDisciplina);

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia novaMateria = telaMateria.Materia;

            this.repositorioMateria.Cadastrar(novaMateria);
            this.AddEmDisciplina(novaMateria);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A materia \"{novaMateria.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm("Cadastro de Materia", repositorioMateria, repositorioDisciplina);

            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia MateriaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

            if (MateriaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaMateria.Materia = MateriaSelecionada;

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia materiaEditada = telaMateria.Materia;

            this.EditarEmDisciplina(MateriaSelecionada, materiaEditada);

            repositorioMateria.Editar(MateriaSelecionada.Id, materiaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A materia \"{materiaEditada.Nome}\" foi editada com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (materiaSelecionada.Questoes.Count != 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Não é possivel excluir a materia pois tem questões cadastradas nela");
                return;
            }
                

            DialogResult resposta = MessageBox.Show(
               $"Você deseja realmente excluir a materia \"{materiaSelecionada.Nome}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (resposta != DialogResult.Yes)
                return;

            this.ExcluirEmDisciplina(materiaSelecionada);
            repositorioMateria.Excluir(materiaSelecionada.Id);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A materia \"{materiaSelecionada.Nome}\" foi excluida com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarDadosTabela();

            return tabelaMateria;
        }

        private void CarregarDadosTabela()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }
        private void AddEmDisciplina(Materia mate)
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            foreach (Disciplina d in disciplinas)
            {
                if(mate.Disciplina.Equals(d))
                    d.Materias.Add(mate);
            }
        }

        private void EditarEmDisciplina(Materia mateSele,Materia mateEditada)
        {
            this.ExcluirEmDisciplina(mateSele);
            this.AddEmDisciplina(mateEditada);
        }

        private void ExcluirEmDisciplina(Materia mate)
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            foreach (Disciplina d in disciplinas)
            {
                if (mate.Disciplina.Id.Equals(d.Id))
                {
                    foreach (Materia m in d.Materias)
                    {
                        if (mate.Id.Equals(m.Id))
                        {
                            d.Materias.Remove(m);
                            return;
                        }
                    }
                }
            }
        }

        public override void Dublicar()
        {
            throw new NotImplementedException();
        }

        public override void PDF()
        {
            throw new NotImplementedException();
        }
    }
}
