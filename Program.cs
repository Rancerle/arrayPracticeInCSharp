using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 6, 3, 2, 6};
            /*
            numbers[0] = 4;
            numbers[1] = 7;
            numbers[2] = 3;
            numbers[3] = 8;
            numbers[4] = 0;
            */
            Console.WriteLine(numbers[1]);
            Console.ReadLine();

            string[] names = new string[] { "marry", "isaac", "Allison", "james" };

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            string zig = "The universe is under no obligation" +
                "to makes sense to you";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach  (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();

        }
    }
}
