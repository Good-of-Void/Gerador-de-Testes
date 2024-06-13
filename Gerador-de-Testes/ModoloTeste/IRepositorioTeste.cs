
using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.ModoloTestes;

namespace Gerador_de_Testes.ModoloTeste
{
    public interface IRepositorioTeste
    {
        void Cadastrar(Teste novoTeste);
        bool Editar(int id, Teste testeEditado);
        bool Excluir(int id);
        Teste SelecionarPorId(int idSelecionado);
        List<Teste> SelecionarTodos();
    }
}
