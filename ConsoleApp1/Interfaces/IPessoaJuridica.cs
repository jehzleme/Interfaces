namespace AgrupadorDeZap.Interfaces
{
    public interface IPessoaJuridica : ITelefone
    {
        public string Cnpj { get; set; }
    }
}
