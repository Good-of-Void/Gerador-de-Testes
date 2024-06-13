using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.WinApp.Compartilhado;


namespace Gerador_de_Testes.ModoloTestes
{
    public class Teste : EntidadeBase
    {
        public string Titulo {  get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public int QuantidadeQuestoes { get; set; }
        public List<Questao> Questoes { get; set; }

        //contrutor completo
        public Teste(string titulo, Disciplina disciplina, Materia materia, int quantidadeQuestoes, List<Questao> questoes)
        {
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            QuantidadeQuestoes = quantidadeQuestoes;
            Questoes = questoes;
        }

        //contrutor vazil
        public Teste()
        {
            
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
