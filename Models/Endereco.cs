using Microsoft.Identity.Client;
using System.Text.Json.Serialization;

namespace MinhaPrimeiraApiCrud.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; } = "";

        public int PessoaId { get; set; }

        [JsonIgnore] public Pessoa? Pessoa { get; set; }


    }

}