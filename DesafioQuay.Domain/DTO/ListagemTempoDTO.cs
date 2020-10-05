using System.Collections.Generic;

namespace DesafioQuay.Domain
{
    public class ListagemTempoDTO
    {
        public ListagemTempoDTO()
        {
            Lista = new List<DescricaoTempo>
            {
                new DescricaoTempo { Descricao = "Encoberto com Chuvas Isoladas", Sigla = "ec" },
                new DescricaoTempo { Descricao = "Chuvas Isoladas", Sigla = "ci" },
                new DescricaoTempo { Descricao = "Chuvas ", Sigla = "c" },
                new DescricaoTempo { Descricao = "Instável", Sigla = "in" },
                new DescricaoTempo { Descricao = "Possibilidade de Pancadas de Chuva", Sigla = "pp" },
                new DescricaoTempo { Descricao = "Chuva pela Manhã", Sigla = "cm" },
                new DescricaoTempo { Descricao = "Chuva pela Noite", Sigla = "cn" },
                new DescricaoTempo { Descricao = "Pancadas de Chuva a Tarde", Sigla = "pt" },
                new DescricaoTempo { Descricao = "Pancadas de Chuva pela Manhã", Sigla = "pm" },
                new DescricaoTempo { Descricao = "Nublado e Pancadas de Chuva", Sigla = "np" },
                new DescricaoTempo { Descricao = "Pancadas de Chuva", Sigla = "pc" },
                new DescricaoTempo { Descricao = "Parcialmente Nublado", Sigla = "pn" },
                new DescricaoTempo { Descricao = "Chuvisco", Sigla = "cv" },
                new DescricaoTempo { Descricao = "Chuvoso", Sigla = "ch" },
                new DescricaoTempo { Descricao = "Tempestade", Sigla = "t" },
                new DescricaoTempo { Descricao = "Predomínio de Sol", Sigla = "ps" },
                new DescricaoTempo { Descricao = "Encoberto", Sigla = "e" },
                new DescricaoTempo { Descricao = "Nublado", Sigla = "n" },
                new DescricaoTempo { Descricao = "Céu Claro", Sigla = "cl" },
                new DescricaoTempo { Descricao = "Nevoeiro", Sigla = "nv" },
                new DescricaoTempo { Descricao = "Geada", Sigla = "g" },
                new DescricaoTempo { Descricao = "Neve", Sigla = "ne" },
                new DescricaoTempo { Descricao = "Pancadas de Chuva a Noite", Sigla = "pnt" },
                new DescricaoTempo { Descricao = "Possibilidade de Chuva", Sigla = "psc" },
                new DescricaoTempo { Descricao = "Possibilidade de Chuva pela Manhã", Sigla = "pcm" },
                new DescricaoTempo { Descricao = "Possibilidade de Chuva a Tarde", Sigla = "pct" },
                new DescricaoTempo { Descricao = "Possibilidade de Chuva a Noite", Sigla = "pcn" },
                new DescricaoTempo { Descricao = "Nublado com Pancadas a Tarde", Sigla = "npt" },
                new DescricaoTempo { Descricao = "Nublado com Pancadas a Noite", Sigla = "npn" },
                new DescricaoTempo { Descricao = "Nublado com Possibilidade de Chuva a Noite", Sigla = "ncn" },
                new DescricaoTempo { Descricao = "Nublado com Possibilidade de Chuva a Tarde", Sigla = "nct" },
                new DescricaoTempo { Descricao = "Nublado com Possibilidade de Chuva pela Manhã", Sigla = "ncm" },
                new DescricaoTempo { Descricao = "Nublado com Pancadas pela Manhã", Sigla = "npm" },
                new DescricaoTempo { Descricao = "Nublado com Possibilidade de Chuva", Sigla = "npp" },
                new DescricaoTempo { Descricao = "Variação de Nebulosidade", Sigla = "vn" },
                new DescricaoTempo { Descricao = "Chuva a Tarde", Sigla = "ct" },
                new DescricaoTempo { Descricao = "Possibilidade de Pancadas de Chuva a Noite", Sigla = "ppn" },
                new DescricaoTempo { Descricao = "Possibilidade de Pancadas de Chuva a Tarde", Sigla = "ppt" },
                new DescricaoTempo { Descricao = "Possibilidade de Pancadas de Chuva a Tarde", Sigla = "ppt" },
                new DescricaoTempo { Descricao = "Não Definido", Sigla = "ppm" },
                new DescricaoTempo { Descricao = "Possibilidade de Pancadas de Chuva pela Manhã", Sigla = "lt" }
            };
        }
        public List<DescricaoTempo> Lista{ get; set; }
    }

    public class DescricaoTempo
    {
        public string Descricao { get; set; }
        public string Sigla { get; set; }
    }
}
