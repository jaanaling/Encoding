using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первый ключ");
                int key = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите второй ключ");
                int key1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите сообщение");
                char[] alphabet = new char[35] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', ',', ' ' };
                string str1 = Console.ReadLine();
                str1 = str1.ToUpper();
                char[] str = str1.ToCharArray();
                int l = 0;
                for (int i = 0; i < 35; i++)
                {
                    if (l == str1.Length)
                    {
                        break;
                    }
                    if (alphabet[i] == str[l])
                    {
                        str[l] = alphabet[((i * key) + key1) % 35];
                        l++;
                        i = 0;
                    }
                }
                string s = new string(str);
                Console.WriteLine(s.ToLower());
                l = 0;
                for (int i = 0; i < 35; i++)
                {
                    if (l == str1.Length)
                    {
                        break;
                    }
                    if (alphabet[i] == str[l])
                    {
                        str[l] = alphabet[(Math.Abs(i - key1) * Method(key)) % 35];
                        l++;
                        i = 0;
                    }
                }
                string st = new string(str);
                Console.WriteLine(st.ToLower());
                if (key % 35 == 0 && key < 0)
                {
                    throw new Exception("Ключ введён неверно");
                }
                if (key1 > 34)
                {
                    throw new Exception("Ключ введён неверно");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static public int Method(int key)
        {
            for (int i = 0; i < 100; i++)
            {
                if ((key * i) % 35 == 1)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
