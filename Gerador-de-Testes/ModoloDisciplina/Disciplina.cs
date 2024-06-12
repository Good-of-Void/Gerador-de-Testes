using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.WinApp.Compartilhado;

namespace Gerador_de_Testes.ModoloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        //Variaveis da classe
        public string Nome {  get; set; }
        public List<Materia> Materias { get; set; }

        //Construtor completo
        public Disciplina(string nome)
        {
            Nome = nome;
            Materias = new List<Materia>();
        }
        //Construtor vazil
        public Disciplina() { }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(this.Nome))
                erros.Add("O campo 'Nome' é obrigatório");

            if(this.Nome.Length < 3)
                    erros.Add("O campo 'Nome' deve conter no mínimo 3 caracteres");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina novo = (Disciplina)novoRegistro;

            this.Nome = novo.Nome;
            this.Materias = novo.Materias;
        }
    }
}
