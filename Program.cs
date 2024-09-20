do
{
    double liczba1 = 0;
    double liczba2 = 0;
    double wynik = 0;


    Console.WriteLine("Podaj dane do obliczeń.");
    Console.Write("Podaj mi pierwszą liczbę: ");
    liczba1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Dzięki! Teraz podaj drugą liczbę: ");
    liczba2 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("wybierz rodzaj działania na liczbach:");
    Console.WriteLine("+ - dodawanie");
    Console.WriteLine("- - odejmowanie");
    Console.WriteLine("* - mnożenie");
    Console.WriteLine("/ - dzielenie");



    switch (Console.ReadLine())
    {

        case "+":
            wynik = liczba1 + liczba2;
            Console.WriteLine("Twój wynik to:" + wynik);
            break;
        case "-":
            wynik = liczba1 - liczba2;
            Console.WriteLine("Twój wynik to:" + wynik);
            break;
        case "*":
            wynik = liczba1 * liczba2;
            Console.WriteLine("Twój wynik to:" + wynik);
            break;
        case "/":
            wynik = liczba1 / liczba2;
            Console.WriteLine("Twój wynik to:" + wynik);
            break;

        default:
            Console.WriteLine("Błędny wybór");
            break;
    }
    Console.WriteLine("Chcesz kontynuować? (T = TAK, N = NIE");

} while (Console.ReadLine().ToUpper() == "T");
Console.ReadKey();