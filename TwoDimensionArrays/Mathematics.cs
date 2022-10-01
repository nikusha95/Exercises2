namespace TwoDimensionArrays;

public class Mathematics
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public bool IsEven(int x)
    {
        if (x % 2 == 1)
        {
            return true;
        }

        return false;
    }

    public double Sum(double a, double b)
    {
        return a + b;
    }

    public void Test()
    {
        Console.WriteLine("hello");
    }

    public decimal Sum(decimal a, decimal b)
    {
        return a + b;
    }
}