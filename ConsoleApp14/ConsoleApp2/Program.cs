using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
             string alfrus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
             char[] NewAlfrus = new char[33];

        Console.Write("Ключевое слово: ");
            string keyWord = Console.ReadLine().ToLower();
            Console.Write("Ключ: ");
            int key = Convert.ToInt32(Console.ReadLine());


            // создаёт новый алфавит с помощью ключа

            bool same = false;
            int beg = 0;
            int c = key;
            // добавить ключевое слово в новый алфавит
            for (int i = key; i < keyWord.Length + key; i++)
            {
                for (int j = key; j < keyWord.Length + key; j++)
                {
                    if (keyWord[i - key] == NewAlfrus[j])
                    {
                        same = true;
                        break;
                    }
                }
                if (!same)// если повторений нету, то буква добавляется в новый алфавит
                {
                    NewAlfrus[c] = keyWord[i - key];
                    c++;
                }
                same = false;
            }

            // добавить буквы после ключевого слова
            for (int i = 0; i < alfrus.Length; i++)
            {
                for (int j = 0; j < NewAlfrus.Length; j++)
                {
                    if (alfrus[i] == NewAlfrus[j])
                    {
                        same = true;
                        break;
                    }
                }
                if (!same)
                {
                    NewAlfrus[c] = alfrus[i];
                    c++;
                }
                same = false;
                if (c == NewAlfrus.Length)
                {
                    beg = i;
                    break;
                }
            }
          
            // добавить буквы до ключевого слова
            c = 0;
            for (int i = beg; i < alfrus.Length; i++)
            {
                for (int j = 0; j < NewAlfrus.Length; j++)
                {
                    if (alfrus[i] == NewAlfrus[j])
                    {
                        same = true;
                        break;
                    }
                }
                if (!same)
                {
                    NewAlfrus[c] = alfrus[i];
                    c++;
                }
                same = false;
            }

        /////////////////////////////////
        


            Console.WriteLine();

            ////////////////////////////////////
            ///
            string strNewAlfrus = new string(NewAlfrus);
            Console.WriteLine("Шифрованный алфавит: " + strNewAlfrus);
            Console.WriteLine();
            /////////////////////////////////////////////////////////

            string mes = "";
           
            Console.Write("Cообщение: ");
            mes = Console.ReadLine().ToLower();

            /////////////////////////////////////////////////////
            ///шифруем сообщение 
            string nMes = "";
            foreach (char ch in mes)
            {
                for (int i = 0; i < alfrus.Length; i++)
                {
                    if (ch == alfrus[i])
                    {
                        nMes += NewAlfrus[i];
                        break;
                    }
                }
            }

            ////////////////////////////////////////////////////
            ///шифруем сообщение 
            Console.WriteLine();
            Console.WriteLine("Шифрованное сообщение: " + nMes);



            //расишифровываем сообщение
            string mes1 = "";
            foreach (char ch in nMes)
            {
                for (int i = 0; i < NewAlfrus.Length; i++)
                {
                    if (ch == NewAlfrus[i])
                    {
                        mes1 += alfrus[i];
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Расшифрованное сообщение: " + mes1);

            Console.ReadKey();
        }   
    } 
}

