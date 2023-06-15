using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string Ddd { get; set; }
        public string Siafi { get; set; }


        public Endereco ObterPorCep(string cep)
        {

                var enderecoDaApi = new Endereco();

                //Instancia HTTP que permite obter informações da Internet através de uma URL
                var http = new HttpClient();

                var url = new Uri("https://viacep.com.br/ws/" + cep + "/json/");
                var result = http.GetAsync(url).GetAwaiter().GetResult();

                //Converte o resultado obtido em uma string
                var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                //Converte a string json para nossa classe ViaCepWrapper
                enderecoDaApi = JsonConvert.DeserializeObject<Endereco>(resultContent);
                return enderecoDaApi;
        }
    }
}
