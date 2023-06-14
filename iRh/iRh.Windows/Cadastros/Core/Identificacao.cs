using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class Identificacao
    {
        public string Documento { get; set; }
        public string Id { get; set; }

        public List<Identificacao> ObterDocumentos()
        {
            var listaDeDocumentos = new List<Identificacao>();
            listaDeDocumentos.Add(new Identificacao { Id = "1", Documento = "Carteira de Identidade" });
            listaDeDocumentos.Add(new Identificacao { Id = "2", Documento = "Carteira Funcional" });
            listaDeDocumentos.Add(new Identificacao { Id = "3", Documento = "Carteira Nacional De Habilitação"});
            listaDeDocumentos.Add(new Identificacao { Id = "4", Documento = "Passaport Brasileiro" });
            listaDeDocumentos.Add(new Identificacao { Id = "5", Documento = "Carteira de trabalho e Previdência Social" });
            listaDeDocumentos.Add(new Identificacao { Id = "6", Documento = "Carteira de Identidade do Indígena" });
            listaDeDocumentos.Add(new Identificacao { Id = "7", Documento = "Documento de identificação Digital" });
            return listaDeDocumentos;
        }
    }
}
