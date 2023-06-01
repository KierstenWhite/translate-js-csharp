using System;
using System.Collections.Generic;
using System.Linq;

    List<Guest> guests = new List<Guest>()
    {
            new Guest()
            {
                Name = "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
            },
            new Guest()
            {
                Name = "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
            },
            new Guest()
            {
                Name = "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968)  American civil rights campaigner"
            },
            new Guest()
            {
                Name = "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005)  American civil rights activist"
            },
            new Guest()
            {
                Name = "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"
            },
            new Guest()
            {
                Name = "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
            },
            new Guest()
            {
                Name = "Admiral Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
            },
            new Guest()
            {
                Name = "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
            },
        };

        List<Guest> Table1 = new List<Guest>();
        List<Guest> Table2 = new List<Guest>();
        List<String> occupations = new List<String>();

        foreach (Guest singleGuest in guests)
        {
            if(occupations.Contains(singleGuest.Occupation)){
                Table2.Add(singleGuest);
            }
            else
            {
                Table1.Add(singleGuest);
                occupations.Add(singleGuest.Occupation);
            }
        }

        Console.WriteLine("Table 1");
        foreach (Guest singleGuest in Table1)
        {
            Console.WriteLine($"{singleGuest.Name}");
        }
        Console.WriteLine("Table 2");
        foreach (Guest singleGuest in Table2){
            Console.WriteLine($"{singleGuest.Name}");
        }

        public class Guest
            {
                public string Name { get; set; }
                public string Occupation { get; set; }
                public string Bio { get; set; }
            }























/*
Used ChatGPT because I was STRUGGLING
It said: In C#, the Main method is the entry point of the program, and the GetGuests method returns a list of Guest objects. 
The rest of the code follows a similar structure and logic to the JavaScript code. The Dictionary<string, 
List<Guest>> is used to represent the tables object in JavaScript, and the foreach loops iterate over the guests and tables.
*/

// using System;
// using System.Collections.Generic;

// class Guest
// {
//     public string Name { get; set; }
//     public string Occupation { get; set; }
//     public string Bio { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         List<Guest> guests = GetGuests();
//         Dictionary<string, List<Guest>> tables = new Dictionary<string, List<Guest>>()
//         {
//             { "Table 1", new List<Guest>() },
//             { "Table 2", new List<Guest>() }
//         };

//         foreach (Guest guest in guests)
//         {
//             List<string> table1Occupations = tables["Table 1"].ConvertAll(g => g.Occupation);
//             if (table1Occupations.Contains(guest.Occupation))
//             {
//                 tables["Table 2"].Add(guest);
//             }
//             else
//             {
//                 tables["Table 1"].Add(guest);
//             }
//         }

//         foreach (string tableName in tables.Keys)
//         {
//             List<Guest> tableGuests = tables[tableName];
//             Console.WriteLine(tableName);
//             foreach (Guest guest in tableGuests)
//             {
//                 Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
//             }
//         }
//     }

//     static List<Guest> GetGuests()
//     {
//         return new List<Guest>()
//         {
//             new Guest
//             {
//                 Name = "Marilyn Monroe",
//                 Occupation = "entertainer",
//                 Bio = "(1926 - 1962) American actress, singer, model"
//             },
//             new Guest
//             {
//                 Name = "Abraham Lincoln",
//                 Occupation = "politician",
//                 Bio = "(1809 - 1865) US President during American civil war"
//             },
//             new Guest
//             {
//                 Name = "Martin Luther King",
//                 Occupation = "activist",
//                 Bio = "(1929 - 1968)  American civil rights campaigner"
//             },
//             new Guest
//             {
//                 Name = "Rosa Parks",
//                 Occupation = "activist",
//                 Bio = "(1913 - 2005)  American civil rights activist"
//             },
//             new Guest
//             {
//                 Name = "Peter Sellers",
//                 Occupation = "entertainer",
//                 Bio = "(1925 - 1980) British actor and comedian"
//             },
//             new Guest
//             {
//                 Name = "Alan Turing",
//                 Occupation = "computer scientist",
//                 Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
//             },
//             new Guest
//             {
//                 Name = "Admiral Grace Hopper",
//                 Occupation = "computer scientist",
//                 Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
//             },
//             new Guest
//             {
//                 Name = "Indira Gandhi",
//                 Occupation = "politician",
//                 Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
//             }
//         };
//     }
// }
