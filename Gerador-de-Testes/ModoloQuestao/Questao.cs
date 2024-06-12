
using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.WinApp.Compartilhado;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gerador_de_Testes.ModoloQuestoes
{
    public class Questao : EntidadeBase
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public string Resposta { get; set; }
        public List<string> Alternativas { get; set; }

        //contrutor completo
        public Questao(Materia materia, string enunciado, string resposta, List<string> alternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            Resposta = resposta;
            Alternativas = alternativas;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Materia.ToString().Trim()))
                erros.Add("O campo \"Materia\" é obrigatório");

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"Enunciado\" é obrigatório");

            if (string.IsNullOrEmpty(Resposta.Trim()))
                erros.Add("O campo \"Resposta\" é obrigatório");

            if (Alternativas.Count != 4)
                erros.Add("Tem que possuir apenas 4 alternativas");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao novo = (Questao)novoRegistro;

            this.Id = novo.Id;
            this.Materia = novo.Materia;
            this.Enunciado = novo.Enunciado;
            this.Resposta = novo.Resposta;
            this.Alternativas = novo.Alternativas;
        }
    }
}
