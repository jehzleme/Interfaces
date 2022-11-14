using System.Collections.Generic;

namespace AgrupadorDeZap.Interfaces
{
    public interface IGrupinho
    {
        List<string> ListaZap { get; set; }
        List<string> ListaZapBusiness { get; set; }
    }
}