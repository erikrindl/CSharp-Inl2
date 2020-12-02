using System;
using System.Collections.Generic;

namespace CSharp_Inl2
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
        }

        static private void Menu(List<Member> memberList)
        {
            Console.WriteLine("\n1. Visa en lista på alla deltagarel \n2. Visa mig ett citat! \n3. Ta bort en medlem \nQ. Avsluta");
            Console.Write("\nVälj ett alternativ: ");
            string input = Console.ReadLine();
            string option = input.ToUpper();

            if (option == "1")
            {
                Console.WriteLine("1. Visa en lista på alla deltagare");
            }
            else if (option == "2")
            {
                Console.WriteLine("2. Visa mig ett citat!");
            }
            else if (option == "3")
            {
                Console.WriteLine("Ta bort en medlem");
            }
            else if (option == "Q")
            {
                Environment.Exit(0);
            }
        }
    }
}
