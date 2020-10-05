using DesafioQuay.Domain;
using RestSharp;
using System;
using System.Collections.Generic;

namespace DesafioQuay.Application
{
    public class CPTECService : ICPTECService
    {
        RestClient client;
        private readonly CPTEC_WebService config;

        public CPTECService(CPTEC_WebService config)
        {
            if (client == null)
                client = new RestClient(config.BaseURL);
        }

        public List<CidadeViewModel> ObterInformacoesCidade(string cidade)
        {
            var request = new RestRequest($"listaCidades?city={cidade}", DataFormat.Json);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");
            var retorno = client.Get<CidadesDTO>(request);
            return ConverteCidadeParaView(retorno.Data);
        }

        public PrevisaoDTO ObertPrevisaoDoTempoCidade(int codigoCidade)
        {
            var request = new RestRequest($"cidade/7dias/{codigoCidade}/previsao.xml", DataFormat.Xml);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");
            var retorno = client.Get<PrevisaoDTO>(request);
            return retorno.Data;
        }

        private List<CidadeViewModel> ConverteCidadeParaView(CidadesDTO cidadesDTO)
        {
            var retorno = new List<CidadeViewModel>();
            foreach (var cidade in cidadesDTO.Cidades)
            {
                retorno.Add(new CidadeViewModel
                {
                    Codigo = cidade.Id,
                    DescricaoCidade = string.Format(@"{0} | uf - {1} | previsao-do-tempo/{2}", cidade.Nome, cidade.Uf, cidade.Id)
                });
            }
            return retorno;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        
    }
}
