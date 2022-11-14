using AgrupadorDeZap.Entidades;
using System;

namespace AgrupadorDeZap
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pessoaF = new PessoaFisica
            {
                Nome = "Lucas Cantoni",
                Endereco = "Rua Tal",
                Telefone = "044-TelFisica",
                Cpf = "123456789-00"
            };

            var pessoaJ = new PessoaJuridica
            {
                Nome = "Cantoni LTDA",
                Endereco = "Rua Tal",
                Telefone = "044-TelJuridica",
                Cnpj = "123456789/0001-00"
            };

            var grupinho = new Grupinho();
            var grupinhoservice = new GrupinhoService(grupinho);
            grupinhoservice.AddPessoa(pessoaF);
            grupinhoservice.AddPessoa(pessoaJ);


            Console.WriteLine("Lista Zap");
            foreach (var item in grupinho.ListaZap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Lista Zap Business");
            foreach (var item in grupinho.ListaZapBusiness)
            {
                Console.WriteLine(item);
            }
 
            Console.ReadLine();
        }
    }
}
