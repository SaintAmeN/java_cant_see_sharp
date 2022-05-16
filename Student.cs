namespace MyApp
{
    public abstract class Czlowiek
    {
        /* protected */ string imie { get; set; }
        public Czlowiek(string pImie)
        {
            this.imie = pImie;
        }
        public abstract void MetodaKtorejNieMoznaDziedziczyc();

        public string Nazwisko()
        {
            return "";
        }

        // Używanie properties zamiast getters / setters jest bardziej popularne w C#
        public string Imie
        {
            get => imie;
            set => imie = value;
        }
    }

    // sealed w c# jest odpowiednikiem 'final' w Java
    sealed class Student : Czlowiek
    {
        int wiek { get; set; }
        double numerButa { get; set; }

        public Student(string pImie, int pWiek, double pNumerButa) : base(pImie)
        {
            this.wiek = pWiek;
            this.numerButa = pNumerButa;
        }


        void PrzedstawSie()
        {
            Console.WriteLine("Mam na imie: {0}", this.Imie);
        }

        // W Javie metoda 'sealed' to metoda 'final'
        // W C# sealed override można wykonać tylko gdy dziedziczymy metodę aby zapobiec
        //  jej dalszemu rozszerzaniu, w Java final można używać nawet dla metod których nie dziedziczymy.
        public sealed override void MetodaKtorejNieMoznaDziedziczyc()
        {
            Console.WriteLine("Yep, nie moge odziedziczyć.");
        }

        override public string ToString()
        {
            return String.Format("Biedny student o imieniu {0}, jego wiek to: {1}", Imie, wiek);
        }
    }
}