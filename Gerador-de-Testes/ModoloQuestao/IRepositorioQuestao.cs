using Gerador_de_Testes.ModoloQuestoes;

namespace Gerador_de_Testes.ModoloQuestao
{
    internal interface IRepositorioQuestao
    {
        void Cadastrar(Questao novaQuestao);
        bool Editar(int id, Questao questaoEditado);
        bool Excluir(int id);
        Questao SelecionarPorId(int idSelecionado);
        List<Questao> SelecionarTodos();
    }
}