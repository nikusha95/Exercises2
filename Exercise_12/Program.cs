// See https://aka.ms/new-console-template for more information

int[] arr = { 1, 1, 2, 3, 4, 4 };
for (int i = 0; i < arr.Length; i++)
{
    int a = 0;
    while (a < arr.Length)
    {
        if (a != i || i == arr.Length - 1)
        {
            if (arr[i] == arr[a] && i != arr.Length - 1)
            {
                break;
            }

            if (a == arr.Length - 1)
            {
                Console.WriteLine("write " + arr[i]);
            }
        }

        a++;
    }
}


//x---> 6 x--->2 x---->13 x--->4 5 6
foreach (int x in arr)
{
    Console.WriteLine(x);
}
