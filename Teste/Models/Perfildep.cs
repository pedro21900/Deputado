using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class Perfildep
    { 
        public Dad Dados { get; set; }
        public Link[] links { get; set; }
    }

    public class Dad
    {
        public int id { get; set; }
        public string uri { get; set; }
        public string NomeCivil { get; set; }
        public Ultimostatus ultimoStatus { get; set; }
        public string cpf { get; set; }
        public string sexo { get; set; }
        public object urlWebsite { get; set; }
        public object[] redeSocial { get; set; }
        public string dataNascimento { get; set; }
        public object dataFalecimento { get; set; }
        public string ufNascimento { get; set; }
        public string municipioNascimento { get; set; }
        public string escolaridade { get; set; }
    }

    public class Ultimostatus
    {
        public int id { get; set; }
        public string uri { get; set; }
        public string nome { get; set; }
        public string siglaPartido { get; set; }
        public string uriPartido { get; set; }
        public string siglaUf { get; set; }
        public int idLegislatura { get; set; }
        public string UrlFoto { get; set; }
        public string email { get; set; }
        public string data { get; set; }
        public string nomeEleitoral { get; set; }
        public Gabinete gabinete { get; set; }
        public string situacao { get; set; }
        public string condicaoEleitoral { get; set; }
        public object descricaoStatus { get; set; }
    }

    public class Gabinete
    {
        public string nome { get; set; }
        public string predio { get; set; }
        public string sala { get; set; }
        public string andar { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }

    public class Links
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

}
