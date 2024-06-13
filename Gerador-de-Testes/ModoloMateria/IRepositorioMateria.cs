using Gerador_de_Testes.WinApp.ModoloMateria;
using Gerador_de_Testes.WinApp.Compartilhado;

namespace Gerador_de_Testes.ModoloMateria
{
    public interface IRepositorioMateria
    {
        void Cadastrar(Materia novoMateria);
        bool Editar(int id, Materia materiaEditado);
        bool Excluir(int id);
        Materia SelecionarPorId(int idSelecionado);
        List<Materia> SelecionarTodos();
    }
}