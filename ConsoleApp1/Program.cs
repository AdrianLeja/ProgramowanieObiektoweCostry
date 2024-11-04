using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//zad1
//class Delta
//{
//    static void Main()
//    {
//        Console.WriteLine("Podaj współczynniki trójmianu kwadratowego (ax^2 + bx + c):");

//        Console.Write("a: ");
//        double a = Convert.ToDouble(Console.ReadLine());

//        Console.Write("b: ");
//        double b = Convert.ToDouble(Console.ReadLine());

//        Console.Write("c: ");
//        double c = Convert.ToDouble(Console.ReadLine());

//        double delta = (b * b) - (4 * a * c);
//        Console.WriteLine($"Delta = {delta}");

//        if (delta > 0)
//        {
//            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
//            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
//            Console.WriteLine($"Dwa różne pierwiastki rzeczywiste: x1 = {x1}, x2 = {x2}");
//        }
//        else if (delta == 0)
//        {
//            double x = -b / (2 * a);
//            Console.WriteLine($"Jeden pierwiastek rzeczywisty: x = {x}");
//        }
//        else
//        {
//            Console.WriteLine("Brak pierwiastków rzeczywistych.");
//        }
//    }
//}







//zad2

//class Kalkulator
//{
//    static void Main()
//    {
//        bool loop = true;
//        while (loop)
//        {
//            Console.WriteLine("Wybierz operację:");
//            Console.WriteLine("1 - Suma");
//            Console.WriteLine("2 - Różnica");
//            Console.WriteLine("3 - Iloczyn");
//            Console.WriteLine("4 - Iloraz");
//            Console.WriteLine("5 - Potęga");
//            Console.WriteLine("6 - Pierwiastek");
//            Console.WriteLine("7 - Sinus");
//            Console.WriteLine("8 - Cosinus");
//            Console.WriteLine("9 - Tangens");
//            Console.WriteLine("10 - Wyjście");

//            Console.Write("Wybierz opcję: ");
//            int wybor = int.Parse(Console.ReadLine());

//            switch(wybor)
//            {
//                case 1:
//                    Console.WriteLine("Podaj pierwszą liczbe: ");
//                    double suma1 = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Podaj drugą liczbe: ");
//                    double suma2 = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Suma =" + (suma1 + suma2));
//                    break;

//                case 2:
//                    Console.WriteLine("Podaj pierwszą liczbe: ");
//                    double różnica1 = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Podaj drugą liczbe: ");
//                    double różnica2 = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Różnica =" + (różnica1 - różnica2));
//                    break;

//                case 3:
//                    Console.WriteLine("Podaj pierwszą liczbe: ");
//                    double iloczyn1 = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Podaj drugą liczbe:");
//                    double iloczyn2 = int.Parse(Console.ReadLine());
//                    Console.WriteLine("" +
//                        "Iloczyn =" + (iloczyn1 * iloczyn2));
//                    break;

//                case 4:
//                    Console.WriteLine("Podaj pierwszą liczbe: ");
//                    double iloraz1 = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Podaj drugą liczbe: ");
//                    double iloraz2 = int.Parse(Console.ReadLine());
//                    if (iloraz2 != 0)
//                    {
//                        Console.WriteLine("Iloraz: " + (iloraz1 / iloraz2));
//                    }
//                    else
//                    {
//                        Console.WriteLine("Nie dziel= przez zero cholero");
//                    }
//                    break;

//                case 5:
//                    Console.Write("Podaj podstawę: ");
//                    double podstawa = double.Parse(Console.ReadLine());
//                    Console.Write("Podaj wykładnik: ");
//                    double wykladnik = double.Parse(Console.ReadLine());
//                    Console.WriteLine("Wynik potęgowania: " + Math.Pow(podstawa, wykladnik));
//                    break;

//                case 6:
//                    Console.WriteLine("Podaj liczbe");
//                    double liczba = double.Parse(Console.ReadLine());
//                    if (liczba != 0)
//                    {
//                        Console.WriteLine("Pierwiastek = " + Math.Sqrt(liczba));
//                    }
//                    else
//                    {
//                        Console.WriteLine("pierwiastek z liczbby ujemnej nie istnieje ");
//                    }
//                    break;

//                case 7:
//                    Console.Write("Podaj kąt w radianach: ");
//                    double Sin = double.Parse(Console.ReadLine());
//                    Console.WriteLine("Sinus: " + Math.Sin(Sin));
//                    break;

//                case 8:
//                    Console.Write("Podaj kąt w radianach: ");
//                    double Cos = double.Parse(Console.ReadLine());
//                    Console.WriteLine("Cosinus: " + Math.Cos(Cos));
//                    break;

//                case 9:
//                    Console.Write("Podaj kąt w radianach: ");
//                    double Tan = double.Parse(Console.ReadLine());
//                    Console.WriteLine("Tangens: " + Math.Tan(Tan));
//                    break;

//                case 10:
//                    loop = false;
//                    Console.WriteLine("Zamykam program.");
//                    break;

//                default:
//                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
//                    break;

//            }
//        }
//    }
//}





//zad3

//class Liczby
//{
//    static void Main()
//    {
//        int[] array = new int[10];
//        Console.WriteLine("Podaj 10 liczb naturalnych: ");
//        for (int i = 0; i < array.Length; i++)
//        {
//            int a = Convert.ToInt32(Console.ReadLine());
//            array[i] = a;

//        }
//        Console.WriteLine("oto twoje liczby: ");
//        foreach (int i in array)
//        {
//            Console.WriteLine(i);
//        }
//        Console.WriteLine("oto twoje liczby od tyłu: ");

//        for (int i = array.Length - 1; i >= 0; i--)
//        {
//            Console.WriteLine(array[i]);
//        }
//        Console.WriteLine("nieparzyste indeksy");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.WriteLine(array[i]);
//            i++;
//        }
//        Console.WriteLine("parzyste indeksy");
//        for (int i = 1; i < array.Length; i++)
//        {
//            Console.WriteLine(array[i]);
//            i++;
//        }

//    }
//}

//zad4

//class Lista
//{
//    static void Main()
//    {
//        int[] array = new int[10];
//        Console.WriteLine("Podaj 10 liczb naturalnych: ");
//        for (int i = 0; i < array.Length; i++)
//        {
//            int a = Convert.ToInt32(Console.ReadLine());
//            array[i] = a;

//        }
//        int suma = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            suma = suma + array[i];
//        }
//        Console.WriteLine($"twoja suma wynosi: {suma}");
//        int iloczyn = 1;

//        for (int i = 0; i < array.Length; i++)
//        {
//            iloczyn = iloczyn * array[i];
//        }
//        Console.WriteLine($"twój iloczyn wynosi: {iloczyn}");
//        Console.WriteLine("twoja wartosc srenia to: " + (suma/array.Length));
//        int max = array.Max();
//        Console.WriteLine("najwyzsza liczba to :" + max);
//        int min = array.Min();
//        Console.WriteLine("najniższa liczba to :" + min);



//    }

//}

//zad5 


//class Odtylu
//{
//    static void Main()
//    {
//        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
//        for (int i = array.Length - 1; i >= 0; i--)
//        {
//            if (i == 1 || i == 5 || i == 8 || i == 14 || i == 18)
//            {
//                continue;
//            }
//            else
//            {
//                Console.WriteLine(array[i]);
//            }
//        }
//    }
//}


//zad6


//class Infinity
//{
//    static void Main()
//    {
//        int input = 0;
//        bool wiekszemniejsze = true;

//        while(wiekszemniejsze)
//        {
//            Console.WriteLine("Podaj liczbe wieksz od zera jezeli chcesz kontynułowac podawanie liczb lub podaj liczbe ujemna jezeli chcesz zakonczyc: ");
//            input = Convert.ToInt32(Console.ReadLine());

//            if (input >= 0)
//            {
//                wiekszemniejsze = true;
//            }
//            else
//            {
//                break;
//            }

//        }
//    }
//}



//zad7
class BubbleSort
{
    static void Main()
    {
        Console.WriteLine("Podaj ilosc liczb do posortowania ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Podaj liczby naturalne: ");
        for (int x = 0; x < array.Length; x++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            array[x] = a;

        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Posortowana tablica: " + string.Join(" ", array));



    }

}
