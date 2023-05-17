using System;
using System.Globalization;

namespace PractiseGame
{
    class Program
    { 
        static void Main(string[] args)
        {
            //string hello = "Hello";
            //string world = "World";
            //Console.WriteLine(hello + " " + world);

            //int firstNumber = 2;
            //int secondNumber = 3;
            //Console.WriteLine(firstNumber + secondNumber);
            //Console.WriteLine(firstNumber - secondNumber);
            //Console.WriteLine(firstNumber * secondNumber);
            //Console.WriteLine(firstNumber / secondNumber);

            //Console.WriteLine("Введите ваше имя");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Введите вашу фамилию");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Введите ваше отчество");
            //string middleName = Console.ReadLine();
            //Console.WriteLine($"{firstName} {lastName} {middleName}");

            Console.WriteLine($"Введите имя персонажа");
            string nameHero = Console.ReadLine();
            int hpHero = 100;
            int damageHero = 60;
            int armorHero = 3;

            Console.WriteLine("Введите имя монстра");
            string nameMonstr = Console.ReadLine();
            int hpMonstr = 90;
            int damageMonstr = 60;
            int armorMonstr = 2;

            Console.WriteLine("Начать битву?");
            string accept = Console.ReadLine().ToLower();

            if (accept == "да")
            {
                for (; hpHero > 0 || hpMonstr > 0;)
                {
                    hpMonstr -= damageHero / armorMonstr;
                    Console.WriteLine($"{nameHero} нанесли монстру {damageHero / armorMonstr} урону");
                    Console.WriteLine($"Здоровье {nameMonstr} {hpMonstr} hp");

                    hpHero -= damageMonstr / armorHero;
                    Console.WriteLine($"{nameMonstr} нанес вам {damageMonstr / armorHero} урону");
                    Console.WriteLine($"{nameHero} здоровье {hpHero} hp");

                    if (hpHero <= 0)
                    {
                        Console.WriteLine($"{nameHero} проиграли");
                        break;
                    }
                    if (hpMonstr <= 0)
                    {
                        Console.WriteLine($"{nameHero} выиграли");
                        break;
                    }

                    Console.WriteLine("Продолжить сражаться? (введите да или нет)");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "да")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Вы сбежали");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ну и ладно");
            }
        }

        public string WritNewLine(string text )
        {
            return $"text {Environment.NewLine}";
        }
    }
}