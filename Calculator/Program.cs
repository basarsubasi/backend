using System;

public class Calculator
{
    public double Topla(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Cikar(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Carp(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Bol(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Hata: Sifira bolme hatasi.");
            return double.NaN;
        }

        return num1 / num2;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        bool exitRequested = false;

        while (!exitRequested)
        { 
            Console.WriteLine("Birinci sayiyi girin:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi girin:");
            double num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Bir islem secin:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Cikarma");
            Console.WriteLine("3. Carpma");
            Console.WriteLine("4. Bolme");
            Console.WriteLine("5. Cikis");

            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = calculator.Topla(num1, num2);
                    break;
                case 2:
                    result = calculator.Cikar(num1, num2);
                    break;
                case 3:
                    result = calculator.Carp(num1, num2);
                    break;
                case 4:
                    result = calculator.Bol(num1, num2);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Bolme islemi gecersiz.");
                        continue;
                    }
                    break;
                case 5:
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Lutfen gecerli bir islem secin.");
                    break;
            }

            if (!exitRequested)
            {
                Console.WriteLine("Sonuc: " + result);
                Console.WriteLine(" Alt satira 5 girerek cikis yapabilir veya 5 disinda herhangi bir rakam girerek yeni bir islem yapabilirsiniz. ");
                int continueChoice = Convert.ToInt32(Console.ReadLine());
                if (continueChoice != 5)
                {
                    Console.Clear();
                }
                else
                {
                    exitRequested = true;
                }
            }
        }
    }
}
