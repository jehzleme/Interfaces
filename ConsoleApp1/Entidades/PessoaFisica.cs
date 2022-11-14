using AgrupadorDeZap.Interfaces;

namespace AgrupadorDeZap.Entidades
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string Cpf { get; set; }
    }
}
