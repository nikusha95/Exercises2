//print number x

using System.Threading.Channels;

// int x = 10;
// Console.WriteLine(x);
//
//
// string s = Console.ReadLine();
// int x1 = 0;

//x1 = Convert.ToInt32(s);
// bool isInt = int.TryParse(s, out x1);
//
// if (!isInt)
// {
//     Console.WriteLine("Enter correct number");
// }
// else
// {
//     Console.WriteLine($"isInteger {isInt} x1={x1}");
// }

//დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიტანს 10 ელემენტს და შეავსებს მასივს.
//(სცადეთ სხვადასხვა ტიპისთვის)
//
// for (int i = 1; i <= 10; i += 2)
// {
//     Console.WriteLine("Hello");
// }
//
// //break; continue;
// int j = 10;
// int del = 5;
// while (j > 0)
// {
//     if (j == del)
//     {
//         break;
//     }
//
//     Console.WriteLine(j);
//     j--;
// }
//
// int k = 0;
// while (k < 10)
// {
//     if (k % 2 == 1)
//     {
//         k++;
//         continue;
//     }
//
//     Console.WriteLine(k);
//     k++;
// }
//
// //n^2  n*m
// for (int i = 1; i <= 10; i++)
// {
//     for (j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j}={i * j}");
//     }
//
//     Console.WriteLine();
// }//
// for (int i = 1; i <= 10; i += 2)
// {
//     Console.WriteLine("Hello");
// }
//
// //break; continue;
// int j = 10;
// int del = 5;
// while (j > 0)
// {
//     if (j == del)
//     {
//         break;
//     }
//
//     Console.WriteLine(j);
//     j--;
// }
//
// int k = 0;
// while (k < 10)
// {
//     if (k % 2 == 1)
//     {
//         k++;
//         continue;
//     }
//
//     Console.WriteLine(k);
//     k++;
// }
//
// //n^2  n*m
// for (int i = 1; i <= 10; i++)
// {
//     for (j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j}={i * j}");
//     }
//
//     Console.WriteLine();
// }

int[] arr = { 1, 2, 3, 4 };

int size = int.Parse(Console.ReadLine());
int[] arr1 = new int[size];

for (int ai = 0; ai < arr.Length; ai++)
{
    Console.WriteLine(arr[ai]);
}

for (int ai = 0; ai < arr1.Length; ai++)
{
    Console.WriteLine(arr1[ai]);
}


for (int aj = 0; aj < arr1.Length; aj++)
{
    arr1[aj] = int.Parse(Console.ReadLine() ?? string.Empty);
}

for (int aj = 0; aj < arr1.Length; aj++)
{
    Console.WriteLine(arr1[aj]);
}