﻿using Gerador_de_Testes.ModoloDisciplina;
using Gerador_de_Testes.ModoloMateria;
using Gerador_de_Testes.ModoloQuestao;
using Gerador_de_Testes.ModoloQuestoes;
using Gerador_de_Testes.ModoloTestes;
using Gerador_de_Testes.WinApp.Compartilhado;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;

namespace Gerador_de_Testes.ModoloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioQuestao repositorioQuestao;
        private IRepositorioTeste repositorioTeste;
        private TabelaTesteControl TabelaTeste;

        public ControladorTeste(IRepositorioDisciplina disciplina, IRepositorioMateria materia, IRepositorioQuestao questao, IRepositorioTeste teste)
        {
            this.repositorioDisciplina = disciplina;
            this.repositorioMateria = materia;
            this.repositorioQuestao = questao;
            this.repositorioTeste = teste;
        }

        public override string TipoCadastro { get { return "Teste"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo teste"; } }

        public override string ToolTipEditar { get { return "Editar um teste existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um teste existente"; } }

        public override void Adicionar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorioDisciplina,repositorioMateria,repositorioQuestao,repositorioTeste);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            this.repositorioTeste.Cadastrar(novoTeste);
            this.AddEmQuestao(novoTeste);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O teste \"{novoTeste.Titulo}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorioDisciplina, repositorioMateria, repositorioQuestao, repositorioTeste);

            int idSelecionado = TabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaTeste.Teste = testeSelecionado;

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste testeEditado = telaTeste.Teste;

            this.repositorioTeste.Editar(testeSelecionado.Id,testeEditado);
            this.EditarEmQuestao(testeSelecionado,testeEditado);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O teste \"{testeEditado.Titulo}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = TabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
               $"Você deseja realmente excluir a materia \"{testeSelecionado.Titulo}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (resposta != DialogResult.Yes)
                return;

            this.ExcluirEmQuestao(testeSelecionado);
            this.repositorioTeste.Excluir(testeSelecionado.Id);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O teste \"{testeSelecionado.Titulo}\" foi excluido com sucesso!");
        }

        public override void Dublicar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorioDisciplina, repositorioMateria, repositorioQuestao, repositorioTeste);

            int idSelecionado = TabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma disciplina selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaTeste.Dublicado = true;

            telaTeste.Teste = testeSelecionado;

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            this.repositorioTeste.Cadastrar(novoTeste);
            this.AddEmQuestao(novoTeste);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O teste \"{novoTeste.Titulo}\" foi criado com sucesso!");
        }

        public override void PDF()
        {
            int idSelecionado = TabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            Document Teste = new Document(PageSize.A4);
            Teste.SetMargins(40, 40, 40, 80);
            Teste.AddCreationDate();
            CriarPdf(testeSelecionado, Teste,false);
            
            Document gabarito = new Document(PageSize.A4);
            gabarito.SetMargins(40, 40, 40, 80);
            gabarito.AddCreationDate();
            CriarPdf(testeSelecionado, gabarito,true);

            
        }

        private void CriarPdf(Teste testeSelecionado, Document doc,bool gabarito)
        {
            string caminho;
            if (gabarito)
                caminho = @"C:\temp\GeradorTestes\" + $"{testeSelecionado.Titulo}Gabarito.pdf";
            else
                caminho = @"C:\temp\GeradorTestes\" + $"{testeSelecionado.Titulo}.pdf";

            PdfWriter branco = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            string dados = "";

            Paragraph paragrafo = new Paragraph(dados);

            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            
            if(gabarito)
                paragrafo.Add(this.SaidaPDFGabarito(testeSelecionado));
            else
                paragrafo.Add(this.SaidaPDFAluno(testeSelecionado));

            doc.Add(paragrafo);

            doc.Close();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O teste \"{testeSelecionado.Titulo}\" foi criado com sucesso! no local: {caminho}");
        }

        public override UserControl ObterListagem()
        {
            if (TabelaTeste == null)
                TabelaTeste = new TabelaTesteControl();

            CarregarDadosTabela();

            return TabelaTeste;
        }

        private void CarregarDadosTabela()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();

            TabelaTeste.AtualizarRegistros(testes);
        }

        private void AddEmQuestao(Teste teste)
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            foreach (Questao q in questoes)
            {
                if (teste.Questoes.Equals(q))
                    q.Testes.Add(teste);
            }
        }

        private void EditarEmQuestao(Teste testeSele, Teste testeEditada)
        {
            this.ExcluirEmQuestao(testeSele);
            this.AddEmQuestao(testeEditada);
        }

        private void ExcluirEmQuestao(Teste teste)
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            foreach (Questao q in questoes)
            {
                foreach (Questao tq in teste.Questoes)
                {
                    if (tq.Id.Equals(q.Id))
                    {
                        foreach (Teste t in q.Testes)
                        {
                            if (teste.Id.Equals(t.Id))
                            {
                                q.Testes.Remove(t);
                                return;
                            }
                        }
                    }
                }
                
            }
        }

        private string SaidaPDFAluno(Teste teste)
        {
            string prova = $"{teste.Titulo}\n{teste.Disciplina.Nome}: {teste.Materia.Nome}\nNome:\n\n\n";

            for (int i = 0; i < teste.Questoes.Count; i++)
            {
                prova += $"{i + 1}) {teste.Questoes[i].Enunciado}\n\n";

                for (int j = 0; j < teste.Questoes[i].Alternativas.Count(); j++)
                {
                    prova += $"     {teste.Questoes[i].Alternativas[j]}\n";
                }

                prova += $"\n\n";
            }

            prova += "Bom Teste!!";

                return prova;
        }

        private string SaidaPDFGabarito(Teste teste)
        {
            string prova = $"{teste.Titulo}\n{teste.Disciplina.Nome}: {teste.Materia.Nome}\nGabarito!!\n\n\n";

            for (int i = 0; i < teste.Questoes.Count; i++)
            {
                prova += $"{i + 1}) {teste.Questoes[i].Enunciado}\n\n";

                for (int j = 0; j < teste.Questoes[i].Alternativas.Count(); j++)
                {
                    if (teste.Questoes[i].Alternativas[j].Equals(teste.Questoes[i].Resposta))
                        prova += $"--> {teste.Questoes[i].Alternativas[j]}\n";
                    else
                        prova += $"     {teste.Questoes[i].Alternativas[j]}\n";
                }

                prova += $"\n\n";
            }

            prova += "Bom Teste!!";

            return prova;
        }


    }
}
