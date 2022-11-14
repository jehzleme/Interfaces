using AgrupadorDeZap.Interfaces;

namespace AgrupadorDeZap
{
    public class GrupinhoService
    {
        private readonly IGrupinho _grupinho;

        public GrupinhoService(IGrupinho grupinho)
        {
            _grupinho = grupinho;
        }

        public void AddPessoa(IPessoaFisica pessoa)
        {
            _grupinho.ListaZap.Add(pessoa.Telefone);
        }

        public void AddPessoa(IPessoaJuridica pessoa)
        {
            _grupinho.ListaZapBusiness.Add(pessoa.Telefone);
        }
    }
}
