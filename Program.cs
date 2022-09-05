using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Кодировка
            Encoding enc = Encoding.GetEncoding(1251);

            StreamReader FR = new StreamReader(@"C:\ttt.txt", enc);
            // Изменяемая строка  

            StringBuilder Stroka = new StringBuilder(FR.ReadLine());
            StringBuilder Stroka2 = new StringBuilder(FR.ReadLine());

            FR.Dispose();

            FileInfo FI = new FileInfo(@"C:\ttt.txt");

            // Создание файла с учетом коировки
            StreamWriter FW = new StreamWriter(FI.Create(), enc);



            // Ввод данных
            // Шифрирование
            for (int i = 0; i < Stroka.Length; i++)
            {

                switch (Stroka[i])
                {
                    case 'А': Stroka[i] = 'я'; break;
                    case 'Б': Stroka[i] = 'ю'; break;
                    case 'В': Stroka[i] = 'э'; break;
                    case 'Г': Stroka[i] = 'ь'; break;
                    case 'Д': Stroka[i] = 'ы'; break;
                    case 'Е': Stroka[i] = 'ъ'; break;
                    case 'Ё': Stroka[i] = 'щ'; break;
                    case 'Ж': Stroka[i] = 'ш'; break;
                    case 'З': Stroka[i] = 'ч'; break;
                    case 'И': Stroka[i] = 'ц'; break;
                    case 'Й': Stroka[i] = 'х'; break;
                    case 'К': Stroka[i] = 'ф'; break;
                    case 'Л': Stroka[i] = 'у'; break;
                    case 'М': Stroka[i] = 'т'; break;
                    case 'Н': Stroka[i] = 'с'; break;
                    case 'О': Stroka[i] = 'р'; break;
                    case 'П': Stroka[i] = 'п'; break;
                    case 'Р': Stroka[i] = 'о'; break;
                    case 'С': Stroka[i] = 'н'; break;
                    case 'Т': Stroka[i] = 'м'; break;
                    case 'У': Stroka[i] = 'л'; break;
                    case 'Ф': Stroka[i] = 'к'; break;
                    case 'Х': Stroka[i] = 'й'; break;
                    case 'Ц': Stroka[i] = 'и'; break;
                    case 'Ч': Stroka[i] = 'з'; break;
                    case 'Ш': Stroka[i] = 'ж'; break;
                    case 'Щ': Stroka[i] = 'ё'; break;
                    case 'Ъ': Stroka[i] = 'е'; break;
                    case 'Ы': Stroka[i] = 'д'; break;
                    case 'Ь': Stroka[i] = 'г'; break;
                    case 'Э': Stroka[i] = 'в'; break;
                    case 'Ю': Stroka[i] = 'б'; break;
                    case 'Я': Stroka[i] = 'а'; break;
                    case '0': Stroka[i] = 'z'; break;
                    case '1': Stroka[i] = 'y'; break;
                    case '2': Stroka[i] = 'x'; break;
                    case '3': Stroka[i] = 'w'; break;
                    case '4': Stroka[i] = 'v'; break;
                    case '5': Stroka[i] = 'u'; break;
                    case '6': Stroka[i] = 't'; break;
                    case '7': Stroka[i] = 's'; break;
                    case '8': Stroka[i] = 'r'; break;
                    case '9': Stroka[i] = 'q'; break;
                    case 'A': Stroka[i] = 'p'; break;
                    case 'B': Stroka[i] = 'o'; break;
                    case 'C': Stroka[i] = 'n'; break;
                    case 'D': Stroka[i] = 'm'; break;
                    case 'E': Stroka[i] = 'l'; break;
                    case 'F': Stroka[i] = 'k'; break;
                    case 'G': Stroka[i] = 'j'; break;
                    case 'H': Stroka[i] = 'i'; break;
                    case 'I': Stroka[i] = 'h'; break;
                    case 'J': Stroka[i] = 'g'; break;
                    case 'K': Stroka[i] = 'f'; break;
                    case 'L': Stroka[i] = 'e'; break;
                    case 'M': Stroka[i] = 'd'; break;
                    case 'N': Stroka[i] = 'c'; break;
                    case 'O': Stroka[i] = 'b'; break;
                    case 'P': Stroka[i] = 'a'; break;
                    case 'Q': Stroka[i] = 'Z'; break;
                    case 'R': Stroka[i] = 'Y'; break;
                    case 'S': Stroka[i] = 'X'; break;
                    case 'T': Stroka[i] = 'W'; break;
                    case 'U': Stroka[i] = 'V'; break;
                    case 'V': Stroka[i] = 'U'; break;
                    case 'W': Stroka[i] = 'T'; break;
                    case 'X': Stroka[i] = 'S'; break;
                    case 'Y': Stroka[i] = 'R'; break;
                    case 'Z': Stroka[i] = 'Q'; break;
                    case 'a': Stroka[i] = 'P'; break;
                    case 'b': Stroka[i] = 'O'; break;
                    case 'c': Stroka[i] = 'N'; break;
                    case 'd': Stroka[i] = 'M'; break;
                    case 'e': Stroka[i] = 'L'; break;
                    case 'f': Stroka[i] = 'K'; break;
                    case 'g': Stroka[i] = 'J'; break;
                    case 'h': Stroka[i] = 'I'; break;
                    case 'i': Stroka[i] = 'H'; break;
                    case 'j': Stroka[i] = 'G'; break;
                    case 'k': Stroka[i] = 'F'; break;
                    case 'l': Stroka[i] = 'E'; break;
                    case 'm': Stroka[i] = 'D'; break;
                    case 'n': Stroka[i] = 'C'; break;
                    case 'o': Stroka[i] = 'B'; break;
                    case 'p': Stroka[i] = 'A'; break;
                    case 'q': Stroka[i] = '9'; break;
                    case 'r': Stroka[i] = '8'; break;
                    case 's': Stroka[i] = '7'; break;
                    case 't': Stroka[i] = '6'; break;
                    case 'u': Stroka[i] = '5'; break;
                    case 'v': Stroka[i] = '4'; break;
                    case 'w': Stroka[i] = '3'; break;
                    case 'x': Stroka[i] = '2'; break;
                    case 'y': Stroka[i] = '1'; break;
                    case 'z': Stroka[i] = '0'; break;
                    case 'а': Stroka[i] = 'Я'; break;
                    case 'б': Stroka[i] = 'Ю'; break;
                    case 'в': Stroka[i] = 'Э'; break;
                    case 'г': Stroka[i] = 'Ь'; break;
                    case 'д': Stroka[i] = 'Ы'; break;
                    case 'е': Stroka[i] = 'Ъ'; break;
                    case 'ё': Stroka[i] = 'Щ'; break;
                    case 'ж': Stroka[i] = 'Ш'; break;
                    case 'з': Stroka[i] = 'Ч'; break;
                    case 'и': Stroka[i] = 'Ц'; break;
                    case 'й': Stroka[i] = 'Х'; break;
                    case 'к': Stroka[i] = 'Ф'; break;
                    case 'л': Stroka[i] = 'У'; break;
                    case 'м': Stroka[i] = 'Т'; break;
                    case 'н': Stroka[i] = 'С'; break;
                    case 'о': Stroka[i] = 'Р'; break;
                    case 'п': Stroka[i] = 'П'; break;
                    case 'р': Stroka[i] = 'О'; break;
                    case 'с': Stroka[i] = 'Н'; break;
                    case 'т': Stroka[i] = 'М'; break;
                    case 'у': Stroka[i] = 'Л'; break;
                    case 'ф': Stroka[i] = 'К'; break;
                    case 'х': Stroka[i] = 'Й'; break;
                    case 'ц': Stroka[i] = 'И'; break;
                    case 'ч': Stroka[i] = 'З'; break;
                    case 'ш': Stroka[i] = 'Ж'; break;
                    case 'щ': Stroka[i] = 'Ё'; break;
                    case 'ъ': Stroka[i] = 'Е'; break;
                    case 'ы': Stroka[i] = 'Д'; break;
                    case 'ь': Stroka[i] = 'Г'; break;
                    case 'э': Stroka[i] = 'В'; break;
                    case 'ю': Stroka[i] = 'Б'; break;
                    case 'я': Stroka[i] = 'А'; break;
                }
                if (i % 2 == 0)
                {
                    int A = (int)Stroka[i];
                    A -= 5;
                    Stroka[i] = (char)A;
                }
                else
                {
                    int A = (int)Stroka[i];
                    A += 5;
                    Stroka[i] = (char)A;
                }
            }
            for (int i = 0; i < Stroka2.Length; i++)
            {

                switch (Stroka2[i])
                {
                    case 'А': Stroka2[i] = 'Я'; break;
                    case 'Б': Stroka2[i] = 'Ю'; break;
                    case 'В': Stroka2[i] = 'Э'; break;
                    case 'Г': Stroka2[i] = 'Ь'; break;
                    case 'Д': Stroka2[i] = 'Ы'; break;
                    case 'Е': Stroka2[i] = 'Ъ'; break;
                    case 'Ё': Stroka2[i] = 'Щ'; break;
                    case 'Ж': Stroka2[i] = 'Ш'; break;
                    case 'З': Stroka2[i] = 'Ч'; break;
                    case 'И': Stroka2[i] = 'Ц'; break;
                    case 'Й': Stroka2[i] = 'Х'; break;
                    case 'К': Stroka2[i] = 'Ф'; break;
                    case 'Л': Stroka2[i] = 'У'; break;
                    case 'М': Stroka2[i] = 'Т'; break;
                    case 'Н': Stroka2[i] = 'С'; break;
                    case 'О': Stroka2[i] = 'Р'; break;
                    case 'П': Stroka2[i] = 'П'; break;
                    case 'Р': Stroka2[i] = 'О'; break;
                    case 'С': Stroka2[i] = 'Н'; break;
                    case 'Т': Stroka2[i] = 'М'; break;
                    case 'У': Stroka2[i] = 'Л'; break;
                    case 'Ф': Stroka2[i] = 'К'; break;
                    case 'Х': Stroka2[i] = 'Й'; break;
                    case 'Ц': Stroka2[i] = 'И'; break;
                    case 'Ч': Stroka2[i] = 'З'; break;
                    case 'Ш': Stroka2[i] = 'Ж'; break;
                    case 'Щ': Stroka2[i] = 'Ё'; break;
                    case 'Ъ': Stroka2[i] = 'Е'; break;
                    case 'Ы': Stroka2[i] = 'Д'; break;
                    case 'Ь': Stroka2[i] = 'Г'; break;
                    case 'Э': Stroka2[i] = 'В'; break;
                    case 'Ю': Stroka2[i] = 'Б'; break;
                    case 'Я': Stroka2[i] = 'А'; break;
                    case '0': Stroka2[i] = '9'; break;
                    case '1': Stroka2[i] = '8'; break;
                    case '2': Stroka2[i] = '7'; break;
                    case '3': Stroka2[i] = '6'; break;
                    case '4': Stroka2[i] = '5'; break;
                    case '5': Stroka2[i] = '4'; break;
                    case '6': Stroka2[i] = '3'; break;
                    case '7': Stroka2[i] = '2'; break;
                    case '8': Stroka2[i] = '1'; break;
                    case '9': Stroka2[i] = '0'; break;
                    case 'A': Stroka2[i] = 'Z'; break;
                    case 'B': Stroka2[i] = 'Y'; break;
                    case 'C': Stroka2[i] = 'X'; break;
                    case 'D': Stroka2[i] = 'W'; break;
                    case 'E': Stroka2[i] = 'V'; break;
                    case 'F': Stroka2[i] = 'U'; break;
                    case 'G': Stroka2[i] = 'T'; break;
                    case 'H': Stroka2[i] = 'S'; break;
                    case 'I': Stroka2[i] = 'R'; break;
                    case 'J': Stroka2[i] = 'Q'; break;
                    case 'K': Stroka2[i] = 'P'; break;
                    case 'L': Stroka2[i] = 'O'; break;
                    case 'M': Stroka2[i] = 'N'; break;
                    case 'N': Stroka2[i] = 'M'; break;
                    case 'O': Stroka2[i] = 'L'; break;
                    case 'P': Stroka2[i] = 'K'; break;
                    case 'Q': Stroka2[i] = 'J'; break;
                    case 'R': Stroka2[i] = 'I'; break;
                    case 'S': Stroka2[i] = 'H'; break;
                    case 'T': Stroka2[i] = 'G'; break;
                    case 'U': Stroka2[i] = 'F'; break;
                    case 'V': Stroka2[i] = 'E'; break;
                    case 'W': Stroka2[i] = 'D'; break;
                    case 'X': Stroka2[i] = 'C'; break;
                    case 'Y': Stroka2[i] = 'B'; break;
                    case 'Z': Stroka2[i] = 'A'; break;
                    case 'a': Stroka2[i] = 'z'; break;
                    case 'b': Stroka2[i] = 'y'; break;
                    case 'c': Stroka2[i] = 'x'; break;
                    case 'd': Stroka2[i] = 'w'; break;
                    case 'e': Stroka2[i] = 'v'; break;
                    case 'f': Stroka2[i] = 'u'; break;
                    case 'g': Stroka2[i] = 't'; break;
                    case 'h': Stroka2[i] = 's'; break;
                    case 'i': Stroka2[i] = 'r'; break;
                    case 'j': Stroka2[i] = 'q'; break;
                    case 'k': Stroka2[i] = 'p'; break;
                    case 'l': Stroka2[i] = 'o'; break;
                    case 'm': Stroka2[i] = 'n'; break;
                    case 'n': Stroka2[i] = 'm'; break;
                    case 'o': Stroka2[i] = 'l'; break;
                    case 'p': Stroka2[i] = 'k'; break;
                    case 'q': Stroka2[i] = 'j'; break;
                    case 'r': Stroka2[i] = 'i'; break;
                    case 's': Stroka2[i] = 'h'; break;
                    case 't': Stroka2[i] = 'g'; break;
                    case 'u': Stroka2[i] = 'f'; break;
                    case 'v': Stroka2[i] = 'e'; break;
                    case 'w': Stroka2[i] = 'd'; break;
                    case 'y': Stroka2[i] = 'c'; break;
                    case 'x': Stroka2[i] = 'b'; break;
                    case 'z': Stroka2[i] = 'a'; break;
                    case 'а': Stroka2[i] = 'я'; break;
                    case 'б': Stroka2[i] = 'ю'; break;
                    case 'в': Stroka2[i] = 'э'; break;
                    case 'г': Stroka2[i] = 'ь'; break;
                    case 'д': Stroka2[i] = 'ы'; break;
                    case 'е': Stroka2[i] = 'ъ'; break;
                    case 'ё': Stroka2[i] = 'щ'; break;
                    case 'ж': Stroka2[i] = 'ш'; break;
                    case 'з': Stroka2[i] = 'ч'; break;
                    case 'и': Stroka2[i] = 'ц'; break;
                    case 'й': Stroka2[i] = 'х'; break;
                    case 'к': Stroka2[i] = 'ф'; break;
                    case 'л': Stroka2[i] = 'у'; break;
                    case 'м': Stroka2[i] = 'т'; break;
                    case 'н': Stroka2[i] = 'с'; break;
                    case 'о': Stroka2[i] = 'р'; break;
                    case 'п': Stroka2[i] = 'п'; break;
                    case 'р': Stroka2[i] = 'о'; break;
                    case 'с': Stroka2[i] = 'н'; break;
                    case 'т': Stroka2[i] = 'м'; break;
                    case 'у': Stroka2[i] = 'л'; break;
                    case 'ф': Stroka2[i] = 'к'; break;
                    case 'х': Stroka2[i] = 'й'; break;
                    case 'ц': Stroka2[i] = 'и'; break;
                    case 'ч': Stroka2[i] = 'з'; break;
                    case 'ш': Stroka2[i] = 'ж'; break;
                    case 'щ': Stroka2[i] = 'ё'; break;
                    case 'ъ': Stroka2[i] = 'е'; break;
                    case 'ы': Stroka2[i] = 'д'; break;
                    case 'ь': Stroka2[i] = 'г'; break;
                    case 'э': Stroka2[i] = 'в'; break;
                    case 'ю': Stroka2[i] = 'б'; break;
                    case 'я': Stroka2[i] = 'а'; break;
                }
                if (i % 2 == 0)
                {
                    int A = (int)Stroka2[i];
                    A -= 3;
                    Stroka2[i] = (char)A;
                }
                else
                {
                    int A = (int)Stroka2[i];
                    A += 3;
                    Stroka2[i] = (char)A;
                }

            }
            Console.WriteLine("Зашифровнная строка");
            Console.WriteLine(Stroka);
            Console.WriteLine(Stroka2);

            // Завпись строки в файл
            FW.WriteLine(Stroka);
            FW.WriteLine(Stroka2);
            FW.Close();

            Console.ReadKey();
        }
    }
}
