using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioQuay.Domain
{
    public class PrevisaoDTO : Cidade
    {
        public PrevisaoDTO()
        {
            Previsoes = new List<Previsao>();
        }
        public DateTime Atualizacao { get; set; }
        public List<Previsao> Previsoes { get; set; }
        
    }
    public class Previsao
    {
        public DateTime Dia { get; set; }
        public string Tempo { get; set; }
        public string DescricaoTempo
        {
            get
            {
                return new ListagemTempoDTO().Lista.Where(x => x.Sigla.Equals(Tempo)).FirstOrDefault().Descricao;
            }
            set
            {

            }
        }
        public short Maxima { get; set; }
        public short Minima { get; set; }
        public double Iuv { get; set; }
    }

}