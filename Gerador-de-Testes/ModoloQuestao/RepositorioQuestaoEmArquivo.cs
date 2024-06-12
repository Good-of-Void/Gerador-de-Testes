using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.WinApp.Compartilhado;

namespace Gerador_de_Testes.ModoloQuestao
{
    internal class RepositorioQuestaoEmArquivo : RepositorioBaseEmArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }
        protected override List<Questao> ObterRegistros()
        {
            return contexto.Questoes;
        }
    }
}
