using System.ComponentModel.DataAnnotations;
string input = "АБВГДЯ";
char[] alphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
char[] inp = input.ToCharArray();
for (int c = 0; c < inp.Length; c++)
{
    if (alphabet.Contains(inp[c]))
    {
            inp[c] = alphabet[^(string.Concat(alphabet).IndexOf(inp[c])+1)];
    }
}
input = string.Concat(inp);
Console.WriteLine(input);
