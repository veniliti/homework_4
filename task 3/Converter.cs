using System;

class Converter
{
    public decimal DollarRate { get; set; }
    public decimal EuroRate { get; set; }

    public Converter(decimal dollarRate, decimal euroRate)
    {
        DollarRate = dollarRate;
        EuroRate = euroRate;
    }

    public decimal DollarConvert(decimal amount, bool toUAH)
    {
        return toUAH ? amount * DollarRate : amount / DollarRate;
    }

    public decimal EuroConvert(decimal amount, bool toUAH)
    {
        return toUAH ? amount * EuroRate : amount / EuroRate;
    }
}

class Program
{
    static void Main()
    {
        Converter converter = new Converter(46.65m, 51.18m);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Choose currency for conversion: 1 - Dollar, 2 - Euro, 0 - Exit");
            string currencyChoice = Console.ReadLine() ?? "";
            if (currencyChoice == "0")
            {
                break;
            }
            if (currencyChoice != "1" && currencyChoice != "2")
            {
                Console.WriteLine("Please choose valid options and try again.");
                continue;
            }

            Console.WriteLine();
            Console.WriteLine("Choose conversion direction: 1 - to UAH, 2 - from UAH");
            string directionChoice = Console.ReadLine() ?? "";
            if (directionChoice != "1" && directionChoice != "2")
            {
                Console.WriteLine("Please choose valid options and try again.");
                continue;
            }
            bool toUAH = directionChoice == "1";

            Console.WriteLine();
            Console.Write("Amount: ");
            decimal amount;
            if (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                continue;
            }

            decimal result;
            if (currencyChoice == "1")
            {
                result = converter.DollarConvert(amount, toUAH);
            }
            else
            {
                result = converter.EuroConvert(amount, toUAH);
            }

            Console.WriteLine();
            Console.WriteLine("Converted amount: " + result);
        }
    }
}