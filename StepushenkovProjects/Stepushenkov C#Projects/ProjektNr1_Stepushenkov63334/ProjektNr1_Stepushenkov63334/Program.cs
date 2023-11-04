using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektNr1_Stepushenkov63334
{
    internal class Program
    {
        static void Main(string[] args)
        {//deklaracja zmiennej dla przechowania kodu "klawisza"

            ConsoleKeyInfo WybranaFunkcjonalniość;

            do
            {//wyczyszczenie okna konsoli
                Console.Clear();
                //wypisanie metryki programu
                Console.WriteLine("\n\n\t\tProgram ProjektNr1_Stepushenkov63334 umożliwia" +
                   "obliczanie wybranych wielkości matematycznych");
                Console.WriteLine("\n\tMenu programu");
                Console.WriteLine("\n\tA. Laboratorium Nr 1: Kalkulator obliczeń");
                Console.WriteLine("\n\tB. Projekt Nr 1: Kalkulator obliczeń");
                Console.WriteLine("\n\tX. Zakończenie (wyjście z programu)");
                //wypisanie komunikatu z podpowiedzią co ma zrobić Użytkownik programu
                Console.WriteLine("\n\tDla wyboru wymaganej" +
                    "funkcjonalności naciśnij odpowiedni" +
                    "klawisz (A lub B lub X): ");
                //wczytanie 'kodu' wybranej funkcjonalności
                WybranaFunkcjonalniość = Console.ReadKey();
                //rozpoznanie wybranej funkcjonalności
                if (WybranaFunkcjonalniość.Key == ConsoleKey.A)
                {
                    //realizacja Kalkulatora na zajęciach laboratoryjnych
                    KalkulatorObliczeńLaboratoryjnychNr1();
                }
                else
                    if (WybranaFunkcjonalniość.Key == ConsoleKey.B)
                {
                    //samodzielna realizacja Kalkulatora w ramach projektu nr 1
                    vsKalkulatorObliczeńProjektNr1();

                }
                else
                    if (WybranaFunkcjonalniość.Key != ConsoleKey.X)
                {//sygnalizacja błędu:niedozwolony 'klawisz'
                    Console.WriteLine("\n\n\tERROR: naciśnąłeś niedozwolony klawisz");
                    Console.WriteLine("\n\n\tDla kontynuacji działania programu naciśnij dowolny klawisz");
                    Console.ReadKey();
                }
                else //był wybrany 'klawisz' X
                    Console.WriteLine("\n\tTeraz nastąpi zakończenie" +
                        " działąnia programu");

            } while (WybranaFunkcjonalniość.Key != ConsoleKey.X);
            //wypisanie komunikatów końcowych przy zakończeniu działania programu
            Console.WriteLine("\n\n\tAutor programu: Stepushenkov, Nr albumu:63334");
            //wypisanie daty zakończenia działania programu
            Console.WriteLine("\n\tDzisiejsza data i godzina: {0}", DateTime.Now);
            Console.WriteLine("\n\tDla zakończenia działania programu naciśnij dowolny klawisz!");
            Console.ReadKey();


        }
        
        static void KalkulatorObliczeńLaboratoryjnychNr1()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            ConsoleKeyInfo WybranaFunkcjonalność;
            do
            {
                Console.Clear();
                //wypisanie metryki kalkulatora laboratoryjnego
                Console.WriteLine("\n\n\t\tMENU funkcjonalne Kalkulatora laboratoryjnego");
                Console.WriteLine("\n\tA. Obliczenie sumy arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\tB. Obliczenie iloczynu wyrazów ciągu liczbowego");
                Console.WriteLine("\tC. Obliczenie średniej arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\tD. Obliczenie pierwiastków równiania kwadratowego");
                Console.WriteLine("\tE. Obliczenie wartości wilomianu n-tego stopnia");
                Console.WriteLine("\tF. Konwersja liczby z systemu dziesiętnego na dwójkowy");
                Console.WriteLine("\tX. Zakończenie (wyjście z) kalkulatora laboratoryjnego");

                //wypisanie podpowiedzi do dalszego dzialania użytkownika
                Console.Write("\n\n\tNaciśnięciem odpowiednego klawisza (A, B, C, D, E, F, X) wybierz wymaganą funkcjonalność: ");
                //wczytanie kodu naciśniętego klawisza
                WybranaFunkcjonalność = Console.ReadKey();
                //rozpoznanie wybranej funcjonalności
                switch (WybranaFunkcjonalność.Key)
                {
                    case ConsoleKey.A:
                        //wypisanie podtwierdzenia wybranej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ: Obliczenie sumy arytmetycznej wyrazów ciągu liczbowego");
                        //deklaraja zmiennych
                        ushort n;
                        float Suma;
                        //obliczenie sumy wyrazów ciągu
                        SumaWyrazówCiąguLiczbowego(out Suma, out n);
                        //wypisanie wyników obliczeń
                        Console.WriteLine("\n\n\t WYNIKI OBLICZEŃ: obliczona suma wyrazów ciągu liczbowego" +
                            "o liczności n = {0} jest równa: Suma = {1, 6:F2}", n, Suma);
                        
                        break; // wyjście z instrukcji switch
                    case ConsoleKey.B:
                        //wypisanie podtwierdzenia wybranej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ: Obliczenie iloczynu wyrazu ciągu liczbowego");
                        //deklaraja zmiennych
                        //ushort n;
                        float Iloczyn;
                        IloczynWyrazówCiąguLiczbowego(out Iloczyn, out n);
                        Console.WriteLine("\n\n\t WYNIKI OBLICZEŃ: obliczony iloczyn wyrazów ciągu liczbowego" +
                        "o liczności n = {0} jest równa: Iloczyn = {1, 6:F2}", n, Iloczyn);








                        break; // wyjście z instrukcji switch
                    case ConsoleKey.C:
                        //wypisanie podtwierdzenia wybranej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ: Obliczenie średniej arytmetycznej wyrazu ciągu liczbowego");
                        //deklaraja zmiennych
                        float ŚredniaArytmetyczna;
                        ŚredniaArytmetyczna = ŚredniaArytmetycznaCiąguLiczbowego(out n);
                        Console.WriteLine("\n\n\t WYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu liczbowego" +
                        "o liczności n = {0} jest równa: Średnia Arytmetyczna = {1, 6:F2}", n, ŚredniaArytmetyczna);



                        break; // wyjście z instrukcji switch
                    case ConsoleKey.D:
                        //potwierdzenie wybrania danej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ: Wyznaczanie pierwiastków równania kwadratowego");
                        WyznaczaniePierwiastkowRownaniaKwadratowego();





                        break; // wyjście z instrukcji switch
                    case ConsoleKey.E:
                        //potwierdzenie wybrania danej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ:Obliczanie wartości wielomianu n-tego stopnia");
                        //deklarowanie zmiennych
                        float Wx;
                        float X;

                        ObliczanieWartosciWielomianu(out Wx, out X, out n);
                        //wypisanie wyniku obliczeń w notacji stałopozycyjnej (fixed-point)
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona wartość wielomianu n = {0}-ego stopnia" +
                            " dla zmiennej niezależnej X ={1, 6:F2} jest równa: {2, 8:F3}", n, X, Wx);
                        /* wypisanie wyniku obliczeń w notacji naukowej (postać wykładnicza), w której jedna cyfra zawsze poprzedza znak dziesiętny (czyli kropke: .)*/
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona wartość wielomianu n = {0}-ego stopnia" +
                            " dla zmiennej niezależnej X ={1, 6:E2} jest równa: {2, 8:E3}", n, X, Wx);
                        /*wypisanie wyniku obliczeń w najbardziej notacji zwięzłej (dobieranej automatycznie na podstawie wartości zmiennej)*/
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona wartość wielomianu n = {0}-ego stopnia" +
                            " dla zmiennej niezależnej X ={1, 6:G} jest równa: {2, 8:G}", n, X, Wx);






                        break; // wyjście z instrukcji switch
                    case ConsoleKey.F:
                        //potwierdzenie wybrania danej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANO: I.Konwersja liczby z systemu dziesiętnego na dwójkowy");
                        /*dokomponujemy zadanie obsługi funkcjonalości: 1)konwersja znakowego zapisu liczby naturalnej(ushort) w systemie
                         dziesiętnym na wartość 
                        2) konwersja wartości liczby naturalnej (ushort) na znakowy zapis liczby w systemie dwójkowym*/
                        //realizacja komponentu 1)
                        string ZZL;//ZZL - Znakowy Zapis Liczby
                        //deklaracja zmiennej dla przechowania wartości liczby po konwersji 
                        ushort LiczbaPoKonwersji;
                        //wczytanie liczby znakowej do konwersji na wartość
                        Console.Write("\n\n\tPodaj liczbę (w systemie dziesiętnym)  do konwersji: ");
                        //wczytanie liczby do konwersji
                        ZZL = Console.ReadLine();
                        //usunięcie zbędnych "białych znaków" (spacja, znak tabulacji)
                        ZZL = ZZL.Trim();
                        //konwersja znakowa zapisu liczby na wartość przez wywołanie metody
                        LiczbaPoKonwersji = KonwersjaZnakowejLiczbyNaWartosc(ZZL);
                        //dla celów testowych wypisujemy liczbę po konwersji przy użyciu metody WriteLine
                        Console.WriteLine("\n\n\tTRACE: Liczba po konwersji: " + ZZL.ToString());
                        //realizacja komponentu 2)
                        ushort LiczbaDoKonwersji = LiczbaPoKonwersji;
                        //konwersja wartości (liczby ushort) na znakowy zapis w systemie dwójkowym
                        KonwersjaLiczbyNaturalnejNaLiczbeBinarna(LiczbaDoKonwersji, out ZZL);
                        //wypisanie wyniku konwersji
                        Console.WriteLine("\n\n\tWYNIK KONWERSJI: Wartość liczby po konwersji ze znakowego jej zapisu w dziesiętnym systemie" +
                            "liczbowym: {0},\nktóra po konwersji na system dwójkowy (binarny) ma następujący zapis znakowy: {1}", LiczbaPoKonwersji, ZZL);







                        break; // wyjście z instrukcji switch
                    case ConsoleKey.X:



                        break; // wyjście z instrukcji switch
                    default:
                        //sygnalizacja błędów

                        Console.WriteLine("\n\n\tERROR: Nacisnąłeś niedozwolony klawisz");


                        break;
                }// od switch


                // chwilowe zatrzymanie dla odczytania wypisanego komunikatu
                Console.WriteLine("\n\n\tDla kontynuacji działania programu naciśnij dowolny klawisz");
                Console.ReadKey();




            } while (WybranaFunkcjonalność.Key != ConsoleKey.X);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void vsKalkulatorObliczeńProjektNr1()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            ConsoleKeyInfo vsWybranaFunkcjonalność;
            
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\tProjekt Nr 1: Kalkulator obliczeń");
                Console.WriteLine("\n\tMENU funkcjonalne Kalkulatora");
                Console.WriteLine("\n\tA. Obliczenie średniej harmonicznej wyrazów ciągu liczbowego");
                Console.WriteLine("\tB. Obliczenie średniej kwadratowej wyrazów ciągu liczbowego");
                Console.WriteLine("\tC. Obliczenie średniej potęgowej (średniej uogólnionej) wyrazów ciągu liczbowego");
                Console.WriteLine("\tD. Obliczenie średniej geometrycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\tE. Obliczenie ceny jednostki paszy (według średniej ważonej) składającej się" +
                    "(utworzonej, skomponowanej) z kilku składników");
                Console.WriteLine("\tF. Obliczanie wartości wielomianu n-tego stopnia według schematu Hornera");
                Console.WriteLine("\tG. Konwersja liczby całkowitej zapisanej znakowo w systemie liczbowym o podanej" +
                    "podstawie liczenia na wartość i jej wypisanie znakowo w innym systemie liczbowym " +
                    "o podanejpodstawie licenia");
                Console.WriteLine("\tX. Zakończenie (wyjście z) 'kalkulatora obliczeń zadania projektowegoNr 1'");
                Console.WriteLine("\n\n\tAby wybrać jedną z funkcji kalkulatora, naciśnij odpowiedni klawisz");

                vsWybranaFunkcjonalność = Console.ReadKey();
                switch (vsWybranaFunkcjonalność.Key)
                {
                    case ConsoleKey.A:
                        //wypisanie podtwierdzenia wybranej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ: Obliczenie średniej harmonicznej wyrazów ciągu liczbowego");
                        //daklaracja zmiennych
                        ushort vsn;
                        float vsSH;
                        //obliczenie średniej harmonicznej ciągu wyrazów
                        vsŚredniaHarmonicznaCiąguWyrazów(out vsSH, out vsn);
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona średnia harmoniczna wyrazów ciągu liczbowego" + "o liczności n = {0} jest równa: SH = {1, 6:F2}", vsn, vsSH);
                        break;

                    case ConsoleKey.B:
                        //wypisanie podtwierdzenia wybranej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ: Oblicanie średniej kwadratowej wyrazów ciągu liczbowego");
                        //daklaracja zmiennych
                        double vsSK;
                        //obliczenie średniej harmonicznej ciągu wyrazów
                        vsŚredniaKwadratowaCiąguWyrazów(out vsSK, out vsn);
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona Średnia kwadratowa wyrazów ciągu liczbowego" +
                            "o liczności n = {0} jest równa: SK = {1, 6:F2}", vsSK, vsn);


                        break;

                    case ConsoleKey.C:
                        //wypisanie podtwierdzenia wybranej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ: Obliczenie średniej potęgowej rzędu a");
                        //deklaracja zmiennych
                        double vsSP;
                        double vsa;

                        //obliczenie średniej potęgowej rzędu a
                        vsŚredniaPotęgowa(out vsSP, out vsn, out vsa);

                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona średnia potęgowa o liczności n = {0}, rzędu a = {0} jest rowna: " +
                            "SP = {1, 6:F2}", vsn, vsSP, vsa);


                        break;

                    case ConsoleKey.D:
                        //wypisanie podtwierdzenia wybranej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ: Obliczenie średniej geometrycznej ciągu liczbowego");
                        //deklaracja zmiennych
                        double vsSG;

                        //obliczenie średniej geometrycznej
                        vsŚredniaGeometrycznaCiąguWyrazów(out vsSG, out vsn);

                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona średnia geometryczna ciągu liczbowego" +
                            "o liczności n = {0} jest równa: SG = {1, 6:F2}", vsn, vsSG);
                        break;

                    case ConsoleKey.E:
                        //wypisanie podtwierdzenia wybranej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ: Obliczenie ceny jednostki paszy (według średniej ważonej)składająej się (utworzonej, skomponowanej) z kilku składników");
                        //deklaracja zmiennych
                        float vsJP;
                        float vsb;
                        float vsc;
                        //obliczenie ceny jednostki paszy
                        vsCenaJednostkiPaszy(out vsJP, out vsb, out vsc, out vsn);

                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: Cena jednostki paszy równia się: JP = {0}", vsJP);


                        break;

                    case ConsoleKey.F:
                        //potwierdzenie wybrania danej funkcjonalności
                        Console.WriteLine("\n\n\tWYBRANA FUNKCJONALNOŚĆ:Obliczanie wartości wielomianu n-tego stopnia");
                        //deklarowanie zmiennych
                        float vsWW;
                        float vsx;

                        vsObliczanieWartosciWielomianu(out vsWW, out vsx, out vsn);
                        //wypisanie wyniku obliczeń w notacji stałopozycyjnej (fixed-point)
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona wartość wielomianu n = {0}-ego stopnia" +
                            " dla zmiennej niezależnej X ={1, 6:F2} jest równa: {2, 8:F3}", vsn, vsx, vsWW);
                        /* wypisanie wyniku obliczeń w notacji naukowej (postać wykładnicza), w której jedna cyfra zawsze poprzedza znak dziesiętny (czyli kropke: .)*/
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona wartość wielomianu n = {0}-ego stopnia" +
                            " dla zmiennej niezależnej X ={1, 6:E2} jest równa: {2, 8:E3}", vsn, vsx, vsWW);
                        /*wypisanie wyniku obliczeń w najbardziej notacji zwięzłej (dobieranej automatycznie na podstawie wartości zmiennej)*/
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczona wartość wielomianu n = {0}-ego stopnia" +
                            " dla zmiennej niezależnej X ={1, 6:G} jest równa: {2, 8:G}", vsn, vsx, vsWW);
                        break;

                    case ConsoleKey.G:
                        //potwierdzenie wybrania danej funkcjonalności


                        break;

                    case ConsoleKey.X:


                        break;
                    default:
                        Console.WriteLine("\n\n\tERROR: Nacisnąłeś niedozwolony klawisz");
                        break;



                }

                // chwilowe zatrzymanie dla odczytania wypisanego komunikatu
                Console.WriteLine("\n\n\tDla kontynuacji działania programu naciśnij dowolny klawisz");
                Console.ReadKey();





            } while (vsWybranaFunkcjonalność.Key != ConsoleKey.X);
            Console.WriteLine("\n\n\t\tProjekt Nr 1: Kalkulator obliczeń");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

        }
        //regiony
        #region kalkulator laboratoryjny
        static void SumaWyrazówCiąguLiczbowego(out float Suma, out ushort n)
        {
            //pomocnicze ustalanie wartości przekazywanych przez parametry
            Suma = 0.0f; n = 0;
            //deklaracja zmiennej a dla przechowania wczytanej wartosści ciągu liczbowego
            float a;
            //wczytanie liczności ciągu liczbowego
            Console.Write("\n\n\tPodaj liczność ciągu liczbowego: ");
            while (!ushort.TryParse(Console.ReadLine(), out n))
            {//sygnalizacja błędów
                Console.WriteLine("\n\n\tERROR: w zapisie ciągu liczbowego wystąpił niedozwolony znak");
                //ponowienie zaproszenia do podania liczności ciągu liczbowego
                Console.Write("\n\n\tPodaj ponownie liczność ciągu liczbowego: ");

            }
            //obliczenie sumy wyrazów ciągu liczbowego z zależności
            Suma = 0.0F;//I = 1.0F
            for (ushort i = 1; i <= n; i++)
            {
                Console.Write("\n\tPodaj wartość {0} -ego wyrazu ciągu liczbowego: ", i);
                while (!float.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("\n\n\tERROR: w zapisie wartości {0} -go wyrazu szeregu wystąpil niedozwolony znak");
                    Console.Write("\n\n\tPodaj ponownie wartość {0} -ego  ciągu liczbowego: ", i);


                }
                Suma = Suma + a;//I = i * a
            }
        }
        static void IloczynWyrazówCiąguLiczbowego(out float I, out ushort n)
        {
            //pomocnicze ustalanie wartości przekazywanych przez parametry
            I = 0.0f; n = 0;
            //deklaracja zmiennej a dla przechowania wczytanej wartosści ciągu liczbowego
            float a;
            //wczytanie liczności ciągu liczbowego
            Console.Write("\n\n\tPodaj liczność ciągu liczbowego: ");
            while (!ushort.TryParse(Console.ReadLine(), out n))
            {//sygnalizacja błędów
                Console.WriteLine("\n\n\tERROR: w zapisie ciągu liczbowego wystąpił niedozwolony znak");
                //ponowienie zaproszenia do podania liczności ciągu liczbowego
                Console.Write("\n\n\tPodaj ponownie liczność ciągu liczbowego: ");

            }
            //obliczenie iloczynu wyrazów ciągu liczbowego z zależności
            I = 1.0F;
            for (ushort i = 1; i <= n; i++)
            {
                Console.Write("\n\tPodaj wartość {0} -ego wyrazu ciągu liczbowego: ", i);
                while (!float.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("\n\n\tERROR: w zapisie wartości {0} -go wyrazu szeregu wystąpil niedozwolony znak");
                    Console.Write("\n\n\tPodaj ponownie wartość {0} -ego  ciągu liczbowego: ", i);


                }
                I = I * a;
            }
        }
        static float ŚredniaArytmetycznaCiąguLiczbowego(out ushort n)
        {
            float Suma;
            SumaWyrazówCiąguLiczbowego(out Suma, out n);
            return Suma / n;

        }
        static void WyznaczaniePierwiastkowRownaniaKwadratowego()
        {
            //deklaracja zmiennych
            float a, b, c;
            //deklaracja zmiennych dla obliczanych wartosci
            float Delta, X1, X2, X1_2;
            //wczytanie wartości a
            do
            {
                Console.WriteLine("\n\n\tPodaj wartość współczynnika a: ");
                a = float.Parse(Console.ReadLine());
                //sprawdzenie warunku wejściowego
                if (a == 0.0F)
                {
                    Console.WriteLine("\n\n\tERROR: wartość współczynnika 'a' musi być różna od zera!");
                    Console.Write("\n\n\tPodaj wartość współczynnika 'a' ponownie ");
                }

            } while (a == 0.0F);
            Console.Write("\n\n\tPodaj wartość współczynnika b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("\n\n\tPodaj wartość współczynnika c: ");
            c = float.Parse(Console.ReadLine());
            //obliczanie delty
            Delta = b * b - 4.0F * a * c;
            //wypisanie delty
            Console.WriteLine("\n\tObliczona wartość delty wynosi: " + Delta);
            //obliczanie wartości pierwiastków równania kwadratowego
            if (Delta > 0.0F)
            {//obliczanie dwóch pierwiastków
                X1 = (-b - (float)Math.Sqrt(Delta)) / (2.0F * a);
                X2 = (-b + (float)Math.Sqrt(Delta)) / (2.0F * a);
                //wypisanie wyniku obliczeń
                Console.WriteLine("\n\tWYNIKI: \n X1= {0} \n X2= {1}", X1, X2);
            }
            else
                if (Delta < 0.0F)
                Console.WriteLine("\n\n\tRównanie o podanych współczynnikach nie ma pierwiastków rzeczywsistych");
            else
            {
                X1_2 = -b / (2.0F * a);
                Console.WriteLine("\n\tWYNIK: X1_2 = {0}", X1_2);
            }

        }
        static ushort KonwersjaZnakowegoZapisuLiczbyNaturalnej(string ZZL)
        {
            //deklaracje zmiennych dla potrzeb konwersji
            ushort L;
            ushort n; //dla cyfr
            byte p = 10;
            char Cyfra;
            n = (ushort)ZZL.Length;
            //wyznaczanie wartości liczby ZZL węług schematu konwersji
            L = 0;
            for (byte i = 0; i < n; i++)
            {
                Cyfra = ZZL[i];
                if ((Cyfra >= '0' && Cyfra <= '9'))
                    L = (ushort)(L * p + ((byte)Cyfra - (byte)'0'));
                else
                {
                    Console.WriteLine("\n\n\tERROR: W podanym zapisie liczby do konwersji wystąpil niedozwolony znak");
                    Console.WriteLine("\n\tDla kontynuacji działania programu naciśnij dowolny znak");
                    Console.ReadKey();
                    return 0;
                }

            }

            return L;


        }
        static ushort KonwersjaZnakowejLiczbyNaWartosc(string ZZL)
        {//deklaracje
            ushort L; //wartość liczby po konwersji
            int N; //liczba cyfr w ZZL
            byte p = 10; //podstawa systemu liczbowego dla liczby zapisaniej w ZZL
            char Cyfra;
            //określenie (odczytanie) liczby cyfr w ZZL
            N = ZZL.Length;
            //konwersja ZZL na wartość według schematu Hornera
            L = 0; //warunek brzegowy
            for (byte i = 0; i < N; i++)
            {//pobranie i-tej cyfry z ZZL
                Cyfra = ZZL[i];
                //sprawdzenie, czy to jest na pewno cyfra: 0,1..
                if ((Cyfra >= '0') && (Cyfra <= '9'))
                    L = (ushort)(L * p + ((byte)Cyfra - (byte)'0'));
                else
                {//sygnalizacja błedu
                    Console.WriteLine("\n\n\tERROR: w podanym zapisie liczby do konwersji wystąpił niedozwolony znak");
                    //chwilowe zatrzymanie programu
                    Console.Write("\n\n\tDla zakończenia działania programu naciśnij dowolny klawisz");
                    Console.ReadKey();
                    //zakończenie konwersji
                    return 0;
                }
            }
            //zwrotne przekazanie wyniku konwersji
            return L;






        }
        static void KonwersjaLiczbyNaturalnejNaLiczbeBinarna(ushort L, out string ZZL)
        {
            //konwersja liczby (wartości) L na zapis znakowy w dwójkowym systemie liczbowym
            string SchowekReszt = "";//deklaracja i wyzerowanie "schowka" dla reszt z dzielenia
            byte Reszta; //dla przechowania reszty z dzielenia
            int Licznik = 0; //dla liczenia reszt z dzielenia wpisanych do miennej SchowekReszt
            byte q = 2; //podstawa systemu liczbowego dla liczby wyjściowej(po konwersji)
            //wyznaczanie znakowego zapisu liczby w dziesiętnym systemie liczbowym
            while (L > 0) //powtarzamy obliczenia podczas gdy (L > 0) 
            {// obliczanie reszty z dzielenia przez podstawę systemu liczbowego
                Reszta = (byte)(L % q);//dzielenie modulo
                //dodanie do tworzonego łańcucha znaków reszt z dzielenia nowej Reszty
                SchowekReszt = SchowekReszt + (char)(Reszta + (byte)'0');
                //zwiększenie licznika znaków (reszt z dzielenia) wpisanych do zmiennej SchowekReszt
                Licznik++;
                //obliczanie wyniku dzielenia całkowitoliczbowego przez podstawę systemu liczbowego
                L = (ushort)(L / q);
            }
            //odwrócenie znakowego zapisu reszt z dzielenia wpisanych do zmiennej SchowekReszt
            ZZL = "";//wyzerowanie zmiennej typu 'string'
            for (int j = Licznik - 1; j >= 0; j--)
                ZZL = ZZL + SchowekReszt[j];
            //wynik będzie przekazany przez parametr wyjściowy: ZZL
        }
        static void ObliczanieWartosciWielomianu(out float Wx, out float X, out ushort n)
        {//pomocnicze przypisanie wartości testowych wyjściowym parametrom formalnym
            Wx = X = 0.0F;
            n = 0;/*możemy ten wiersz 'ująć' w znaki komentarza, ale możemy go też pozostawić
            gdyż wartości tych zmiennych będą nadpisane wartościami wynikowymi*/
            //wczytanie stopnia wielomianu
            Console.WriteLine("\n\n\tPodaj stopień wielomianu: ");
            while (!ushort.TryParse(Console.ReadLine(), out n))
            {//sygnalizujemy błąd
                Console.WriteLine("\n\n\tERROR: w podanej wartości stopnia wielomianu wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie stopień wielomianu: ");
            }
            //wczytanie wartości zmiennej niezależnej X
            Console.Write("\n\n\tPodaj wartości zmiennej niezależnej X: ");
            while (!float.TryParse(Console.ReadLine(), out X))
            {//sygnalizujemy błąd
                Console.WriteLine("\n\n\tERROR: w podanej wartości zmiennej X wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie wartości zmiennej niezależnej X: ");
            }
            float a; //deklaracja pomoocnicza dla przechowania wartości wczytanego współczynnika wielomianu
            Wx = 0.0F;//warunek brzegowy
            //iteracyjne obliczanie wartości wielomianu według schematu Hornera
            for (int i = n; i >= 0; i--)
            {//wczytanie i-tego współczynnika wielomianu
                Console.Write("\n\n\tPodaj wartość {0}-go współczynnika wielomianu: ", i);
                while (!float.TryParse(Console.ReadLine(), out a))
                {//sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w zapisie wartości {0}-go współczynnika wielomianu wystąpił niedozwolony znak", i);
                    Console.Write("\n\n\tPodaj ponownie wartość {0}-go współczynnika wielomianu: ", i);
                }
                //iteracyjne obliczanie wartości wielomianu według schematu Hornera
                Wx = Wx * X + a;
            }
        }
        #endregion
        #region regiony kalkulatora projektowego nr 1 Stepushenkov 63334
        static void vsŚredniaHarmonicznaCiąguWyrazów(out float vsSH, out ushort vsn)
        {
            vsSH = 0.0f; vsn = 0;
            float vsa;
            Console.Write("\n\n\tPodaj liczność ciągu liczbowego: ");
            while (!ushort.TryParse(Console.ReadLine(), out vsn))
            {//sygnalizacja błędów
                Console.WriteLine("\n\n\tERROR: w zapisie ciągu liczbowego wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie liczność ciągu liczbowego: ");

            }

            float vsres = 0.0f;
            vsSH = 0.0F;
            for (ushort i = 0; i < vsn; i++)
            {
                Console.Write("\n\tPodaj wartość {0} -ego wyrazu ciągu liczbowego: ", i);
                while (!float.TryParse(Console.ReadLine(), out vsa))
                {
                    Console.WriteLine("\n\n\tERROR: w zapisie wartości {0} -go wyrazu szeregu wystąpił niedozwolony znak");
                    Console.Write("\n\n\tPodaj ponownie wartość {0} -ego liczbowego: ", i);
                }
                vsres += (1 / vsa);



            }
            vsSH = vsn / vsres;



        }
        static void vsŚredniaKwadratowaCiąguWyrazów(out double vsSK, out ushort vsn)
        {
            vsSK = 0.0f; vsn = 0;
            float vsa;
            Console.WriteLine("\n\n\tPodaj liczność ciągu liczbowego: ");
            while (!ushort.TryParse(Console.ReadLine(), out vsn))
            {//sygnalizacja błędów
                Console.WriteLine("\n\n\tERROR: w zapisie ciągu liczbowego wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie liczność ciągu liczowego: ");

            }

            float vsres = 0.0f;
            vsSK = 0.0F;
            for (ushort i = 0; i < vsn; i++)
            {
                Console.Write("\n\tPodaj wartość {0} -ego wyrazu ciągu liczbowego: ", i);
                while (!float.TryParse(Console.ReadLine(), out vsa))
                {
                    Console.WriteLine("\n\n\tERROR: w zapisie wartości {0} -go wyrazu szeregu wystąpił niedozwolony znak");
                    Console.Write("\n\n\tPodaj ponownie wartość {0} -ego licabowego: ", i);

                }
                vsres = vsres + vsa * vsa;


            }
            vsSK = Math.Sqrt(vsres / vsn);

        }
        static double vsŚredniaPotęgowa(out double vsSP, out ushort vsn, out double vsk)
        {
            vsSP = 0.0f; vsn = 0;
            float vsa;
            vsk = 0.0f;
            Console.WriteLine("\n\n\tPodaj liczność ciągu liczbowego: ");
            while (!ushort.TryParse(Console.ReadLine(), out vsn))
            {//sygnalizacja błędów
                Console.WriteLine("\n\n\tERROR: w zapisie ciągu liczbowego wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie liczność ciągu liczbowego");


            }
            Console.WriteLine("\n\n\tPodaj licznosć rzędu: ");
            while (!double.TryParse(Console.ReadLine(), out vsk))
            {//sygnalizacja błędów
                Console.WriteLine("\n\n\tERROR: w zapisie rzędu liczbowego wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie liczność rzędu liczbowego");
            }
            double vsres = 0.0f;

            for (ushort i = 0; i < vsn; i++)
            {
                Console.Write("\n\tPodaj wartość {0} -ego wyrazu ciągu liczbowego: ", i);
                while (!float.TryParse(Console.ReadLine(), out vsa))
                {
                    Console.WriteLine("\n\n\tERROR: w zapisie wartości {0} -go wyrazu szeregu wystąpił niedozwolony znak");
                    Console.Write("\n\n\tPodaj ponownie wartość {0} -ego licabowego: ", i);

                }
                vsres = vsres + (Math.Pow(vsa, vsk));

            }
            vsSP = Math.Pow((vsres / vsn), 1 / vsk);
            return vsSP;

        }
        static void vsŚredniaGeometrycznaCiąguWyrazów(out double vsSG, out ushort vsn)
        {
            vsSG = 0.0f; vsn = 0;

            float vsa;

            Console.WriteLine("\n\n\tPodaj liczność ciągu liczbowego: ");

            while (!ushort.TryParse(Console.ReadLine(), out vsn))
            {//sygnalizacja błędów
                Console.WriteLine("\n\n\tERROR: w zapisie ciągu liczbowego wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie liczność ciągu liczowego: ");
            }
            float vsres = 1.0f;

            for (ushort i = 0; i < vsn; i++)
            {
                Console.Write("\n\tPodaj wartość {0} -ego wyrazu ciągu liczbowego: ", i);
                while (!float.TryParse(Console.ReadLine(), out vsa))
                {
                    Console.WriteLine("\n\n\tERROR: w zapisie wartości {0} -go wyrazu szeregu wystąpił niedozwolony znak");
                    Console.Write("\n\n\tPodaj ponownie wartość {0} -ego licabowego: ", i);
                }
                vsres = vsres * vsa;

            }
            vsSG = Math.Pow(vsres, Math.Pow(vsn, -1));


        }
        static void vsCenaJednostkiPaszy(out float vsJP, out float vsc, out float vsm, out ushort vsn)
        {
            vsJP = 0.0f;
            vsc = 0.0f;
            vsm = 0.0f;
            vsn = 0;
            Console.WriteLine("\n\n\tPodaj liczność składników: ");
            while (!ushort.TryParse(Console.ReadLine(), out vsn))
            {//sygnalizacja błędów
                Console.WriteLine("\n\n\tERROR: w zapisie liczności składników wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie liczność składników liczowego: ");
            }
            float vsres;
            vsres = 0.0f;
            float vsresm;
            vsresm = 0.0f;
            for (ushort i = 0; i < vsn; i++)
            {
                Console.WriteLine("\n\n\tPodaj ilość {0} -ego składniku: ", i);
                while (!float.TryParse(Console.ReadLine(), out vsm))
                {
                    Console.WriteLine("\n\n\tERROR: w zapisie ilości wystąpił niedozwolony znak");
                    Console.Write("\n\n\tPodaj ponownie ilość składników liczowego: ");
                }
                Console.WriteLine("\n\n\tPodaj cenę {0} -ego składnika: ", i);
                while (!float.TryParse(Console.ReadLine(), out vsc))
                {
                    Console.WriteLine("\n\n\tERROR: w zapisie ceny wystąpił niedozwolony znak");
                    Console.Write("\n\n\tPodaj ponownie cenę składników liczowego: ");
                }
                vsres = vsres + (vsc * vsm);
                vsresm += vsm;

            }
            vsJP = vsres / vsresm;

        }
        static void vsObliczanieWartosciWielomianu(out float vsWx, out float vsX, out ushort vsn)
        {
            //pomocnicze przypisanie wartości testowych wyjściowym parametrom formalnym
            vsWx = vsX = 0.0F;
            vsn = 0;/*możemy ten wiersz 'ująć' w znaki komentarza, ale możemy go też pozostawić
            gdyż wartości tych zmiennych będą nadpisane wartościami wynikowymi*/
            //wczytanie stopnia wielomianu
            Console.WriteLine("\n\n\tPodaj stopień wielomianu: ");
            while (!ushort.TryParse(Console.ReadLine(), out vsn))
            {//sygnalizujemy błąd
                Console.WriteLine("\n\n\tERROR: w podanej wartości stopnia wielomianu wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie stopień wielomianu: ");
            }
            //wczytanie wartości zmiennej niezależnej X
            Console.Write("\n\n\tPodaj wartości zmiennej niezależnej X: ");
            while (!float.TryParse(Console.ReadLine(), out vsX))
            {//sygnalizujemy błąd
                Console.WriteLine("\n\n\tERROR: w podanej wartości zmiennej X wystąpił niedozwolony znak");
                Console.Write("\n\n\tPodaj ponownie wartości zmiennej niezależnej X: ");
            }
            float vsa; //deklaracja pomoocnicza dla przechowania wartości wczytanego współczynnika wielomianu
            vsWx = 0.0F;//warunek brzegowy
            //iteracyjne obliczanie wartości wielomianu według schematu Hornera
            for (int i = vsn; i >= 0; i--)
            {//wczytanie i-tego współczynnika wielomianu
                Console.Write("\n\n\tPodaj wartość {0}-go współczynnika wielomianu: ", i);
                while (!float.TryParse(Console.ReadLine(), out vsa))
                {//sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w zapisie wartości {0}-go współczynnika wielomianu wystąpił niedozwolony znak", i);
                    Console.Write("\n\n\tPodaj ponownie wartość {0}-go współczynnika wielomianu: ", i);
                }
                //iteracyjne obliczanie wartości wielomianu według schematu Hornera
                vsWx = vsWx * vsX + vsa;
            }

        }


        #endregion
        #region 


        #endregion
    }
}