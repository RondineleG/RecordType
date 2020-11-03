using static System.Console;

namespace RecordType
{
 
    // dados imutaveis por padrao
    record Pessoa(string Nome, string Sobrenome);

    // permite alterar as propriedades após a instanciação
    public record Pessoa1
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }

    //permite mesclar propriedades mutaveis usando init
    public record Pessoa2
    {
        public string Nome { get; init; }
        public string Sobrenome { get; set; }
    }



    class Program
    {


        static void Main()
        {

            var p = new Pessoa("Rondinele", "Guimaraes");
            /// p1.Nome = "Opa";  // Erro de compilaçãp
            /// p1.Nome = "Opa";  // Erro de compilaçãp
            WriteLine($"Olá {p.Nome} {p.Sobrenome}");
            var p1 = new Pessoa1
            {
                Nome = "Rondinele",
                Sobrenome = "Guimaraes"
            };

            p1.Nome = "Opa";
            p1.Sobrenome = "Foi";
            WriteLine($"Olá {p1.Nome} {p1.Sobrenome}"); // Olá Rondinele Guimaraes
            WriteLine($"Olá {p1.Nome} {p1.Sobrenome}"); // Olá Opa Foi

            var p2 = new Pessoa2
            {
                Nome = "Rondinele",
                Sobrenome = "Guimaraes"
            };

            WriteLine($"Olá {p2.Nome} {p2.Sobrenome}"); // Olá Rondinele Guimaraes

            // p2.Nome = "Opa";  // Erro de compilação
               p2.Sobrenome = "Sousa";

            WriteLine($"Olá {p2.Nome} {p2.Sobrenome}"); // Olá Rondinele Sousa
            ReadKey();
        }
    }
}
