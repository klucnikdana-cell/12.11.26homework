namespace _12._11._26_homework_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Company> companies = new List<Company>()
            {
                new Company
                {
                    Name = "McDonald's Food",
                    FoundingDate = new DateTime(1940, 5, 15),
                    BusinessProfile = "Food",
                    Director = "Chris Kempczinski",
                    Employees = 150000,
                    Address = "Chicago, USA"
                },

                new Company
                {
                    Name = "KFC Food",
                    FoundingDate = new DateTime(1952, 9, 24),
                    BusinessProfile = "Food",
                    Director = "Scott Mezvinsky",
                    Employees = 30000,
                    Address = "Louisville, USA"
                },

                new Company()
                {
                    Name = "Starbucks",
                    FoundingDate = new DateTime(1971, 3, 30),
                    BusinessProfile = "Food",
                    Director = "Brian Niccol",
                    Employees = 350000,
                    Address = "Seattle, USA"
                },

                new Company
                {
                    Name = "IT Step",
                    FoundingDate = new DateTime(1999, 1, 1),
                    BusinessProfile = "IT",
                    Director = "Unknown",
                    Employees = 1000,
                    Address = "Lviv, Ukraine"
                },

                new Company
                {
                     Name = "Marketing Pro",
                     FoundingDate = new DateTime(2015, 6, 10),
                     BusinessProfile = "Marketing",
                     Director = "John White",
                     Employees = 200,
                     Address = "London, UK"
                },

                new Company
                {
                     Name = "White Food",
                     FoundingDate = new DateTime(2020, 5, 10),
                     BusinessProfile = "Food",
                     Director = "Michael Black",
                     Employees = 150,
                     Address = "London, UK"
                }
            };
            Console.WriteLine("\t-----------TASK1---------\n");
            Console.WriteLine("All companies:");

            foreach(Company c in companies)
            {
                Console.WriteLine($"\nName: {c.Name}");
                Console.WriteLine($"Founding date: {c.FoundingDate.ToShortDateString()}");
                Console.WriteLine($"Business profile: {c.BusinessProfile}");
                Console.WriteLine($"Director: {c.Director}");
                Console.WriteLine($"Employees: {c.Employees}");
                Console.WriteLine($"Address: {c.Address}");
            }

            Console.WriteLine("\t-----------TASK2---------\n");
            Console.WriteLine("Companies with Food in name:");

            var result = companies.Where(c => c.Name.Contains("Food"));
            foreach(Company c in result)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("\t-----------TASK3---------\n");
            Console.WriteLine("Marketing companies:");

            var result2 = companies.Where(c => c.BusinessProfile == "Marketing");
            foreach (Company c in result2)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("\t-----------TASK4---------\n");
            Console.WriteLine("Marketing companies and IT:");

            var result3 = companies.Where(c => c.BusinessProfile == "Marketing" 
            || c.BusinessProfile == "IT");
            foreach(Company c in result3)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("\t-----------TASK5---------\n");
            Console.WriteLine("The number if employees is more than 100:");

            var result4 = companies.Where(c => c.Employees > 100);
            foreach(Company c in result4)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("\t-----------TASK6---------\n");
            Console.WriteLine("The number if employees is more from 100 to 300:");
            var result5 = companies.Where(c => c.Employees >= 100 && c.Employees <= 300);

            foreach (Company c in result5)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("\t-----------TASK7---------\n");
            Console.WriteLine("From London:");
            var result6 = companies.Where(c => c.Address.Contains("London"));

            foreach (Company c in result6)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("\t-----------TASK8---------\n");
            Console.WriteLine("Director with the surname White:");
            var result7 = companies.Where(c => c.Director.Contains("White"));
            foreach (Company c in result7)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("\t-----------TASK9---------\n");
            Console.WriteLine("Founded more than 2 years ago:");
            var result8 = companies.Where(c =>
    c.FoundingDate < DateTime.Today.AddYears(-2));
            foreach(Company c in result8)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("----------TASK11----------");

            var result9 = companies.Where(c =>
                c.Director.Contains("Black") && c.Name.Contains("White"));

            foreach (Company c in result9)
            {
                Console.WriteLine(c.Name);
            }


            Console.WriteLine("\n========== QUERY SYNTAX ==========");
            var task1 = from c in companies
                        select c;
            foreach (Company c in task1)
            {
                Console.WriteLine(c.Name);
            }

            var task2 = from c in companies
                        where c.Name.Contains("Food")
                        select c;
            Console.WriteLine("\nFood:");
            foreach (Company c in task2)
            {
                Console.WriteLine(c.Name);
            }

            var task3 = from c in companies
                        where c.BusinessProfile == "Marketing"
                        select c;
            Console.WriteLine("\nMarketing:");
            foreach (Company c in task3)
            {
                Console.WriteLine(c.Name);
            }


            var task4 = from c in companies
                        where c.BusinessProfile == "Marketing"
                        || c.BusinessProfile == "IT"
                        select c;
            Console.WriteLine("\nMarketing or IT:");
            foreach (Company c in task4)
            {
                Console.WriteLine(c.Name);
            }

            var task5 = from c in companies
                        where c.Employees > 100
                        select c;
            Console.WriteLine("\nMore than 100 employees:");
            foreach (Company c in task5)
            {
                Console.WriteLine(c.Name);
            }

            var task6 = from c in companies
                        where c.Employees >= 100 && c.Employees <= 300
                        select c;
            Console.WriteLine("\nFrom 100 to 300 employees:");
            foreach (Company c in task6)
            {
                Console.WriteLine(c.Name);
            }

            var task7  = from c in companies
                         where c.Address.Contains("London")
                         select c;
            Console.WriteLine("\nLondon:");
            foreach (Company c in task7)
            {
                Console.WriteLine(c.Name);
            }

            var task8 = from c in companies
                        where c.Director.Contains("White")
                        select c;
            Console.WriteLine("\nDirector White:");
            foreach (Company c in task8)
            {
                Console.WriteLine(c.Name);
            }

            var task9 = from c in companies
                        where c.FoundingDate < DateTime.Now.AddYears(-2)
                        select c;
            Console.WriteLine("\nFounded more than 2 years ago:");
            foreach (Company c in task9)
            {
                Console.WriteLine(c.Name);
            }

            var task10 = from c in companies
                         where c.Director.Contains("Black")
                         && c.Name.Contains("White")
                         select c;
            Console.WriteLine("\nDirector Black and company White:");
            foreach (Company c in task10)
            {
                Console.WriteLine(c.Name);
            }

        }
    }
}
