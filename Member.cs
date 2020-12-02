using System.Collections.Generic;

namespace CSharp_Inl2
{
    public class Member
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Accomodation { get; set; }
        public string CityName { get; set; }
        public int Age { get; set; }
        public string Family { get; set; }
        public string Pets { get; set; }
        public string LastJob { get; set; }
        public string Hobby { get; set; }
        public string FavoriteFood { get; set; }
        public string FavoriteMusic { get; set; }
        public string ProgrammingQuote { get; set; }

        public static List<Member> MembersList()
        {
            List<Member> memberList = new List<Member>
            {
                new Member { FirstName = "Mikael", LastName = "Larsson", CityName = "Vänersborg", Age = 36, Accomodation = "Villa", Family = "Fru, två döttrar och en tredje dotter på väg", Pets = "Två kaniner", LastJob = "Restauranglärare", Hobby = "Träning och hälsa, surdegsbröd", FavoriteFood = "Bönchiligryta i tortillabröd", FavoriteMusic = "Elektroniskt. Allt mellan ambient och techno", ProgrammingQuote = "Mitt största driv är att det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan"},
                new Member { FirstName = "Karin", LastName = "Karlsson", CityName = "Stockholm", Age = 35, Accomodation = "Hyr en villa", Family = "Sambo och en dotter", Pets = "Tre katter", LastJob = "Har varit ekonomiassistent, testare och senast föräldraledig", Hobby = "Bakning och spela Stardew Valley", FavoriteFood = "Någon form av biff, sötpotatispommes och beanésås", FavoriteMusic = "Just nu, allt som inte är barnvisor", ProgrammingQuote = "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv"},
                new Member { FirstName = "Sammy", LastName = "Wong", CityName = "Åmål", Age = 54, Accomodation = "Villa", Family = "Fru och en son", Pets = "Tre katter och en hund", LastJob = "Personlig assistent", Hobby = "Bakning och spela Stardew Valley", FavoriteFood = "Asiatisk, italiensk", FavoriteMusic = "Soul, RnB, House", ProgrammingQuote = "Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem"},
                new Member { FirstName = "David", LastName = "Frödin", CityName = "Sundbyberg", Age = 25, Accomodation = "Lägenhet", Family = "Det vanliga", Pets = "Inga", LastJob = "Verksamhetschef på en studentförening", Hobby = "Leta efter universums hemligheter, målning, lära sig språk", FavoriteFood = "Bortsch", FavoriteMusic = "Allt! Inne i rockperiod som varvas med rysk folkmusik", ProgrammingQuote = "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix"},
                new Member { FirstName = "Rauf", LastName = "Karimli", CityName = "Göteborg", Age = 36, Accomodation = "Villa", Family = "Fru, en son och en dotter", Pets = "Inga", LastJob = "Projektledare", Hobby = "Spela piano, laga mat", FavoriteFood = "Grillat kött", FavoriteMusic = "Gott och blandat", ProgrammingQuote = "De gränslösa möjligheterna att utveckla och utvecklas"},
                new Member { FirstName = "Erik", LastName = "Rindlert", CityName = "Stockholm", Age = 31, Accomodation = "Lägenhet", Family = "Ogift", Pets = "Inga", LastJob = "IT-Support", Hobby = "Litteratur, datorspel", FavoriteFood = "Svensk-fransk fisksoppa", FavoriteMusic = "Schubert eller Darkthrone, beroende på dag", ProgrammingQuote = "Bygga, bygga, bygga"},
                new Member { FirstName = "Daniel", LastName = "Arlbring", CityName = "Alingsås", Age = 24, Accomodation = "Hyr en Lägenhet", Family = "Sambo", Pets = "Inga", LastJob = "Väktare", Hobby = "Motorsport/datorspel", FavoriteFood = "Italienskt", FavoriteMusic = "House", ProgrammingQuote = "-"},
                new Member { FirstName = "Svante", LastName = "Joelsson", CityName = "Strömstad", Age = 36, Accomodation = "Lägenhet", Family = "Sambo och en son", Pets = "Hund", LastJob = "Fritidspedagog/Förskolelärare", Hobby = "Illustrera/Animera", FavoriteFood = "Pasta al fungi", FavoriteMusic = "Gubbrock och allt som är bra", ProgrammingQuote = "Kul combo av problemlösning och kreativitet, och att en dag landa ett jobb med mer frihet"},
                new Member { FirstName = "Sarah", LastName = "Winroth", CityName = "Vara", Age = 31, Accomodation = "Lägenhet", Family = "Gift", Pets = "Inga", LastJob = "Reseledare", Hobby = "Motionerar gärna", FavoriteFood = "Älskar mat i alla former", FavoriteMusic = "Lyssnar på det mesta", ProgrammingQuote = "Själva problemlösningen och tillfredsställelsen efteråt!"},
            };

            return memberList;
        }
    }
}

