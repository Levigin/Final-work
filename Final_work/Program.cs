public class Task
{
    static void Main(string[] args)
    {
        string[] vs = { "hello", "2", "=)" };
        string[] vs2 = { "124325", "-2", "2356632", "computer science" };

        Arr(vs);
        Arr(vs2);

    }
    public static string[] Arr(string[] nums)
    {
        int count = 0;
        string[] array = new string[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].Length <= 3)
            {
                array[count++] = nums[i];
            }
        }
        Console.WriteLine(String.Join(' ', array));
        return array;
    }
}