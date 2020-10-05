using DesafioQuay.Domain;
using System;
using System.Collections.Generic;

namespace DesafioQuay.Application
{
    public interface ICPTECService : IDisposable
    {
        List<CidadeViewModel> ObterInformacoesCidade(string cidade);
        PrevisaoDTO ObertPrevisaoDoTempoCidade(int codigoCidade);
    }
}
