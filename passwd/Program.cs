using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;

namespace passwd
{
    class Program
    {
        static int Main(string[] args)
        {
            string alphabet = "abcdefjhigklmnopqistuvwxyz";
            Console.WriteLine("Введите три слова");
            string one = Console.ReadLine().ToLower();
            string two = Console.ReadLine().ToLower();
            string three = Console.ReadLine().ToLower();
            string passwd = "";
            if (one.Count() % 2 == 1)
            {
                if (three.Count() % 2 == 1)
                {
                    if (three[three.Count() / 2] == alphabet[alphabet.Count() - 3])
                    {
                        passwd += alphabet[0];
                    }
                    else if (three[three.Count() / 2] == alphabet[alphabet.Count() - 2])
                    {
                        passwd += alphabet[1];
                    }
                    else if (three[three.Count() / 2] == alphabet[alphabet.Count() - 1])
                    {
                        passwd += alphabet[2];
                    }
                    else
                    {
                        for (int i = 0; i < alphabet.Count(); i++)
                        {
                            if (three[three.Count() / 2] == alphabet[i])
                            {
                                passwd += alphabet[i + 3];
                            }
                        }
                    }
                }
                else
                {
                    if (three[three.Count() / 2 - 1] == alphabet[alphabet.Count() - 3])
                    {
                        passwd += alphabet[0];
                    }
                    else if (three[three.Count() / 2 - 1] == alphabet[alphabet.Count() - 2])
                    {
                        passwd += alphabet[1];
                    }
                    else if (three[three.Count() / 2 - 1] == alphabet[alphabet.Count() - 1])
                    {
                        passwd += alphabet[2];
                    }
                    else
                    {
                        for (int i = 0; i < alphabet.Count(); i++)
                        {
                            if (three[three.Count() / 2 - 1] == alphabet[i])
                            {
                                passwd += alphabet[i + 3];
                            }
                        }
                    }
                }
            }
            else
            {
                if (one[one.Count() / 2 - 1] == alphabet[0])
                {
                    passwd += alphabet[alphabet.Count() - 1];
                }
                else
                {
                    for (int i = 0; i < alphabet.Count(); i++)
                    {
                        if (one[one.Count() / 2 - 1] == alphabet[i])
                        {
                            passwd += alphabet[i - 1];
                        }
                    }
                }
            }
            if (two[two.Count()-1]==alphabet[0])
            {
                passwd += alphabet[alphabet.Count() - 1];
            }
            else
            {
                for (int i=0; i<alphabet.Count(); i++)
                {
                    if (two[two.Count() - 1]==alphabet[i])
                    {
                        passwd += alphabet[i - 1];
                    }
                }
            }
            if (three[0]==alphabet[alphabet.Count()-1])
            {
                passwd += alphabet[0];
            }
            else
            {
                for (int i=0; i<alphabet.Count(); i++)
                {
                    if (three[0]==alphabet[i])
                    {
                        passwd += alphabet[i + 1];
                    }
                }
            }
            if ((one.Count()+two.Count()-1)>26)
            {
                passwd += alphabet[(one.Count() + two.Count() - 1) % 26];
            }
            else
            {
                passwd += alphabet[one.Count() + two.Count() - 1];
            }
Auth:      string pass = "";
            Console.Write("Введите пароль: ");
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }
            }
            while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            for (int i =0; i<passwd.Count(); i++)
            {
                if (passwd[i] != pass[i])
                {
                    Console.WriteLine("Пароль неверный. Попробуйте еще раз.");
                    goto Auth;
                }
                
            }
            Console.WriteLine("Авторизация прошла успешно!");
            
            Console.WriteLine("Получившийся пароль: " + passwd);
            Console.ReadKey();
            return 0;
        }
    }
}
