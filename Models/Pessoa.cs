using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaPrimeiraApiCrud.Models
{
    public class Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public int Idade { get; set; }
    }
}

