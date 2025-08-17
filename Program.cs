public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {2,5,9,6,7};
        int total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }
        Console.WriteLine(total);
    }
}