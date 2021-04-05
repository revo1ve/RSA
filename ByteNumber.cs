using System;
using System.Collections.Generic;

namespace RSA
{
    class ByteNumber
    {
        public List<byte> Bytes = new List<byte>();
        public Sign Sign = Sign.Positive;

        public ByteNumber(string number)
        {
            if (number[0] == '-')
                Sign = Sign.Negative;

            var startIndex = Sign == Sign.Negative ? 1 : 0;

            for (int i = startIndex; i < number.Length; i++)
                Bytes.Add((byte)(number[i] - '0'));
        }

        public ByteNumber(List<byte> number, Sign sign)
        {
            Bytes = number;
            Sign = sign;
        }

        public override string ToString()
        {
            var result = Sign == Sign.Positive ? "" : "-";
            foreach (var digit in Bytes)
                result += digit;
            return result;
        }

        public static bool operator ==(ByteNumber a, ByteNumber b)
        {
            if (a.Sign != b.Sign || a.Bytes.Count != b.Bytes.Count)
                return false;

            for (int i = 0; i < a.Bytes.Count; i++)
                if (a.Bytes[i] != b.Bytes[i])
                    return false;

            return true;
        }

        public static bool operator !=(ByteNumber a, ByteNumber b) => !(a == b);

        public static bool operator >(ByteNumber a, ByteNumber b)
        {
            if (a.Sign != b.Sign)
                return a.Sign == Sign.Positive;

            if (a.Bytes.Count != b.Bytes.Count)
                if (a.Sign == Sign.Positive)
                    return a.Bytes.Count > b.Bytes.Count;
                else
                    return a.Bytes.Count < b.Bytes.Count;

            for (int i = 0; i < a.Bytes.Count; i++)
                if (a.Bytes[i] != b.Bytes[i])
                    if (a.Sign == Sign.Positive)
                        return a.Bytes[i] > b.Bytes[i];
                    else
                        return a.Bytes[i] < b.Bytes[i];

            return false;
        }

        public static bool operator >=(ByteNumber a, ByteNumber b) => a == b || a > b;

        public static bool operator <=(ByteNumber a, ByteNumber b) => a == b || a < b;

        public static bool operator <(ByteNumber a, ByteNumber b) => a != b && !(a > b);

        public static ByteNumber operator +(ByteNumber a, ByteNumber b)
        {
            if (a.Bytes.Count > 0 && a.Bytes.TrueForAll(x => x == 0))
                a.Bytes = new List<byte>() { 0 };

            if (b.Bytes.Count > 0 && b.Bytes.TrueForAll(x => x == 0))
                b.Bytes = new List<byte>() { 0 };

            ByteNumber longNumber = a;
            ByteNumber shortNumber = b;

            if (a.Bytes.Count < b.Bytes.Count)
            {
                shortNumber = a;
                longNumber = b;
            }

            var result = new List<byte>(longNumber.Bytes);
            Sign resultSign;
            var lengthDif = longNumber.Bytes.Count - shortNumber.Bytes.Count;

            if (a.Sign == b.Sign)
            {
                for (int i = result.Count - 1; i >= lengthDif; i--)
                {
                    result[i] += shortNumber.Bytes[i - lengthDif];

                    if (result[i] > 9)
                    {
                        result[i] -= 10;

                        for (int j = i; j > 0; j--)
                        {
                            if (result[j - 1] == 9)
                                result[j - 1] = 0;
                            else
                            {
                                result[j - 1]++;
                                break;
                            }
                        }

                        if (result[0] == 0 || i == 0)
                        {
                            result.Insert(0, 1);
                            lengthDif++;
                            i++;
                        }
                    }
                }

                if (result.Count > 1 && result[0] == 0)
                    result.Insert(0, 1);

                resultSign = a.Sign;
            }
            else
            {
                for (int i = result.Count - 1; i >= lengthDif; i--)
                {
                    if (i == 0 && result[i] == 0)
                        break;

                    if (result[i] < shortNumber.Bytes[i - lengthDif])
                    {
                        result[i] += 10;

                        for (int j = i; j > 0; j--)
                        {
                            if (result[j - 1] == 0)
                                result[j - 1] = 9;
                            else
                            {
                                result[j - 1]--;
                                break;
                            }
                        }
                    }

                    result[i] -= shortNumber.Bytes[i - lengthDif];
                }

                while (result.Count > 1 && result[0] == 0)
                    result.RemoveAt(0);

                if (result[0] == 0)
                    resultSign = Sign.Positive;
                else
                    resultSign = new ByteNumber(a.Bytes, Sign.Positive) > new ByteNumber(b.Bytes, Sign.Positive) ?
                        a.Sign : b.Sign;
            }

            return new ByteNumber(result, resultSign);
        }

        public static ByteNumber operator -(ByteNumber a, ByteNumber b)
            => a + new ByteNumber(b.Bytes, (Sign)Enum.Parse(typeof(Sign), ((int)b.Sign * -1).ToString()));

        public static ByteNumber operator *(ByteNumber a, ByteNumber b)
        {
            var result = new ByteNumber("0");

            var upperNumber = new List<byte>(a.Bytes);
            var lowerNumber = new List<byte>(b.Bytes);

            upperNumber.Reverse();
            lowerNumber.Reverse();

            var products = new List<ByteNumber>();
            int remainder;

            foreach (var lowerDigit in lowerNumber)
            {
                var product = new List<byte>();
                remainder = 0;

                foreach (var upperDigit in upperNumber)
                {
                    var digitsProduct = upperDigit * lowerDigit + remainder;

                    if (digitsProduct.ToString().Length == 2)
                    {
                        remainder = digitsProduct / 10;
                        digitsProduct %= 10;
                    }
                    else
                        remainder = 0;

                    product.Insert(0, (byte)digitsProduct);
                }

                if (remainder > 0)
                    product.Insert(0, (byte)remainder);

                for (int i = 0; i < products.Count; i++)
                    product.Add(0);

                products.Add(new ByteNumber(product, Sign.Positive));
            }

            foreach (var product in products)
                result += product;

            if (a.Sign != b.Sign)
                result.Sign = Sign.Negative;

            return result;
        }

        public static ByteNumber operator /(ByteNumber dividend, ByteNumber divisor)
        {
            if (divisor.Bytes[0] == 0)
                throw new Exception("На ноль делить нельзя");

            var i = 0;
            var resultNumb = new List<byte>();
            var incompleteDivisible = new ByteNumber(new List<byte>(0), Sign.Positive);
            var divisorModule = new ByteNumber(divisor.Bytes, Sign.Positive);

            while (i != dividend.Bytes.Count)
            {
                for (; i < dividend.Bytes.Count; i++)
                {
                    if (incompleteDivisible >= divisorModule)
                        break;

                    incompleteDivisible.Bytes.Add(dividend.Bytes[i]);
                }

                if (incompleteDivisible.Bytes.TrueForAll(x => x == 0))
                {
                    for (int j = 0; j < incompleteDivisible.Bytes.Count - 1; j++)
                        resultNumb.Add(0);
                    break;
                }

                for (int j = 0; j < 10; j++)
                {
                    if (incompleteDivisible < divisorModule)
                    {
                        resultNumb.Add((byte)j);
                        break;
                    }

                    incompleteDivisible -= divisorModule;
                }
            }

            var resultSign = dividend.Sign == divisor.Sign ? Sign.Positive : Sign.Negative;
            return new ByteNumber(resultNumb, resultSign);
        }

        public static ByteNumber operator %(ByteNumber a, ByteNumber b)
        {
            if (b.Bytes[0] == 0)
                throw new Exception("На ноль делить нельзя");

            var i = 0;
            var incompleteDivisible = new ByteNumber(new List<byte>(0), Sign.Positive);

            while (i != a.Bytes.Count)
            {
                for (; i < a.Bytes.Count; i++)
                {
                    if (incompleteDivisible > b)
                        break;

                    incompleteDivisible.Bytes.Add(a.Bytes[i]);
                }

                if (incompleteDivisible.Bytes.TrueForAll(x => x == 0))
                {
                    incompleteDivisible = new ByteNumber("0");
                    break;
                }

                while (incompleteDivisible >= b)
                    incompleteDivisible -= b;
            }

            return incompleteDivisible;
        }
    } 

    enum Sign
    {
        Positive = 1,
        Negative = -1
    }
}
