using System.Reflection;

namespace MyApp
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class EnumAttr : Attribute
    {
        public EnumAttr()
        {
        }
    }

    public class BiletAutobusowyAttr : EnumAttr
    {
        public string? Opis { get; set; }
        public double Cena { get; set; }
    }

    enum BiletAutobusowy
    {
        [BiletAutobusowyAttr(Opis = "Bilet ważny cały dzień.", Cena = 2.3)]
        DZIENNY,
        [BiletAutobusowyAttr(Opis = "Bilet ważny jedną godzinę", Cena = 1.1)]
        GODZINNY,
        [BiletAutobusowyAttr(Opis = "Bilet na jeden przejazd, normalny.", Cena = 2.0)]
        NORMALNY,
        [BiletAutobusowyAttr(Opis = "Bilet ze zniżką emerytalną.", Cena = 10.0)]
        EMERYT,
        [BiletAutobusowyAttr(Opis = "Bilet ze zniżką studencką, bez grosika.", Cena = 0.99)]
        STUDENT
    }
}