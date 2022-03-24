using System;

namespace Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
            Console.WriteLine("Введите сообщение рускими буквами для шифровки: ");
            string mes = Console.ReadLine();
            Console.WriteLine("Введите код (не более 42): ");
            int code = Int32.Parse(Console.ReadLine());
                if (code > 42 || code < 1)
                {
                    throw new Exception("Введено предельное значение");
                }

            string alfrus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string mesL = mes.ToLower();
            char[] nMes = new char[mesL.Length];
            int j = 0;

            for (int i = 0; i < mesL.Length; i++)
            {
                if (!char.IsLetter(mesL[i]))
                    nMes[i] = mesL[i];
                else
                {
                    nMes[i] = '|';
                    while (nMes[i] == '|')
                    {
                        if (mesL[i] == alfrus[j])
                        {
                            try
                            {
                                nMes[i] = alfrus[j + code];
                            }
                            catch
                            {
                                nMes[i] = alfrus[(j + code) - 33];
                            }
                        }
                        j++;
                    }
                    j = 0;
                }
            }


            Console.Write("Зашифрованный текст: ");
            for (int i =0; i<nMes.Length; i++) {

                Console.Write(nMes[i]); 

            }
                Console.WriteLine();




                    char[] mes1 = new char[nMes.Length];
                Console.WriteLine("Введите код для расшифровки: ");
                int code1 = Int32.Parse(Console.ReadLine());

               
                if (code1 != code)
                {
                    throw new Exception("Введён неверный код");
                }

                
          

                for (int i = 0; i < nMes.Length; i++)
                {
                    if (!char.IsLetter(nMes[i]))
                        mes1[i] = nMes[i];
                    else
                    {
                        mes1[i] = '|';
                        while (mes1[i] == '|')
                        {
                            if (nMes[i] == alfrus[j])
                            {
                                try
                                {
                                    mes1[i] = alfrus[j - code1];
                                }
                                catch
                                {
                                    mes1[i] = alfrus[(j - code1) + 33];
                                }
                            }
                            j++;
                        }
                        j = 0;
                    }
                }

                Console.Write("Расшифрованный текст: ");

                for (int i = 0; i < mes1.Length; i++)
                {

                    Console.Write(mes1[i]);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}