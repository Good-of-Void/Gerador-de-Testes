using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.WinApp.Compartilhado;
using Gerador_de_Testes.WinApp.ModoloMateria;


namespace Gerador_de_Testes.ModoloTestes
{
    public class Teste : EntidadeBase
    {
        public string Titulo {  get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public List<Questao> Questoes { get; set; }

        //contrutor completo
        public Teste(string titulo, Disciplina disciplina, Materia materia, List<Questao> questoes)
        {
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            Questoes = questoes;
        }

        //contrutor vazil
        public Teste()
        {
            
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste novo = (Teste)novoRegistro;

            this.Id = novo.Id;
            this.Titulo = novo.Titulo;
            this.Materia = novo.Materia;
            this.Disciplina = novo.Disciplina;
            this.Questoes = novo.Questoes;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Materia.ToString().Trim()))
                erros.Add("O campo \"Materia\" é obrigatório");

            if (string.IsNullOrEmpty(Disciplina.ToString().Trim()))
                erros.Add("O campo \"Disciplina\" é obrigatório");

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"Titulo\" é obrigatório");

            if (Titulo.Length < 3)
                erros.Add("O \"Titulo\" tem que ter no minimo 3 caractere");

            if (Questoes.Count == 0)
                erros.Add("Tem que possuir pelo menos 1 questão");

            return erros;
        }
    }
}
