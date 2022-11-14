using System.Collections.Generic;
using AgrupadorDeZap.Interfaces;

namespace AgrupadorDeZap.Entidades
{
    public class Grupinho : IGrupinho
    {
        public List<string> ListaZap { get; set; }
        public List<string> ListaZapBusiness { get; set; }

        public Grupinho()
        {
            ListaZap = new List<string>();
            ListaZapBusiness = new List<string>();
        }
    }
}
