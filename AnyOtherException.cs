namespace MyApp
{
    class AnyOtherException : Exception
    {
        // Dziedziczenie w Java oznaczane jest słowem 'extends', implementowanie interfejsu przez 'implements'
        public AnyOtherException(string appended) : base(appended)
        {
            //                                      ^ wywołanie konstruktora klasy bazowej wygląda inaczej w Java
        }

        public AnyOtherException()
        {

        }
    }
}