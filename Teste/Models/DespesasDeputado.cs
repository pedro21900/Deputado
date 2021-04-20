using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class DespesasDeputado
    {
        public D[] Dados { get; set; }
        public L[] Links { get; set; }
    }

    public class D
    {
        public int ano { get; set; }
        public int mes { get; set; }
        public string tipoDespesa { get; set; }
        public int codDocumento { get; set; }
        public string tipoDocumento { get; set; }
        public int codTipoDocumento { get; set; }
        public string dataDocumento { get; set; }
        public string numDocumento { get; set; }
        public float valorDocumento { get; set; }
        public string urlDocumento { get; set; }
        public string nomeFornecedor { get; set; }
        public string cnpjCpfFornecedor { get; set; }
        public float valorLiquido { get; set; }
        public float valorGlosa { get; set; }
        public string numRessarcimento { get; set; }
        public int codLote { get; set; }
        public int parcela { get; set; }
    }

    public class L
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

}
