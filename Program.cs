class MoveZeros
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите числа, разделенные запятыми:");
        string input = Console.ReadLine();
        int[] nums = Array.ConvertAll(input.Split(','), int.Parse);
        MoveZeroes(nums);
        Console.WriteLine(string.Join(", ", nums));
    }

    public static void MoveZeroes(int[] nums)
    {
        int lastNonZeroIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[lastNonZeroIndex] = nums[i];
                lastNonZeroIndex++;
            }
        }

        for (int i = lastNonZeroIndex; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}