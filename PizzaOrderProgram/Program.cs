// See https://aka.ms/new-console-template for more information


using System.Transactions;

Console.ForegroundColor = ConsoleColor.DarkRed;

double totalCost = 0.00;
string crustChoice;
string size;
int intSize;
string cheeseChoice;
string type;
string voucher;
Random receiptNum;
int num;

receiptNum = new Random();

num = receiptNum.Next(1000);

Console.WriteLine("Welcome to SmashedFrenzy16's Pizza Store!");

Console.Write("Enter in the crust you would like (t for thin, h for thick): ");

crustChoice = Console.ReadLine();

if (crustChoice == "t" ||  crustChoice == "T")
{
    totalCost = totalCost + 8.00;
} else if (crustChoice == "h" || crustChoice == "H")
{
    totalCost = totalCost + 10.00;
}

Console.Write("Enter in the size you would like (in inches) (8, 10, 12, 14, 18): ");

size = Console.ReadLine();

intSize = (int)Convert.ToInt64(size);

if (intSize == 8 || intSize == 10)
{
    totalCost = totalCost + 0.00;
} else if (intSize == 12 || intSize == 14 || intSize == 18)
{
    totalCost = totalCost + 2.00;
}

Console.Write("Do you want cheese? (y/n): ");

cheeseChoice = Console.ReadLine();

if (cheeseChoice == "Y" || cheeseChoice == "y")
{
    totalCost = totalCost + 0.00;
} else if (cheeseChoice == "N" || cheeseChoice == "n")
{
    totalCost = totalCost - 0.50;
}

Console.Write("What type of pizza do you want? \nMargarita - m \nVegetable - v \nVegan - e \nHawaiian - h \nMeat Feast - a\n: ");

type = Console.ReadLine();

if (type == "m" || type == "M")
{
    totalCost = totalCost + 0.00;
} else if (type == "v" || type == "V" || type == "e" || type == "E")
{
    totalCost = totalCost + 1.00;
} else if (type == "h" || type == "H" || type == "a" || type == "A")
{
    totalCost = totalCost + 2.00;
}

Console.Write("Enter in a valid promo code to get £2.00 off: ");

voucher = Console.ReadLine();

if (voucher == "FrenzyFridays16")
{
    totalCost = totalCost - 2.00;
}

Console.WriteLine("Here is your receipt:");
Console.WriteLine("The receipt is written using your input letters/numbers. To find out what they mean, look at their references in your order.");
Console.WriteLine($"Crust: {crustChoice}");
Console.WriteLine($"Size: {intSize}");
Console.WriteLine($"Cheese? {cheeseChoice}");
Console.WriteLine($"Pizza type: {type}");

if (voucher == "FrenzyFridays16")
{
    Console.WriteLine($"Promo Code: {voucher}");
} else if (voucher == "" || voucher == " ")
{
    Console.WriteLine("Voucher: ");
} else
{
    Console.WriteLine("Voucher: Not valid");
}

Console.WriteLine($"Price: £{totalCost}");

Console.WriteLine($"Receipt number: {num}");

Console.WriteLine("Thank you for ordering with us!");