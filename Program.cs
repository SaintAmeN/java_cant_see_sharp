using System;
using System.Collections;
using System.Text;

// Coś, co nie jest możliwe w Java
// Jeśli istnieje, to globalny punkt wejścia (main) jest ignorowany
// Console.WriteLine("Hello World!");

// Coś, co nie istnieje w Java (namespace)
//  w ramach 'porządkowania' stosuje się wyłącznie package
namespace MyApp
{
    // Modyfikatory dostępu które nie istnieją w Java:
    // - Internal
    // - Protected Internal
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dostęp do "konsoli" odbywa się przez statyczne wywołanie na obiekcie Console
            //  W Java dostęp odbywa się przez akcesor do obiektu System.in / System.out 
            //  np.
            //      // do stworzenia obiektu który ma dostęp do wejścia
            //      // Scanner może być użyty również do innych celów
            //      Scanner scanner = new Scanner(System.in);
            //      
            //  ,
            //      // do wypisania treści na konsole
            //      System.out.prinln("Hello World!");
            //
            //  System.in oraz System.out są obiektami InputStream i OutputStream
            Console.WriteLine("Hello World!");

            // Podstawowy typ danych (prymitywny) int istnieje zarówno w Java jak i C#
            //  W odróżnieniu od C# Java posiada dla każdego typu prymitywnego typ obiektowy:
            //      int     -> Integer
            //      double  -> Double
            //      long    -> Long
            //      float   -> Float
            //
            //  Każdy z powyższych typów zawiera wiele funkcji które mają type-specific funkcje.
            int zmienna = 333;

            // Wypisanie treści na konsolę
            Console.WriteLine(zmienna);

            // Sformatowanie treści przed wypisaniem:
            Console.WriteLine(String.Format("Wartość zmiennej wynosi: '{0}'", zmienna));

            // Typ Integer jest typem obiektowym który pozwala dodatkowo przechowywać wartość null
            //      ponieważ w Java wszystko jest obiektem (tak samo w C#) mamy dziedziczenie niejawne
            //  Możliwe jest:
            //  
            //      Integer zmienna = null;
            //  Odpowiednikiem dla C# jest:
            int? x = null;

            Console.WriteLine("Inny sposób formatowania wartości bezpośrednio przez console, wartość: {0:d}", x);
            Console.WriteLine("Wypisanie wartości jako string: {0:s}", x.ToString());

            // Klasa String jest w języku Java pisana z wielkiej litery ponieważ dziedziczy po klasie Object
            //  Nie wszystkie typy w Java dziedziczą po Klasie Object i nie wszystkie są obiektowe
            string zmiennaTekstowa = null;

            // Brak wypisania wartości jeśli zmienna jest null, w Java otrzymamy 'null'
            Console.WriteLine("Wypisanie zmiennej tekstowej jako string: {0}", zmiennaTekstowa);

            // NullReferenceException (odpowiednij w Java to NullPointerException)
            // Console.WriteLine("Wypisanie zmiennej tekstowej jako string: {0}", zmiennaTekstowa.ToString());

            // Wypisanie obiektu wypisuje wyłącznie jego nazwę klasy
            DummyClass dc = new DummyClass();
            Console.WriteLine(dc);

            // Nie wolno stworzyć static class instance
            // DummyStaticClass dsc = new DummyStaticClass();

            // Dostęp do klas/metod statycznych odbywa się w taki sam sposób
            var wynik = DummyStaticClass.Oblicz(10, 15);

            // Wypisywanie podobne do Python
            Console.WriteLine("Wartość obliczona: {0}", wynik);

            // Wyrażenie "skrócony if" w C# ma nieco inną formę

            // string? zmiennaA = "tak, zmienna A miała wartość";
            string? zmiennaA = null;

            // Coś, co w Java nie istnieje
            // Conditional assignment - przypisanie do zmiennejB wartości zmiennejA tylko jeśli posiada wartość
            string zmiennaB = zmiennaA ?? "zmienna A nie miała wartości";

            // otrzymamy inne wyjście w zależności od wartości inicjalnej zmiennej zmiennaA
            Console.WriteLine("Czy zmiennaA miała wartość: {0}", zmiennaB);

            //  bool -> boolean w Java
            bool logiczna = zmiennaA != null;
            // Wyrażenie poniżej istnieje również w Java
            string wartośćAPrzypisana = (logiczna ? "Tak, ma wartość" : "Nie, pytasz już drugi raz!");
            Console.WriteLine("Czy zmiennaA miała wartość - podejście drugie: {0}", wartośćAPrzypisana);

            // Wyrażenia identyczne:  
            //  - if
            //  - switch
            //  - while
            //  - do while
            //  - foreach wygląda nieco inaczej
            //  - break i continue działają identycznie

            // Przypisanie inicjalne tablicy w c# różni się nieco od Java
            int[] tablica = { 1, 2, 3, 5 };
            // ForEach ma formę podobną do Python'a, różni się od Java
            foreach (int zmiennaZTablicy in tablica)
            {
                Console.Write("{0},", zmiennaZTablicy);
            }
            Console.WriteLine();

            string przykladTekst = "To jest sobie tekst";
            // Możliwe jest iterowanie znak po znaku string'a
            //  W Java String posiada oddzielną metodę która pozwala uzyskać dostęp do tablicy znaków.
            foreach (char znak in przykladTekst)
            {
                Console.Write("{0}-", znak);
            }
            Console.WriteLine();

            //  Porównanie treści tekstu (string) w Java dzieje się tylko i wyłącznie poprzez equals
            string tekst1 = new string("tekst");
            string tekst2 = new string("tekst");
            // string tekst2 = "innytekst";

            Console.WriteLine("Są równe: {0}", tekst1 == tekst2);       // w Java to wyrazenie zwróci false
            Console.WriteLine("Są równe: {0}", tekst1.Equals(tekst2));  // w Java to wyrażenie zwróci true jeśli treść jest taka sama.


            // Stwórzmy aplikację wczytującą tekst od użytkownika i przetwarzającą komendy
            string input;
            do
            {
                Console.WriteLine("Wprowadź tekst");
                input = Console.ReadLine();

                if (input == "bla")
                {
                    Console.WriteLine("...bla bla");
                }
                else if (input == "ping")
                {
                    Console.WriteLine("pong");
                }
                else if (input == "attack")
                {
                    Console.WriteLine("defence!");
                    break;
                }
            } while (input != "quit");

            // Exception, przykład dzielenie przez 0
            int a = 9, b = 0;
            try
            {

                // Możliwe jest nie podanie rodzaju przechwytywanego wyjątku, w Java jest to niemożliwe
                //  }
                //  catch
                //  { 

                Console.WriteLine("Spróbujmy podzielić: {0}", (a / b));
                // throw new AnyOtherException("wut?");
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("Podzielono przez 0! : {0}", dbze.Message);
            }
            catch (AnyOtherException aoe)
            {
                Console.WriteLine("Stało się coś innego: {0}", aoe);
            }

            // Podobnie w Java jak i C# jeśli dzielenie wykonamy na liczbach double, otrzymamy wynik infinity.
            double c = 9.0, d = 0.0;
            Console.WriteLine("Spróbujmy podzielić przykład 2: {0}", (c / d));

            // Wprowadzanie danych i ładowanie tworzenie obiektu
            Console.WriteLine("Wprowadź imie studenta:");
            string imie = Console.ReadLine();

            // Parsowanie, podejście 1 - Podobnie w Java
            int wiekStudenta = -1;
            try
            {
                Console.WriteLine("Wprowadź wiek studenta:");
                string wiek = Console.ReadLine();
                wiekStudenta = Int32.Parse(wiek);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }

            // Parsowanie, podejście 2 - niemożliwe w Java
            Console.WriteLine("Wprowadź numer buta studenta:");
            string numerButa = Console.ReadLine();
            double numerButaStudenta = -1.0;
            if (Double.TryParse(numerButa, out numerButaStudenta))
            {
                Console.WriteLine("Udało się sparsować numer buta studenta: {0}", numerButaStudenta);
            }
            else
            {
                Console.WriteLine("Numer buta studenta jest nieznaną wartością.");
            }


            var studencik = new Student(imie, wiekStudenta, numerButaStudenta);
            studencik.MetodaKtorejNieMoznaDziedziczyc();
            Console.WriteLine("ToString obiektu student: {0}", studencik);

            // Nie istnieje w Java value Empty
            string wartoscEmpty = string.Empty;

            // Nie istnieje możliwość odwoływania się tak do zmiennych
            Console.WriteLine($"'{imie}' --> '{wiekStudenta}' --> {numerButaStudenta}");

            string[] slowa = { "jeden", "dwa", "trzy", "cztery" };
            string wynikConcat = string.Concat(slowa);
            Console.WriteLine("Concat result: {0}", wynikConcat);

            string wynikJoin = string.Join('-', slowa);
            Console.WriteLine("Join result: {0}", wynikJoin);

            // Metody podobne:
            //  - indexOf       => IndexOf
            //  - lastIndexOf   => LastIndexOf
            //  - startsWith    => StartsWith
            //  - endsWith      => EndsWith
            //  - trim          => Trim
            //  - replace       => ?
            //  - replaceAll    => Replace
            //  - substring     => Substring
            StringBuilder sb = new StringBuilder();
            do
            {
                Console.WriteLine("Wprowadź tekst");
                input = Console.ReadLine();

                sb.Append(input);

                // sb.AppendLine
                // sb.AppendJoin
                // sb.AppendFormat
                // sb.Replace
                // sb.Insert
            } while (input != "quit");

            Console.WriteLine($"Wynik poprzedniego: {sb.ToString()}");

            // ref i out nie istnieją w Java, Java jest pass by value zawsze.
            int zmiennaDoPrzekazania = 10;
            Program.MetodaNieRef(zmiennaDoPrzekazania);
            Console.WriteLine("Przekazanie nie ref: {0}", zmiennaDoPrzekazania);

            Program.MetodaRef(ref zmiennaDoPrzekazania);
            Console.WriteLine("Przekazanie ref: {0}", zmiennaDoPrzekazania);

            // Innymi słowy - C# może zwrócić wiele wartości, Java nie.
            Program.DodajDoZmiennejOut(15, 20, out int outWynik);
            Console.WriteLine("Przekazanie out: {0}", outWynik);

            // Nie istnieje w Java
            (int, int) wynikDzieleniaIReszta = Program.PodzielIZwrocRowniezReszte(23, 20);
            Console.WriteLine("Dzielenie i reszta przez tuple: {0}, {1}", wynikDzieleniaIReszta.Item1, wynikDzieleniaIReszta.Item2);

            // Kolekcje:
            //  - Hashtable     ->      Hashtable 
            //  -               ->      List (w Java List jest klasą 'pomocniczą')
            //  - ArrayList     ->      ArrayList
            //  - LinkedList    ->      LinkedList
            //  - 
            Hashtable t = new Hashtable();
            // This notation is not possible in Java
            t["what"] = "that";

            List<string> l = new List<string> { "test1", "test2", "test3" };
            // Java .get(x) -> ElementAt(x) 
            string elementAt = l.ElementAt(1);
            string elAt = l[0];

            // W Java metody add zwracają bool(ean) z informacją czy dodawanie się udało
            // Java .addLast(element)   -> l.AddLast(element) (LinkedList)
            // Java .add(element)       -> l.Add(element) (List)
            // Java .add                -> l.AddRange
            // Java .get()              -> []
            // Java .contains()         -> .Contains
            // Java .clear()            -> .Clear
            l.Add(elementAt);
            // l.Contains(5); // w Java dozwolone jest sprawdzanie dowolnego typu

            IEnumerator<string> enumerator = l.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine("{0},", enumerator.Current);
            }

            // Odpowiednikiem Dictionary w Java jest Map
            // remove       ->  Remove
            // get          ->  []
            // containsKey  -> ContainsKey
            // contains     -> Contains
            Dictionary<string,string> cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            // cities.Contains("55"); // istnieje w Java, w C# nie

            // Queue i Stack działają podobnie w Java i C#, jednak 
            //  klasy końcowe implementujące te interfejsy to LinkedList (Queue) i Stack (Stack)
            // Tuple nie istnieje w Java


            // Operator [] nie jest dostępny dla żadnego typu poza tablicowym
            Console.WriteLine("Inny sposób wypisywania: {0}", cities["UK"]);
        }

        public static void MetodaNieRef(int zmienna)
        {
            zmienna = zmienna * 10;
        }
        public static void MetodaRef(ref int zmienna)
        {
            zmienna = zmienna * 10;
        }

        public static void DodajDoZmiennejOut(int a, int b, out int wynik)
        {
            wynik = a + b;
        }

        public static (int, int) PodzielIZwrocRowniezReszte(int a, int b)
        {
            int wynikDzielenia = a / b;
            int reszta = a % b;
            return (wynikDzielenia, reszta);
        }
    }


    // framework comparison
    // async
    // task
    // thread
    // await (nie istnieje)
    // streams 
    // synchronized działa podobnie
    // w Java nie ma delegatów
    // 
}