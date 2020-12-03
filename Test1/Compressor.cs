using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test1
{
    class Compressor 
    {
        /*
		 * метод, осуществляющий сжатие строки на основе счётчика повторяющихся символов. 
		 * Например, строка aabcccccaaa должна превратиться в a2b1c5a3. Если «сжатая» строка оказывается длиннее исходной, метод должен вернуть исходную строку.
		 * */

        public static string CompressionString(string originalString)
        {
            string resultString = ""; //результирующая строка
            int countChar = 1; //кол-во вхождений одинаковых символов в слове
            for (int i = 0; i < originalString.Length; i++)
            {
                if (i == originalString.Length - 1 || originalString[i] != originalString[i + 1])
                {
                    resultString += originalString[i].ToString() + countChar;
                    countChar = 1;
                }
                else
                    countChar++;
            }
            return resultString.Length < originalString.Length ? resultString : originalString; //если длинна результирующей строки больше исхоной, вернуть исходную строку
        }
    }
}
