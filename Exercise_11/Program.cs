// See https://aka.ms/new-console-template for more information

// 1 1 2 3 4 5 6 100

int[] arr;

int size = int.Parse(Console.ReadLine()!);

arr = new int[size];

Console.WriteLine($"Enter {size} number:");

for (int i = 0; i < size; i++)
{
    arr[i] = int.Parse(Console.ReadLine()!);
}
//
// int[] copyArr = { };
// for (int i = 0; i < arr.Length; i++)
// {
//     int cnt = 0;
//     foreach (var t in arr)
//     {
//         if (arr[i] == t)
//         {
//             cnt++;
//         }
//     }
//
//     if (cnt == 1)
//     {
//         copyArr[i] = arr[i];
//     }
// }
//
// foreach (int item in copyArr)
// {
//     Console.WriteLine(item);
// }



//input: 1 1 2 3 4
//index:  0 1 2 3 4
        //0 0 0 0 0
        //0 1 0 0 0
        //0 2 0 0 0
        //0 2 1 0 0
        //0 2 1 1 0
        //0 2 1 1 1

int mx = arr.Max();

int[] newArr = new int[mx + 1];

for (int i = 0; i < arr.Length; i++)
{
    newArr[arr[i]]++;
}

Console.WriteLine("unique elements");
for (int i = 0; i < newArr.Length; i++)
{
    if (newArr[i] == 1)
    {
        Console.Write($"{i} ");
    }
}