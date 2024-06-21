using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VS_Code.Models
{
    public class Pessoa
    {
       public string Nome { get; set; }
       public int Idade { get; set; }

// isso aqui fez o código dar certo

       public Pessoa()
{
       Nome = string.Empty;
       Idade = 0;

}
       public void Apresentar()
       {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
       }


    }
}