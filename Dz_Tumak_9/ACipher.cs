using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Tumak_9
{
    public class ACipher : ICipher
    {
        internal char[] alphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        public string decode(string input)
        {
            char[] inp = input.ToUpper().ToCharArray();
            for (int c = 0; c < inp.Length; c++)
            {
                if (alphabet.Contains(inp[c]))
                {
                    try
                    {
                        inp[c] = alphabet[string.Concat(alphabet).IndexOf(inp[c]) - 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        inp[c] = alphabet[32];
                    }
                }
            }
            input = string.Concat(inp);
            return input;
        }
        public string encode(string input)
        {
            char[] inp = input.ToUpper().ToCharArray();
            for (int c = 0; c < inp.Length; c++)
            {
                if (alphabet.Contains(inp[c]))
                {
                    try
                    {
                        inp[c] = alphabet[string.Concat(alphabet).IndexOf(inp[c]) + 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        inp[c] = alphabet[0];
                    }
                }
            }
            input = string.Concat(inp);
            return input;
        }
    }
}
