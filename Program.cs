using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string nonSpaceinputString = inputString.Replace(" ", string.Empty);

            int number1 = 0;
            int number2 = 0;
            int xoperator = 0;

            int count = 0;


            for (int i = 0; i < nonSpaceinputString.Length; i++)
            {
                if (nonSpaceinputString[i] >= 48 && nonSpaceinputString[i] <= 57)
                {
                    count++;
                }
                else
                {
                    int changeInt = nonSpaceinputString[i];
                    bool checkOper = changeInt == 43
                        || changeInt == 45
                        || changeInt == 42
                        || changeInt == 47;
                    if (checkOper)
                    {
                        switch (changeInt)
                        {
                            case 43:
                                xoperator = 1;
                                break;

                            case 45:
                                xoperator = 2;
                                break;

                            case 42:
                                xoperator = 3;
                                break;

                            case 47:
                                xoperator = 4;
                                break;
                        }
                    }
                    break;
                }
            }

            var savedCount = count;

            for (int i = 0; i < savedCount; i++)
            {
                int num = nonSpaceinputString[i] - 48;
                number1 += num * (int)Math.Pow(10, (double)count - 1);
                count--;
            }

            //

            var lastcount = savedCount + 1;
            count = 0;

            for (int i = lastcount; i < nonSpaceinputString.Length; i++)
            {
                if (nonSpaceinputString[i] >= 48 && nonSpaceinputString[i] <= 57)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            for (int i = lastcount; i < nonSpaceinputString.Length; i++)
            {
                int num = nonSpaceinputString[i] - 48;
                number2 += num * (int)Math.Pow(10, (double)count - 1);
                count--;
            }

            Console.WriteLine(CalculateNumber(number1, number2, xoperator));
        }

        static public int CalculateNumber(int number1, int number2, int mode)
        {
            switch (mode)
            {
                case 1:
                    return number1 + number2;
                case 2:
                    return number1 - number2;
                case 3:
                    return number1 * number2;
                case 4:
                    return number1 / number2;
            }
            return 0;
        }
    }
}
