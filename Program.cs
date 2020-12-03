using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Inl2
{
    class Program
    {
        static void Main(string[] args)
        {
            // En ny lista "members" skapas upp från Member.cs 
            List<Member> members = Member.MembersList();
            members = members.OrderBy(x => x.LastName).ToList();

            Console.WriteLine("Inlämningsuppgift 2");
            LogIn(members);
        }
        static private void PrintList(List<Member> members)
        {
            // Linq 
            
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FullName},");
            }
        }

        static private void PrintListCity(List<Member> members)
        {
            
            
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FullName}, {member.CityName}");
            }
        }

        static private void LogIn(List<Member> members)
        {
            var password = "";
            bool verify = false;
            while (verify == false)

            {
                while (password != "coffee n' code")
                {
                    Console.Write("Lösenord: ");
                    password = Console.ReadLine();
                }
                if (password == "coffee n' code")
                {
                    Console.WriteLine("Korrekt lösenord! Välkommen!");
                    verify = true;
                }
                else
                {
                    Console.Write("Felaktigt lösenord! Prova igen: ");
                    password = Console.ReadLine();
                }
            }

            Menu(members);
        }
    
        static private void Menu(List<Member> members)
        {
            

            Console.WriteLine("\n1. Visa en lista på alla deltagare \n2. Visa mig ett citat! \n3. Visa mig vart i Sverige medlemmarna bor \n4. Ta bort en medlem \nQ. Avsluta");
            Console.Write("\nVälj ett alternativ: ");
            string input = Console.ReadLine();
            string option = input.ToUpper();

            if (option == "1")
            {
                Console.WriteLine("1. Visa en lista på alla deltagare");
                PrintList(members);
            }
            else if (option == "2")
            {
                Console.WriteLine("2. Visa mig ett citat!");
            }
            else if (option == "3")
            {
                Console.WriteLine("Visa mig vart i Sverige medlemmarna bor");
                PrintListCity(members);
            }
            else if (option == "4")
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
