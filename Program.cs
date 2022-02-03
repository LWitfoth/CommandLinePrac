
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter number one");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter number two");
        int num2 = Int32.Parse(Console.ReadLine());

        int total = num1 + num2;

        if (num1 == num2)
        {
            int newTotalTriple = total * 3;
            total = newTotalTriple;

        }

        System.Console.WriteLine(num1 + ", " + num2 + "total is: " + total);
    }
}

/*  This is what I tried first. Write a C# Sharp program to compute the sum of the two given integer values.
 *  If the two values are the same, then return triple their sum.
public class Exercise1
{
    public static void Main()
    {
        System.Console.WriteLine("Enter number one");
        int num1 = System.Int32.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Enter number two");
        int num2 = System.Int32.Parse(System.Console.ReadLine());

        int total = num1 + num2;

        if (num1 == num2)
        {
            int newTotalTriple = total * 3;
            total = newTotalTriple;

        }

        System.Console.WriteLine(num1 + ", " + num2 + "total is: " + total);
    }
*/
}
