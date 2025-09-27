using System;
using System.Collections;

namespace MultiPurposeDLL
{
    public class HappyNumberChecker
    {
        public int Number { get; set; }

        public string Check()
        {
            if (Number <= 0) return "No"; // Dấu ấn: Không xử lý số âm hoặc 0 để giữ độc lạ

            Hashtable seen = new Hashtable(); // Sử dụng Hashtable vì .NET 2.0 không có HashSet
            int num = Number;

            while (num != 1 && !seen.Contains(num))
            {
                seen.Add(num, null);
                num = SumOfSquares(num);
            }

            if (num == 1)
            {
                return "Yes, lan's favorite happy number!"; // Dấu ấn cá nhân
            }
            else
            {
                return "No";
            }
        }

        private int SumOfSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return sum;
        }
    }
}