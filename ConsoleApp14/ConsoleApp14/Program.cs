using System;
using System.Collections.Generic;
using System.Text;

namespace polibii
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] alfrus = {     {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё'},
                                   {'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М'},
                                   {'Н', 'О', 'П', 'Р', 'С', 'Т', 'У'},
                                   {'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ'},
                                   {'Ы', 'Ь', 'Э', 'Ю', 'Я', '0', '1'},
                                   { '2','3', '4', '5', '6', '7', '8'},
                                   {'9', ' ', ',', '.', '!', '?', ';'}
                               };


            Console.WriteLine("Введите сообщение рускими буквами для шифровки: ");
            string mes = Console.ReadLine();
            string code = "";
            string nmes = "";


            for (int i = 0; i < mes.Length; i++)
            {
                for (int j = 0; j < alfrus.GetLength(0); j++)
                    for (int k = 0; k < alfrus.GetLength(1); k++)
                        if (Char.ToLower(alfrus[j, k]) == mes[i] || Char.ToUpper(alfrus[j, k]) == mes[i])
                        {
                            code += (Convert.ToString(j) + Convert.ToString(k));
                            if (j == alfrus.GetLength(0) - 1) {
                                nmes += alfrus[0, k];
                            }
                            else
                            {
                                nmes += alfrus[j+1, k];
                            }
                            
                            break;
                        }

            }
            Console.WriteLine(code);
            Console.WriteLine(nmes);
            Console.WriteLine("Введите код для расшифровки: ");
            string mes1 = Console.ReadLine();
            string nmes1 = "";
            for (int a = 0; a < mes1.Length; a += 2)
            {
                nmes1 += alfrus[Convert.ToInt32(mes1[a].ToString()), Convert.ToInt32(mes1[a + 1].ToString())];
            }
            Console.WriteLine(nmes1);
        }
    }
}