using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace kp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            // Дано название футбольного клуба. Определить количество символов в нем.
            /*Write("Введите название футбольного клуба: ");
            string club = ReadLine();
            int count = club.Length;
            WriteLine($"Количество символов в клубе: {count}");*/

            //Task2
            //Дано название города. Определить, четно или нет количество символов в нем.
            /*Write("Введите название города: ");
            string town = ReadLine();
            int count = town.Length;
            //if(count %2==0)
            //{
            //    Write($"В {town} четное количество символов");
            //}
            //else
            //{
            //    Write($"В {town} нечетное количество символов");
            //}
            string a = count % 2 == 0 ? "В этом городе четное количество символов" : "В этом городе нечетное количество символов";
            Write(a);*/

            //Task3 
            //Даны две фамилии. Определить, какая из них длиннее
            /*Write("Введите первую фамилию: ");
            string sur1 = ReadLine();
            Write("Введите вторую фамилию: ");
            string sur2 = ReadLine();
            int count1 = sur1.Length;
            int count2 = sur2.Length;
            string dlina = count1 >= count2 ? "Первая фамилия длиннее" : "Вторая фамилия длиннее" ;
            Write(dlina);*/

            //task4
            // Найти самое длинное слово из пяти введенных с клавиатуры.
               string[] words = new string[5];     
               string longest = " ";
               for (int i = 0; i < 5; i++)         
               {
                   Write($"Введите {i+1} слово: ");
                   words[i] = ReadLine();
               }
               foreach(string word in words)          
               {
                   if (word.Length > longest.Length)
                   {
                       longest = word;
                   }
               }
               WriteLine($"\nСамое длинное слово: {longest}");   


            //task5
            //Составить программу, которая запрашивает отдельно имя и отдельно фамилию, а затем выводит их как одну символьную строку.
            /*Write("Введите имя: ");
            string name = ReadLine();
            Write("Введите фамилию: ");
            string surname = ReadLine();
            string space = " ";
            string all = name + space+ surname;
            Write(all);*/

            //task6
            //Подсчитать количество букв "а"("А") в строке.
            /*Write("Введите cтроку: ");
            string line = ReadLine();
            int count = 0;
            foreach(char symbol in line)
            {
                if (symbol =='а' || symbol=='А')
                {
                    count++;
                }
            }
            Write($"Кол-во букв 'а' или 'A' в строке '{line}' равно: {count}");*/

            //Task7
            //Подсчитать количество слов в предложении, при условии, что каждое слово отделяется от другого пробелом.
            /*Write("Введите предложение: ");
            string line = ReadLine();
            int words = line.Split(' ').Length;
            WriteLine($"В предложение {words} слова.") ;*/
            ReadKey();


        }
    }
}
