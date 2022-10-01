// See https://aka.ms/new-console-template for more information
//   0 1 2
//0  1 2 3
//1  4 5 6
//2  7 8 9
//3  10 11 12

using TwoDimensionArrays;

var y = 12.5;

int[,] twoArr = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

//print 5
Console.WriteLine(twoArr[1, 1]);

for (int i = 0; i < twoArr.GetLength(0); i++)
{
    for (int j = 0; j < twoArr.GetLength(1); j++)
    {
        Console.Write(twoArr[i, j] + " ");
    }

    Console.WriteLine();
}
//  0 1 2 3 4 5 6 7 8 9 
//0 1 2 3 4 5 6 7 8 9 12
//1 1 2 3 4
//2 8426427
//3 0 12 33 12 

// int[][] jagged = new int[4][];
//
// for (int i = 0; i < jagged.Length; i++)
// {
//     Console.WriteLine($"Enter {i} th array size");
//     int x = int.Parse(Console.ReadLine());
//     jagged[i] = new int [x];
// }
//
// for (int i = 0; i < jagged.Length; i++)
// {
//     for (int j = 0; j < jagged[i].Length; j++)
//     {
//         Console.WriteLine(jagged[i][j]);
//     }
// }
int k = Sum(1, 2);
Console.WriteLine($"Sum is {k}");

int[] arrX = new[] { 1, 2, 3 };
PrintArray(arrX);
int[] arrY = new[] { 1, 2, 3, 4, 56565, 4 };
PrintArray(arrY);

Mathematics m = new Mathematics();

m.IsEven(12);
Console.WriteLine("X is x");
m.Sum(1, 2);
m.Sum(3.2, 1.5);
m.Sum(3.2m, 45.3234m);
m.Test();

#region Methods

int Sum(int a, int b)
{
    int result = a + b;

    return result;
}

void PrintArray(int[] arr)
{
    foreach (var x in arr)
    {
        if (x % 2 == 3)
        {
            
        }
        Console.WriteLine(x);
    }
}

#endregion