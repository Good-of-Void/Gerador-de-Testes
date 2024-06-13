using Gerador_de_Testes.WinApp.Compartilhado;
using Gerador_de_Testes.ModoloDisciplina;


namespace Gerador_de_Testes.WinApp.ModoloMateria
{
    public class Materia : EntidadeBase
    //variaveis
    {
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }
        public string Serie { get; set; }

        public Materia()
        {

        }
        //Construtor
        public Materia(string nome, Disciplina disciplina, string serie)
        {
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia novo = (Materia)novoRegistro;

            this.Id = novo.Id;
            this.Nome = novo.Nome;
            this.Serie = novo.Serie;
            this.Disciplina = novo.Disciplina;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo 'Nome' é obrigatório");

            if (string.IsNullOrEmpty(Serie))
                erros.Add("O campo 'Série' é obrigatório");

            if (Nome.Length < 5)
                erros.Add("O campo 'Nome' deve ter 5 caracteres");

            return erros;
        }
    }
}