using System;

namespace ClassLibrary
{
    public class ArrayWorker
    {
        public int[] InvertArray(int[] nums)
        {
            int[] invNums = new int[nums.Length];
            for (int i = 0; i < invNums.Length; i++)
            {
                invNums[i] = nums[nums.Length-1-i];
            }
            return invNums;
        }
        public void ShowArray(string text, int[] nums)
        {
            Console.Write(text);
            for (int i = 0; i < nums.Length-1; i++)
            {
                Console.Write($"{nums[i]}, ");
            }
            Console.Write($"{nums[nums.Length-1]}.");
        }

        public int[] AddValue(int[] nums, int value, int index)
        {
            if (index <= nums.Length)
            {
                int[] upd_nums = new int[nums.Length + 1];
                for (int i = 0; i < index; i++)
                {
                    upd_nums[i] = nums[i];
                }
                upd_nums[index] = value;
                for (int i = index + 1; i <= nums.Length; i++)
                {
                    upd_nums[i] = nums[i - 1];
                }
                return upd_nums;                
            }
            //Если в массив вставляется число с индексом большим чем +1 к длине массива, то промежуток заполняется нулями.
            else
            {                
                int[] upd_nums = new int[index];
                for (int i = 0; i < nums.Length; i++)
                {
                    upd_nums[i] = nums[i];
                }
                //for (int i = nums.Length; i < upd_nums.Length; i++)
                //{
                //    upd_nums[i] = 0;
                //}
                upd_nums[index-1] = value;
                return upd_nums;
            }       
                        
        }
    }

    public class Cone
    {
        public int Radius;
        public int Height;
        public Cone(int r,int h)
        {
            Radius = r;
            Height = h;
        }
        public double BaseSquare()
        {
            return Math.Round((Math.PI * Math.Pow(Radius, 2)),3);
        }
        public double AllSquare()
        {
            return Math.Round((Math.PI * Radius * Height), 3);
        }
    }
}
