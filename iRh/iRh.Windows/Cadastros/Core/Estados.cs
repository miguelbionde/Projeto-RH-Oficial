using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class Estados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Regiao { get; set; }

        public List<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();

            listaDeEstados.Add(new Estados
            {
                Id = 11,
                Nome = "Rondonia",
                Sigla = "RO"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Acre",
                Sigla = "AC"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Espírito Santo",
                Sigla = "ES"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Bahia",
                Sigla = "BA"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Pernambuco",
                Sigla = "PE"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Minas Gerais",
                Sigla = "MG"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "São Paulo",
                Sigla = "SP"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Rio de Janeiro",
                Sigla = "RJ"
            });

            return listaDeEstados;

        }
    }
}
