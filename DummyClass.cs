namespace MyApp
{
    class DummyClass
    {
        // Oznaczenie readonly to 'final' w Java
        readonly string? dummyField;

        // W Java wartość domyślna parametrów nie istnieje
        public DummyClass(string pParametrDomyslny = "dummy")
        {
            this.dummyField = pParametrDomyslny;
        }

        // Polimorfizm konstruktorów jest możliwy w Java i C#
        public DummyClass(int innyParametr)
        {
        }



        // W Java komentarze nazywają się JavaDoc
        /// <summary>
        /// Metoda do zademonstrowania komentarza
        /// </summary>
        /// <param name="nazwaParametru">Parametr który można podać i nic nie robi</param>
        void MetodaZKomentarzem(int nazwaParametru = 1)
        {
            Console.WriteLine("Yep, doing nothing");
        }
    }

    // Nie jest możliwe stworzenie instancji obiektu w C#
    //  W Java oznaczay klasę jako abstract 
    public static class DummyStaticClass
    {
        // Jeśli nie można stworzyć obiektu tego typu, 
        //  to nie ma sensu tworzenia metody nie-statycznej, wszystkie metody powinny być statyczne
        public static double Oblicz(int a, int b)
        {
            return a + b;
        }
    }
}