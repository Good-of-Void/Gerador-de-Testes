using Gerador_de_Testes.WinApp.Compartilhado;

namespace Gerador_de_Testes
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        ContextoDados contexto;

        public static TelaPrincipalForm Instancia { get; private set; }
        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            contexto = new ContextoDados(carregarDados: true);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdd.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdd.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }


        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        //Telas
        private void stripMenuDisciplina_Click(object sender, EventArgs e)
        {

        }

        private void stripMenuMateria_Click(object sender, EventArgs e)
        {

        }

        private void stripMenuQuestoes_Click(object sender, EventArgs e)
        {

        }

        private void stripMenuTeste_Click(object sender, EventArgs e)
        {

        }

        //Bot�es
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.controlador.Excluir();
        }
    }
}