using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModoloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Cadastrar(Disciplina novaDisciplina);
        bool Editar(int id, Disciplina disciplinaEditado);
        bool Excluir(int id);
        Disciplina SelecionarPorId(int idSelecionado);
        List<Disciplina> SelecionarTodos();
    }
}
