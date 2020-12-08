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
            // Den nya listan sorteras i bokstavsordning med hjälp av System.Linq
            members = members.OrderBy(x => x.LastName).ToList();

            Console.WriteLine("Inlämningsuppgift 2");
            LogIn(members);
        }

        private static void LogIn(List<Member> members)
        {
            string password = "";
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

        private static void Menu(List<Member> members)
        {
            Console.WriteLine("\n1. Visa en lista på alla deltagare \n2. Sök i listan \n3. Visa mig ett citat \n4. Visa mig vart medlemmarna bor: \n5. Ta bort en medlem \nQ. Avsluta");
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
                DeleteMember(members);
            }
            else if (option == "Q")
            {
                Environment.Exit(0);
            }
        }

        private static void PrintList(List<Member> members)
        {
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FullName},");
            }
            Menu(members);
        }

        private static void PrintListCity(List<Member> members)
        {
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FullName}, {member.LocationName}");
            }
            Menu(members);
        }

        private static void SearchList(List<Member> members)
        {
            Console.WriteLine("Skriv Q för att gå tillbaks");
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
                        Console.WriteLine("\n" + members[i].FullData);
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
                            Console.WriteLine(tempname + " är borttagen!");
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
        private static void RandomQuote(List<Member> members)
        {
            string option;
            Random random = new Random();
            bool run = true;
            while (run == true)
            {
                int index = random.Next(members.Count);
                Console.WriteLine(members[index].ProgrammingQuote + " - " + members[index].FullName);
                Console.Write("Fortsätt? J/N: ");
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
