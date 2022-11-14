namespace AgrupadorDeZap.Interfaces
{
    public interface IPessoaFisica : ITelefone
    {
        public string Cpf { get; set; }
    }
}
