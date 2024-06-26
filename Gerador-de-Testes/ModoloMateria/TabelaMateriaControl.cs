﻿using Gerador_de_Testes.WinApp.Compartilhado;
using Gerador_de_Testes.WinApp.ModoloMateria;

namespace Gerador_de_Testes.ModoloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();

            this.grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Materia> Materias)
        {
            grid.Rows.Clear();

            foreach (Materia m in Materias)
                grid.Rows.Add(m.Id, m.Nome, m.Disciplina.Nome,m.Serie,m.Questoes.Count());
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Materia" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Serie" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Questoes", HeaderText = "Questões" },
                        };
        }
    }
}
