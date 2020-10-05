using System.Collections.Generic;

namespace DesafioQuay.Domain
{
    public class CidadesDTO
    {
        public CidadesDTO()
        {
            Cidades = Cidades;
        }
        public List<Cidade> Cidades{ get; set; }
        
    }
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
    }
}
