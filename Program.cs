﻿using System;
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
            // Testar att sortera den nya listan i bokstavsordning med hjälp av System.Linq och ett lambda-uttryck 
            members = members.OrderBy(x => x.LastName).ToList();
            
            Console.WriteLine("Inlämningsuppgift 2");
            LogIn(members);
        }

        // En enkel metod som med hjälp av en while loop kontrollerar att korrekt lösenord matas in
        // Anropar därefter metoden Menu
        private static void LogIn(List<Member> members)
        {
            Console.Write("Lösenord: ");
            string password = Console.ReadLine();
            bool verify = false;

            while (verify == false)
            {
                if (password == "coffee n' code")
                {
                    Console.WriteLine("Korrekt lösenord! Välkommen!");
                    verify = true;
                }
                else
                {
                    Console.Write("Fel lösenord, prova igen: ");
                    password = Console.ReadLine();
                }
            }

            Menu(members);
        }


        // Meny som består av en samling if-statements som kollar om den string som användaren matar in matchar ett alternativ
        // Testade metoden ToUpper som i detta fall innebär att användaren kan mata in ett stort eller litet Q och programmet gör samma sak oavsett
        private static void Menu(List<Member> members)
        {
            Console.WriteLine("\n1. Visa en lista på alla deltagare \n2. Sök i listan \n3. Visa mig ett citat \n4. Visa mig vart medlemmarna bor \n5. Ta bort en medlem \nQ. Avsluta");
            Console.Write("\nVälj ett alternativ: ");
            string input = Console.ReadLine();
            string option = input.ToUpper();

            if (option == "1")
            {
                Console.WriteLine("1. Visa en lista på alla deltagare:");
                PrintList(members);
            }
            else if (option == "2")
            {
                Console.WriteLine("2. Sök i listan");
                Console.WriteLine("Skriv Q för att gå tillbaks \n");
                SearchList(members);
            }
            else if (option == "3")
            {
                Console.WriteLine("3. Visa mig ett citat!");
                RandomQuote(members);
            }
            else if (option == "4")
            {
                Console.WriteLine("4. Visa mig vart medlemmarna bor:");
                PrintListCity(members);
            }
            else if (option == "5")
            {
                Console.WriteLine("5. Ta bort en medlem");
                Console.WriteLine("Skriv Q för att gå tillbaks \n");
                DeleteMember(members);
            }
            else if (option == "Q")
            {
                Environment.Exit(0);
            }
        }

        // En foreach går igenom listan och printar ut namn med hjälp av Member.cs och den lista som skapades i main
        private static void PrintList(List<Member> members)
        {
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FullName},");
            }
            Menu(members);
        }

        // Test för att prova att skriva ut mer än bara namn
        private static void PrintListCity(List<Member> members)
        {
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FullName}, {member.LocationName}");
            }
            Menu(members);
        }


        // En metod för att söka bland medlemmarna och därefter skriva ut all deras information (FullInfo)
        // (Kan förmodligen förbättras!)
        private static void SearchList(List<Member> members)
        {

            string search;
            bool searching = true;
            while (searching == true)
            {
                Console.Write("Skriv in ett namn: ");
                search = Console.ReadLine();
                for (int i = 0; i < members.Count; i++)
                {
                    if (members[i].FullName.Equals(search))
                    {
                        Console.WriteLine("\n" + members[i].FullInfo);
                    }
                    else if (members[i].FullName.Equals(null))
                    {
                        SearchList(members);
                    }
                    else if (search == "Q")
                    {
                        Menu(members);
                    }
                }
            }
        }

        // En metod för att ta bort medlemmar som fungerar som en sökning fast index [i] används istället för att ta bort personen
        private static void DeleteMember(List<Member> members)
        {
            Console.WriteLine("Skriv Q för att gå tillbaks");
            string search;
            string deloption;
            string tempname;
            bool searching = true;
            while (searching == true)
            {
                Console.Write("\nSkriv in en medlem som du vill ta bort från listan: ");
                search = Console.ReadLine();
                for (int i = 0; i < members.Count; i++)
                {
                    if (members[i].FullName.Equals(search))
                    {
                        Console.WriteLine("\nVill du ta bort: " + members[i].FullName + "\n J/N");
                        tempname = members[i].FullName;
                        deloption = Console.ReadLine();
                        if (deloption == "J")
                        {
                            members.RemoveAt(i);
                            Console.WriteLine($"{tempname} är borttagen!");
                        }
                        else
                        {
                            DeleteMember(members);
                        }
                    }
                    else if (members[i].FullName.Equals(null))
                    {
                        SearchList(members);
                    }
                    else if (search == "Q")
                    {
                        Menu(members);
                    }
                }
            }
        }

        // Test för att prova att skriva ut ett citat med hjälp av random
        // random.Next plockar ut en slumpmässig siffra från members.Count och citatet med den platsen i listan skrivs ut
        private static void RandomQuote(List<Member> members)
        {
            string option;
            Random random = new Random();
            bool run = true;
            while (run == true)
            {
                int index = random.Next(members.Count);
                Console.WriteLine($"{members[index].ProgrammingQuote} - {members[index].FullName}");
                Console.Write("Ett till citat? J/N: ");
                option = Console.ReadLine();
                if (option == "N")
                {
                    run = false;
                }
                else
                {
                    continue;
                }
            }
            Menu(members);
        }
    }
}
