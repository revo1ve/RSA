using System;
using System.Collections.Generic;

namespace RSA
{
    static class RSA
    {
        static char[] characters = new char[] { '#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0' };

        public static bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static List<string> RSA_Encode(string s, long e, long n)
        {
            List<string> result = new List<string>();

            ByteNumber byteNumber;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                byteNumber = new ByteNumber(index.ToString());

                var exp = new ByteNumber(index.ToString());

                for (int j = 0; j < (int)e; j++)
                    byteNumber *= exp;

                ByteNumber n_ = new ByteNumber(((int)n).ToString());

                byteNumber %= n_;

                result.Add(byteNumber.ToString());
            }

            return result;
        }

        public static string RSA_Decode(List<string> input, long d, long n)
        {
            string result = "";

            ByteNumber byteNumber;

            foreach (string item in input)
            {
                byteNumber = new ByteNumber(item);

                var exp = new ByteNumber(item);

                for (int i = 0; i < (int)d; i++)
                    byteNumber *= exp;

                ByteNumber n_ = new ByteNumber(((int)n).ToString());

                byteNumber %= n_;

                int index = Convert.ToInt32(byteNumber.ToString());

                result += characters[index].ToString();
            }

            return result;
        }

        public static long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        public static long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }
    }
}
