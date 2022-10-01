// See https://aka.ms/new-console-template for more information
//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოსულ
//რიცხვს შეამოწმებს არის თუ არა პალინდრომი
//(არ გამოიყენოთ სტრინგები)

using System.Threading.Channels;

string s = Console.ReadLine();
int x = int.Parse(s);
int n = x, digitAmount = 0;

//123
//321

//12
//1
//0
while (n != 0)
{
    digitAmount++;
    n /= 10;
}

n = x;
int newNumber = 0;
//3
Console.WriteLine(digitAmount);

//100 10 1
//1000 100 10 1
while (digitAmount != 0)
{
    newNumber += n % 10 * (int)Math.Pow(10, digitAmount - 1);
    n /= 10;
    digitAmount--;
}

Console.WriteLine(newNumber);

if (newNumber!=x)
{
    Console.WriteLine("Is not palindrome");
}
else
{
    Console.WriteLine("Is palindrome");
}
