using Gerador_de_Testes.WinApp.Compartilhado;
using Gerador_de_Testes.WinApp.ModoloMateria;


namespace Gerador_de_Testes.ModoloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioBaseEmArquivo<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }
        protected override List<Materia> ObterRegistros()
        {
            return contexto.Materias;
        }
    }
}