namespace Task5;

public class Program
{
    public static double GetAverage(int[] marks)
    {
        int sum = 0;
        foreach (var m in marks) sum += m;
        return (double)sum / marks.Length;
    }

    public static int GetMin(int[] marks)
    {
        int min = marks[0];
        foreach (var m in marks) if (m < min) min = m;
        return min;
    }

    public static int GetMax(int[] marks)
    {
        int max = marks[0];
        foreach (var m in marks) if (m > max) max = m;
        return max;
    }

    public static void PrintGroupStatistics(int[][] groups)
    {
        for (int i = 0; i < groups.Length; i++)
        {
            Console.WriteLine($"Група {i + 1}: " +
                $"Середній = {GetAverage(groups[i]):F2}, " +
                $"Мінімум = {GetMin(groups[i])}, " +
                $"Максимум = {GetMax(groups[i])}");
        }
    }

    public static void Main(string[] args)
    {
        int[][] groups = new int[][]
        {
            new int[] { 90, 75, 88, 100, 67 },
            new int[] { 55, 60, 70, 80, 95, 100 },
            new int[] { 100, 100, 98, 97, 95 }
        };

        PrintGroupStatistics(groups);
    }
}
