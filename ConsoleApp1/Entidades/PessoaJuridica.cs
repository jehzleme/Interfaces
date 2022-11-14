using AgrupadorDeZap.Interfaces;

namespace AgrupadorDeZap.Entidades
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string Cnpj { get; set; }
    }
}
