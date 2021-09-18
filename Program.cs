using System;
using System.Threading;




namespace Studia
{
    class Program
    {

        static void Main(string[] args)
        {
            bool isProgramRun = true;
            string odp;

            while (isProgramRun)
            {

                Console.WriteLine("D lub 1 - Długość boków trójkata");
                Console.WriteLine("K lub 2 - Miejsca zerowe funkcji kwadratowej");
                Console.WriteLine("A lub 3 - Liczby arabskie");

                Console.WriteLine("E lub 4 - Wyjście");

                odp = Console.ReadLine();
                switch (odp.ToLower())
                {
                    case "d":
                    case "1":

                        #region lenght 
                        int lenght1, lenght2, lenght3;

                        Console.WriteLine("Podaj długość pierwszego odcinka: ");
                        try
                        {
                            lenght1 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Błędna wartość pierwszego odcinka");
                            Console.WriteLine();

                            break;
                        }



                        Console.WriteLine("Podaj długość drugiego odcinka: ");

                        try
                        {
                            lenght2 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Błędna wartość drugiego odcinka");
                            Console.WriteLine();
                            break;
                        }

                        Console.WriteLine("Podaj długość trzeciego odcinka: ");
                        try
                        {
                            lenght3 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Błędna wartość trzeciego odcinka");
                            Console.WriteLine();
                            break;
                        }


                        if (lenght1 + lenght2 > lenght3 && lenght1 + lenght3 > lenght2 && lenght3 + lenght2 > lenght1)
                        {
                            Console.Clear();
                            Console.WriteLine("Z podanych odcinków: " + lenght1 + "," + lenght2 + "," + lenght3 + " da się zbudować trójkąt");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("Z podanych odcinków: " + lenght1 + "," + lenght2 + "," + lenght3 + " nie da się zbudować trójkąta");
                            Console.WriteLine();
                        }
                        #endregion
                        break;
                    case "k":
                    case "2":
                
                        #region function
                        int a, b, c, delta;
                
                        Console.WriteLine("Podaj wartość a: ");

                        try
                        {

                            a = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Wprowadziłeś błędną wartość: a");
                            Console.WriteLine();
                            break;


                        }
                 
                        Console.WriteLine("Podaj wartość b: ");
                        try
                        {

                            b = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Wprowadziłeś błędną wartość: b");
                            Console.WriteLine();
                            break;

                        }
                  
                        Console.WriteLine("Podaj wartość c: ");
                        try
                        {

                            c = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Wprowadziłeś błędną wartość: c");
                            Console.WriteLine();
                            break;

                        }

                        delta = ((b * b) - (4 * a * c));

                        if (delta > 0)
                        {
                            Console.Clear();
                            double x1, x2;
                            x1 = (((-b) - Math.Sqrt(delta)) / (2 * a));
                            x2 = (((-b) + Math.Sqrt(delta)) / (2 * a));

                            Console.WriteLine("Miejscami zerowymi funkcji kwadratowej: f(x) = " + a + "x ^ 2 + " + b + "x + " + c + ", są: ");
                            Console.WriteLine("x1 = " + x1 + " x2 = " + x2);
                            Console.WriteLine();

                        }
                        else if (delta == 0)
                        {
                            Console.Clear();
                            double x1;
                            x1 = ((-b) / (2 * a));


                            Console.WriteLine("Miejscem zerowym funkcji kwadratowej: f(x) = " + a + "x ^ 2 + " + b + "x + " + c + ", jest: ");
                            Console.WriteLine("x0 = " + x1);
                            Console.WriteLine();
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine("Brak miejsc zerowych");
                            Console.WriteLine();
                        }
                        #endregion
                        break;
                    case "a":
                    case "3":

                        int numArab;

                    
                        try
                        {


                            Console.WriteLine("Wprowadź wartość od 1 do 1 000 000: ");
                            numArab = Convert.ToInt32(Console.ReadLine());
                            if (numArab <= 0 || numArab > 1000000)
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Wprowadzona wartość wykraca poza skalę!");
                                Console.WriteLine();
                                break;
                            }

                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Wprowadziłeś błędna wartość");
                            Console.WriteLine();
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine(numArab);
                        Console.WriteLine();

                        if (numArab == 1000000) Console.WriteLine("Milion");
                        else
                        {


                            switch (Math.Round((decimal)numArab / 100000, MidpointRounding.ToZero))
                            {

                                case 1:
                                    Console.Write("Sto ");
                                    numArab -= 100000;
                                    break;
                                case 2:
                                    Console.Write("Dwieście ");
                                    numArab -= 200000;
                                    break;
                                case 3:
                                    Console.Write("Trzysta ");
                                    numArab -= 300000;
                                    break;
                                case 4:
                                    Console.Write("Czterysta ");
                                    numArab -= 400000;
                                    break;
                                case 5:
                                    Console.Write("Pięćset ");
                                    numArab -= 500000;
                                    break;
                                case 6:
                                    Console.Write("Sześćset ");
                                    numArab -= 600000;
                                    break;
                                case 7:
                                    Console.Write("Siedemset ");
                                    numArab -= 700000;
                                    break;
                                case 8:
                                    Console.Write("Osiemset ");
                                    numArab -= 800000;
                                    break;
                                case 9:
                                    Console.Write("Dziewięćset ");
                                    numArab -= 900000;
                                    break;
                            }

                            switch (Math.Round((decimal)numArab / 10000, MidpointRounding.ToZero))
                            {


                                case 1:
                                    numArab -= 10000;
                                    switch (Math.Round((decimal)numArab / 1000, MidpointRounding.ToZero))
                                    {
                                        case 0:
                                            Console.Write("Dziesięć tysięcy ");

                                            break;
                                        case 1:
                                            Console.Write("Jednaście tysięcy ");
                                            numArab -= 1000;
                                            break;
                                        case 2:
                                            Console.Write("Dwanaście tysięcy ");
                                            numArab -= 2000;
                                            break;
                                        case 3:
                                            Console.Write("Trzynaście tysięcy ");
                                            numArab -= 3000;
                                            break;
                                        case 4:
                                            Console.Write("Czternaście tysięcy ");
                                            numArab -= 4000;
                                            break;
                                        case 5:
                                            Console.Write("Pietnaście tysięcy ");
                                            numArab -= 5000;
                                            break;
                                        case 6:
                                            Console.Write("Szesnaście tysięcy ");
                                            numArab -= 6000;
                                            break;
                                        case 7:
                                            Console.Write("Siedemnaście tysięcy ");
                                            numArab -= 7000;
                                            break;
                                        case 8:
                                            Console.Write("Ośiemnaście tysięcy ");
                                            numArab -= 8000;
                                            break;
                                        case 9:
                                            Console.Write("Dziewiętnaście tysięcy ");
                                            numArab -= 9000;
                                            break;
                                    }

                                    break;
                                case 2:
                                    Console.Write("Dwadzieścia ");
                                    numArab -= 20000;
                                    break;
                                case 3:
                                    Console.Write("Trzydzieści ");
                                    numArab -= 30000;
                                    break;
                                case 4:
                                    Console.Write("Czterdzieści ");
                                    numArab -= 40000;
                                    break;
                                case 5:
                                    Console.Write("Pięćdziesiąt ");
                                    numArab -= 50000;
                                    break;
                                case 6:
                                    Console.Write("Sześćdziesiąt ");
                                    numArab -= 60000;
                                    break;
                                case 7:
                                    Console.Write("Siedemdziesiąt ");
                                    numArab -= 70000;
                                    break;
                                case 8:
                                    Console.Write("Osiemdziesiąt ");
                                    numArab -= 80000;
                                    break;
                                case 9:
                                    Console.Write("Dziewięćdziesiąt ");
                                    numArab -= 90000;
                                    break;
                            }

                            if (numArab > 1000)
                            {


                                switch (Math.Round((decimal)numArab / 1000, MidpointRounding.ToZero))
                                {
                                    case 1:

                                        Console.Write("Tysiąc ");
                                        numArab -= 1000;
                                        break;
                                    case 2:
                                        Console.Write("Dwa tysiące ");
                                        numArab -= 2000;
                                        break;
                                    case 3:
                                        Console.Write("Trzy tysiące ");
                                        numArab -= 3000;
                                        break;
                                    case 4:
                                        Console.Write("Cztery tysiące ");
                                        numArab -= 4000;
                                        break;
                                    case 5:
                                        Console.Write("Pięć tysięcy ");
                                        numArab -= 5000;
                                        break;
                                    case 6:
                                        Console.Write("Sześć tysięcy ");
                                        numArab -= 6000;
                                        break;
                                    case 7:
                                        Console.Write("Siedem tysięcy ");
                                        numArab -= 7000;
                                        break;
                                    case 8:
                                        Console.Write("Osiem tysięcy ");
                                        numArab -= 8000;
                                        break;
                                    case 9:
                                        Console.Write("Dziewięć tyśiećy ");
                                        numArab -= 9000;
                                        break;

                                }
                            }


                            switch (Math.Round((decimal)numArab / 100, MidpointRounding.ToZero))
                            {

                                case 1:
                                    Console.Write("Sto ");
                                    numArab -= 100;
                                    break;
                                case 2:
                                    Console.Write("Dwieście ");
                                    numArab -= 200;
                                    break;
                                case 3:
                                    Console.Write("Trzysta ");
                                    numArab -= 300;
                                    break;
                                case 4:
                                    Console.Write("Czterysta ");
                                    numArab -= 400;
                                    break;
                                case 5:
                                    Console.Write("Pięćset ");
                                    numArab -= 500;
                                    break;
                                case 6:
                                    Console.Write("Sześćset ");
                                    numArab -= 600;
                                    break;
                                case 7:
                                    Console.Write("Siedemset ");
                                    numArab -= 700;
                                    break;
                                case 8:
                                    Console.Write("Osiemset ");
                                    numArab -= 800;
                                    break;
                                case 9:
                                    Console.Write("Dziewięćset ");
                                    numArab -= 900;
                                    break;

                            }

                            switch (Math.Round((decimal)numArab / 10, MidpointRounding.ToZero))
                            {

                                case 1:
                                    numArab -= 10;
                                    switch (numArab)
                                    {
                                        case 0:
                                            Console.Write("Dziesięć ");
                                            numArab = 0;
                                            break;
                                        case 1:
                                            Console.Write("Jednaście ");
                                            numArab = 0;
                                            break;
                                        case 2:
                                            Console.Write("Dwanaście ");
                                            numArab = 0;
                                            break;
                                        case 3:
                                            Console.Write("Trzynaście ");
                                            numArab = 0;
                                            break;
                                        case 4:
                                            Console.Write("Czternaście ");
                                            numArab = 0;
                                            break;
                                        case 5:
                                            Console.Write("Pietnaście ");
                                            numArab = 0;
                                            break;
                                        case 6:
                                            Console.Write("Szesnaście ");
                                            numArab = 0;
                                            break;
                                        case 7:
                                            Console.Write("Siedemnaście ");
                                            numArab = 0;
                                            break;
                                        case 8:
                                            Console.Write("Ośiemnaście ");
                                            numArab = 0;
                                            break;
                                        case 9:
                                            Console.Write("Dziewiętnaście ");
                                            numArab = 0;
                                            break;
                                    }

                                    break;
                                case 2:
                                    Console.Write("Dwadzieścia ");
                                    numArab -= 20;
                                    break;
                                case 3:
                                    Console.Write("Trzydzieści ");
                                    numArab -= 30;
                                    break;
                                case 4:
                                    Console.Write("Czterdzieści ");
                                    numArab -= 40;
                                    break;
                                case 5:
                                    Console.Write("Pięćdziesiąt ");
                                    numArab -= 50;
                                    break;
                                case 6:
                                    Console.Write("Sześćdziesiąt ");
                                    numArab -= 60;
                                    break;
                                case 7:
                                    Console.Write("Siedemdziesiąt ");
                                    numArab -= 70;
                                    break;
                                case 8:
                                    Console.Write("Osiemdziesiąt ");
                                    numArab -= 80;
                                    break;
                                case 9:
                                    Console.Write("Dziewięćdziesiąt ");
                                    numArab -= 90;
                                    break;
                            }
                            if (numArab != 0)
                            {
                                switch (numArab)
                                {

                                    case 1:
                                        Console.Write("Jeden");

                                        break;
                                    case 2:
                                        Console.Write("Dwa");

                                        break;
                                    case 3:
                                        Console.Write("Trzy");

                                        break;
                                    case 4:
                                        Console.Write("Cztery");

                                        break;
                                    case 5:
                                        Console.Write("Pieć");

                                        break;
                                    case 6:
                                        Console.Write("Sześć");

                                        break;
                                    case 7:
                                        Console.Write("Siedem");

                                        break;
                                    case 8:
                                        Console.Write("Ośiem");

                                        break;
                                    case 9:
                                        Console.Write("Dziewięć");

                                        break;
                                }
                            }
                            numArab = 0;

                        }
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case "e":
                    case "4":
                        isProgramRun = false;
                        break;

                }




            }

        }
    }
}
