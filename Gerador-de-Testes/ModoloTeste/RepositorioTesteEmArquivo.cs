﻿using Gerador_de_Testes.ModoloTestes;
using Gerador_de_Testes.WinApp.Compartilhado;

namespace Gerador_de_Testes.ModoloTeste
{
    public class RepositorioTesteEmArquivo : RepositorioBaseEmArquivo<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }
        protected override List<Teste> ObterRegistros()
        {
            return contexto.Testes;
        }
    }
}
