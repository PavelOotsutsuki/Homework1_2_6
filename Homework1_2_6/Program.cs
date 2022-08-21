using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finishGame=false;
            string switchCommand;
            string userName="";
            string password="";
            int modeMainMenu=1;
            int modeChangeConsoleColorMenu = 2;
            int modeMenu=modeMainMenu;

            while (finishGame==false)
            {
                Console.Clear();

                switch (modeMenu)
                {
                    case 1:
                        Console.WriteLine("Доступные команды: ");
                        Console.WriteLine();

                        if (userName == "")
                        {
                            Console.WriteLine("SetName – установить имя");
                        }
                        else
                        {
                            Console.WriteLine("ChangeName - сменить имя");

                            if (password != "")
                            {
                                Console.WriteLine("WriteName - вывести имя");
                            }
                        }

                        Console.WriteLine("ChangeConsoleColor - изменить цвет консоли");

                        if (password == "")
                        {
                            Console.WriteLine("SetPassword – установить пароль");
                        }
                        else
                        {
                            Console.WriteLine("ChangePassword - сменить пароль");
                        }

                        Console.WriteLine("Esc – выход из программы");
                        Console.WriteLine();
                        Console.Write("Введите команду: ");
                        switchCommand = Console.ReadLine();

                        switch (switchCommand)
                        {
                            case "SetName":
                                if (userName == "")
                                {
                                    Console.Write("Введите имя: ");
                                    userName = Console.ReadLine();
                                    Console.WriteLine("Ваше имя: " + userName);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Такой команды нет");
                                    Console.ReadKey();
                                }

                                break;
                            case "ChangeName":
                                if (userName == "")
                                {
                                    Console.WriteLine("Такой команды нет");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Write("Введите имя: ");
                                    userName = Console.ReadLine();
                                    Console.WriteLine("Ваше имя: " + userName);
                                    Console.ReadKey();
                                }

                                break;
                            case "WriteName":
                                if (userName != "" && password!= "")
                                {
                                    Console.WriteLine("Ваше имя: " + userName);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Такой команды нет");
                                    Console.ReadKey();
                                }

                                break;
                            case "ChangeConsoleColor":
                                modeMenu = modeChangeConsoleColorMenu;
                                break;
                            case "SetPassword":
                                if (password == "")
                                {
                                    Console.WriteLine("Введите новый пароль: ");
                                    password = Console.ReadLine();
                                    Console.WriteLine("Пароль успешно изменен!");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Такой команды нет");
                                    Console.ReadKey();
                                }

                                break;
                            case "ChangePassword":
                                if (password == "")
                                {
                                    Console.WriteLine("Такой команды нет");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Введите текущий пароль: ");
                                    string passwordCheck=Console.ReadLine();

                                    if (passwordCheck == password)
                                    {
                                        Console.WriteLine("Введите новый пароль: ");

                                        do
                                        {
                                            password = Console.ReadLine();

                                            if (password=="")
                                            {
                                                Console.WriteLine("Пароль должен быть не пустым, попытайтесь снова!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Пароль успешно изменен!");
                                            }
                                            Console.ReadKey();
                                        }
                                        while (password == "");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный пароль, отказано в доступе");
                                        Console.ReadKey();
                                    }
                                }

                                break;
                            case "Esc":
                                finishGame = true;
                                break;
                            default:
                                Console.WriteLine("Такой команды нет");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Доступные команды: ");
                        Console.WriteLine();
                        Console.WriteLine("SetGreenColor - задать зеленый цвет консоли");
                        Console.WriteLine("SetRedColor - задать красный цвет консоли");
                        Console.WriteLine("SetBlueColor - задать синий цвет консоли");
                        Console.WriteLine("SetBlackColor - задать черный цвет консоли");
                        Console.WriteLine("MainMenu - вернуться в главное меню");
                        Console.WriteLine("Esc – выход из программы");
                        Console.WriteLine();
                        Console.Write("Введите команду: ");
                        switchCommand = Console.ReadLine();

                        switch (switchCommand)
                        {
                            case "SetGreenColor":
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.WriteLine("Цвет консоли успешно изменен!");
                                Console.ReadKey();
                                break;
                            case "SetRedColor":
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Цвет консоли успешно изменен!");
                                Console.ReadKey();
                                break;
                            case "SetBlueColor":
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Цвет консоли успешно изменен!");
                                Console.ReadKey();
                                break;
                            case "SetBlackColor":
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("Цвет консоли успешно изменен!");
                                Console.ReadKey();
                                break;
                            case "MainMenu":
                                modeMenu = modeMainMenu;
                                break;
                            case "Esc":
                                finishGame = true;
                                break;
                            default:
                                Console.WriteLine("Такой команды нет");
                                Console.ReadKey();
                                break;
                        }

                        break;
                    default:
                        Console.WriteLine("Ошибка программы, такого режима нет");
                        Console.ReadKey();
                        finishGame = true;
                        break;
                }
            }
        }
    }
}




