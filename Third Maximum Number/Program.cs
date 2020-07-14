using System;

namespace Third_Maximum_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2 };
            Console.WriteLine(ThirdMax(arr));
            Console.WriteLine("Hello World!");
        }

        public static int ThirdMax(int[] nums)
        {
            // 1 , 11, -4, 0, 1, 5
            int length = nums.Length;
            int max = nums[0];
            int secondMax = int.MinValue;
            int thirdMax = int.MinValue;

            for (int i = 0; i < length; i++)
            {
                int num = nums[i];
                if(num > max)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = num;
                } else if(num > secondMax && num < max)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                } else if(num > thirdMax && num < secondMax)
                {
                    thirdMax = num;
                }
            }

            return length > 2 ? thirdMax : max;
        }
    }
}
