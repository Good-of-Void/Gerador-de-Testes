using Gerador_de_Testes.ModoloTestes;

namespace Gerador_de_Testes.ModoloTeste
{
    public partial class TelaTesteForm : Form
    {
        private Teste teste;
        public Teste Teste
        {
            set
            {

            }
            get
            {
                return teste;
            }
        }
        public TelaTesteForm()
        {
            InitializeComponent();
        }
    }
}
