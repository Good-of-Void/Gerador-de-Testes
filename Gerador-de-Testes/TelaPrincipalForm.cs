using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.ModoloQuestao;
using Gerador_de_Testes.WinApp.Compartilhado;
using Gerador_de_Testes.ModoloTeste;

namespace Gerador_de_Testes
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;
        ContextoDados contexto;

        //Repositorios
        IRepositorioDisciplina repositorioDisciplina;
        IRepositorioMateria repositorioMateria;
        IRepositorioQuestao repositorioQuestao;
        IRepositorioTeste repositorioTeste;

        public static TelaPrincipalForm Instancia { get; private set; }
        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            DesiblitarMenus();

            contexto = new ContextoDados(carregarDados: true);

            this.repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contexto);
            this.repositorioMateria = new RepositorioMateriaEmArquivo(contexto);
            this.repositorioQuestao = new RepositorioQuestaoEmArquivo(contexto);
            this.repositorioTeste = new RepositorioTesteEmArquivo(contexto);

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
            this.controlador = new ControladorDisciplina(repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
            DesiblitarMenus();
        }

        private void stripMenuMateria_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
            DesiblitarMenus();
        }

        private void stripMenuQuestoes_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorQuestao(repositorioQuestao, repositorioMateria);

            ConfigurarTelaPrincipal(controlador);
            DesiblitarMenus();
        }

        private void stripMenuTeste_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorTeste(repositorioDisciplina, repositorioMateria, repositorioQuestao, repositorioTeste);

            ConfigurarTelaPrincipal(controlador);

            this.btnDuplicar.Visible = true;
            this.btnPDF.Visible = true;
            this.Separator2.Visible = true;
        }

        //Botões
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

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            this.controlador.Dublicar();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            this.controlador.PDF();
        }

        private void DesiblitarMenus()
        {
            this.btnDuplicar.Visible = false;
            this.btnPDF.Visible = false;
            this.Separator2.Visible = false;
        }
    }
}
