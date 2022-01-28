using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CampSleepaway.Data;
using CampSleepaway.Models;
using System.Linq;

namespace CampSleepaway
{
    class Program
    {
        private static CampSleepawayContext context = new CampSleepawayContext();
        static void Main(string[] args)
        {
            //Kräver en "update-database", seeda genom att starta programmet och välj "6. Seed database"
            Menu();
        }
        #region SeedData
        private static void SeedAddData()
        {
            context.AddRange(
                new Camper { FirstName = "Eric", LastName = "Cartman", SocialSecurityNo = "548-89-9366" },
                new Camper { FirstName = "Kyle", LastName = "Broflowski", SocialSecurityNo = "566-56-8976" },
                new Camper { FirstName = "Ike", LastName = "Broflowski", SocialSecurityNo = "887-37-3470" },
                new Camper { FirstName = "Stan", LastName = "Marsh", SocialSecurityNo = "961-77-6316" },
                new Camper { FirstName = "Shelly", LastName = "Marsh", SocialSecurityNo = "412-33-8431" },
                new Camper { FirstName = "Kenny", LastName = "McCormick", SocialSecurityNo = "322-17-5997" },
                new Camper { FirstName = "Kevin", LastName = "McCormick", SocialSecurityNo = "410-88-3479" },
                new Camper { FirstName = "Karen", LastName = "McCormick", SocialSecurityNo = "548-56-9366" },
                new Camper { FirstName = "Butters", LastName = "Stotch", SocialSecurityNo = "883-12-5722" },
                new Camper { FirstName = "Wendy", LastName = "Testaburger", SocialSecurityNo = "135-95-1235" },
                new Camper { FirstName = "Tweek", LastName = "Tweak", SocialSecurityNo = "545-45-8722" },
                new Camper { FirstName = "Clyde", LastName = "Donovan", SocialSecurityNo = "444-81-9997" },
                new Camper { FirstName = "Craig", LastName = "Tucker", SocialSecurityNo = "763-77-5211" },
                new Camper { FirstName = "Heidi", LastName = "Turner", SocialSecurityNo = "123-32-8425" },
                new Camper { FirstName = "Timmy", LastName = "Burch", SocialSecurityNo = "772-14-4630" },
                new Camper { FirstName = "Jimmy", LastName = "Valmer", SocialSecurityNo = "711-79-3277" },
                new Camper { FirstName = "Annie", LastName = "Knitts", SocialSecurityNo = "412-35-1212" },
                new Camper { FirstName = "Bebe", LastName = "Stevens", SocialSecurityNo = "333-88-9886" },
                new Counselor { FirstName = "Randy", LastName = "Marsh", Email = "randy.m@yahoo.com" },
                new Counselor { FirstName = "Mr", LastName = "Mackey", Email = "mr.mackey@spelementary.com" },
                new Counselor { FirstName = "Herbert", LastName = "Garrison", Email = "h.garrison@spelementary.com" },
                new Cabin { Name = "The Coon" },
                new Cabin { Name = "Mysterion" },
                new Cabin { Name = "Mintberry Crunch" },
                new NextOfKin { FirstName = "Sharon", LastName = "Marsh", PhoneNo = "202-555-0193" },
                new NextOfKin { FirstName = "Stuart", LastName = "McCormick", PhoneNo = "518-555-0197" },
                new NextOfKin { FirstName = "Stephen", LastName = "Stotch", PhoneNo = "512-555-0105" },
                new NextOfKin { FirstName = "Laura", LastName = "Tucker", PhoneNo = "302-555-0169" });
            context.SaveChanges();
        }
        private static void SeedPopulateCabins()
        {
            DateTime date1 = new DateTime(2021, 6, 22);
            DateTime date2 = new DateTime(2021, 7, 10);
            context.AddRange(
                new CamperInCabin { CabinId = 1, CamperId = 1, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 1, CamperId = 2, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 1, CamperId = 3, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 1, CamperId = 4, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 2, CamperId = 5, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 2, CamperId = 6, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 2, CamperId = 7, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 2, CamperId = 8, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 3, CamperId = 9, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 3, CamperId = 10, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 3, CamperId = 11, StartDate = date1, EndDate = date2 },
                new CamperInCabin { CabinId = 3, CamperId = 12, StartDate = date1, EndDate = date2 },
                new CounselorInCabin { CabinId = 1, CounselorId = 1, StartDate = date1, EndDate = date2 },
                new CounselorInCabin { CabinId = 2, CounselorId = 2, StartDate = date1, EndDate = date2 },
                new CounselorInCabin { CabinId = 3, CounselorId = 3, StartDate = date1, EndDate = date2 });
            context.SaveChanges();
        }
        private static void SeedAddNextOfKins()
        {
            context.AddRange(
                new CamperNextOfKin { CamperId = 10, NextOfKinId = 1 },
                new CamperNextOfKin { CamperId = 15, NextOfKinId = 2 },
                new CamperNextOfKin { CamperId = 18, NextOfKinId = 2 },
                new CamperNextOfKin { CamperId = 12, NextOfKinId = 3 },
                new CamperNextOfKin { CamperId = 13, NextOfKinId = 3 },
                new CamperNextOfKin { CamperId = 14, NextOfKinId = 3 },
                new CamperNextOfKin { CamperId = 6, NextOfKinId = 4 });
            context.SaveChanges();
        }
        #endregion
        #region CamperMethods
        private static void FindCamper()
        {
            Console.WriteLine("Enter firstname:");
            string name = Console.ReadLine();
            var camper = context.Campers.Where(s => s.FirstName == name).FirstOrDefault();
            if (camper is Camper)
            {
                var camper2 = context.Campers.Where(c => c.FirstName == name).ToList();
                Console.WriteLine("Camper found:\n");
                foreach (var c in camper2)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName} {c.SocialSecurityNo}");
                }
            }
            else
            {
                Console.WriteLine("Camper not found.");
            }
        }
        private static void UpdateCamper()
        {
            Console.WriteLine("Enter the first name of the camper you wish to update:");
            string name = Console.ReadLine();
            var camper = context.Campers.Where(c => c.FirstName == name).FirstOrDefault();
            if (camper is Camper)
            {
                Console.WriteLine("Enter new name:");
                string camperNewName = Console.ReadLine();
                camper.FirstName = camperNewName;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Camper not found.");
            }
        }
        private static void InsertCamper()
        {
            Console.WriteLine("Enter firstname:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter social security number (###-##-####):");
            string sSecNo = Console.ReadLine();
            var camper = new Camper { FirstName = fname, LastName = lName, SocialSecurityNo = sSecNo };
            context.Campers.Add(camper);
            context.SaveChanges();
            Console.WriteLine($"Camper added: {fname} {lName} {sSecNo}");
        }
        private static void RemoveCamper()
        {
            Console.WriteLine("Enter firstname:");
            string name = Console.ReadLine();
            var camper = context.Campers.Where(c => c.FirstName == name).FirstOrDefault();
            int id = camper.CamperId;
            var camperInCabin = context.CampersInCabins.Where(c => c.CamperId == id).FirstOrDefault();
            if (camperInCabin is CamperInCabin)
            {
                Console.WriteLine("This camper cannot be removed.");
            }
            else
            {
                context.Remove(camper);
                context.SaveChanges();
                Console.WriteLine("Camper removed.");
            }

        }
        private static void AddCamperToCabin()
        {
            Console.WriteLine("Select a cabin by number:");
            foreach (var c in context.Cabins)
            {
                Console.WriteLine($"{c.CabinId}. {c.Name}");
            }
            int cabinId = int.Parse(Console.ReadLine());
            var camperCabin = context.CampersInCabins.Where(c => c.CabinId == cabinId).ToList();
            if (camperCabin.Count >= 4)
            {
                Console.WriteLine("Cabin is full. Try another cabin");
            }
            else if (camperCabin.Count < 4)
            {
                var counselorCabin = context.CounselorsInCabins.Where(c => c.CabinId == cabinId).ToList();
                if (counselorCabin.Count == 0)
                {
                    Console.WriteLine("WARNING! There is no counselor assigned to this cabin!");
                }
                Console.WriteLine("Choose camper to add by number:");
                foreach (var c in context.Campers)
                {
                    Console.WriteLine($"{c.CamperId}. {c.FirstName} {c.LastName}");
                }
                int camperId = int.Parse(Console.ReadLine());
                DateTime startDate = DateTime.Today;
                context.Add(new CamperInCabin { CabinId = cabinId, CamperId = camperId, StartDate = startDate });
                context.SaveChanges();
                Console.WriteLine("Success");
            }
        }
        #endregion
        #region CabinMethods
        private static void AddCabin()
        {
            Console.WriteLine("Enter new cabin name:");
            string cabinName = Console.ReadLine();
            context.Add(new Cabin { Name = cabinName });
            context.SaveChanges();
        }
        private static void RemoveCabin()
        {
            Console.WriteLine("Enter cabin name:");
            string name = Console.ReadLine();
            var cabin = context.Cabins.Where(c => c.Name == name).FirstOrDefault();
            int id = cabin.CabinId;
            var cabinId = context.Cabins.Where(c => c.CabinId == id).FirstOrDefault();
            if (cabinId is Cabin)
            {
                Console.WriteLine("This camper cannot be removed.");
            }
            else
            {
                context.Remove(cabin);
                context.SaveChanges();
            }
        }//not implemented
        private static void FindCabin()
        {
            Console.WriteLine("Enter name of cabin:");
            string name = Console.ReadLine();
            var cabin = context.Cabins.Where(s => s.Name == name).FirstOrDefault();
            if (cabin is Cabin)
            {
                var cabin2 = context.Cabins.Where(c => c.Name == name).ToList();
                Console.WriteLine("Cabin found:\n");
                foreach (var c in cabin2)
                {
                    Console.WriteLine($"{c.CabinId} {c.Name}");
                }
            }
            else
            {
                Console.WriteLine("Cabin not found.");
            }
        }
        private static void UpdateCabin()
        {
            Console.WriteLine("Enter the name of the cabin you wish to update:");
            string name = Console.ReadLine();
            var cabin = context.Cabins.Where(c => c.Name == name).FirstOrDefault();
            if (cabin is Cabin)
            {
                Console.WriteLine("Enter new name:");
                string cabinNewName = Console.ReadLine();
                cabin.Name = cabinNewName;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cabin not found.");
            }
        }
        #endregion
        #region CounselorMethods
        private static void FindCounselor()
        {
            Console.WriteLine("Enter firstname:");
            string name = Console.ReadLine();
            var counselor = context.Counselors.Where(s => s.FirstName == name).FirstOrDefault();
            if (counselor is Counselor)
            {
                var counselor2 = context.Counselors.Where(c => c.FirstName == name).ToList();
                Console.WriteLine("Counselor found:\n");
                foreach (var c in counselor2)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName} {c.Email}");
                }
            }
            else
            {
                Console.WriteLine("Counselor not found.");
            }
        }
        private static void InsertCounselor()
        {
            Console.WriteLine("Enter firstname:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            string mail = Console.ReadLine();
            var counselor = new Counselor { FirstName = fname, LastName = lName, Email = mail };
            context.Counselors.Add(counselor);
            context.SaveChanges();
            Console.WriteLine($"Counselor added: {fname} {lName} {mail}");
        }
        private static void RemoveCounselor()
        {
            Console.WriteLine("Enter firstname:");
            string name = Console.ReadLine();
            var counselor = context.Counselors.Where(c => c.FirstName == name).FirstOrDefault();
            int id = counselor.CounselorId;
            var counselorInCabin = context.CounselorsInCabins.Where(c => c.CounselorId == id).FirstOrDefault();
            if (counselorInCabin is CounselorInCabin)
            {
                Console.WriteLine("This counselor cannot be removed.");
            }
            else
            {
                context.Remove(counselor);
                context.SaveChanges();
                Console.WriteLine("Counselor removed.");
            }
        }
        private static void UpdateCounselor()
        {
            Console.WriteLine("Enter the first name of the counselor you wish to update:");
            string name = Console.ReadLine();
            var counselor = context.Counselors.Where(c => c.FirstName == name).FirstOrDefault();
            if (counselor is Counselor)
            {
                Console.WriteLine("Enter new name:");
                string counselorNewName = Console.ReadLine();
                counselor.FirstName = counselorNewName;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Counselor not found.");
            }
        }
        private static void AddCounselorToCabin()
        {
            Console.WriteLine("Select a cabin by number:");
            foreach (var c in context.Cabins)
            {
                Console.WriteLine($"{c.CabinId}. {c.Name}");
            }
            int cabinId = int.Parse(Console.ReadLine());
            var counselorCabin = context.CounselorsInCabins.Where(c => c.CabinId == cabinId).ToList();
            if (counselorCabin.Count >= 1)
            {
                Console.WriteLine("Cabin is full. Try another cabin");
            }
            else if (counselorCabin.Count < 1)
            {
                var counselorCabin2 = context.CounselorsInCabins.Where(c => c.CabinId == cabinId).ToList();
                if (counselorCabin2.Count == 0)
                {
                    Console.WriteLine("WARNING! There is no counselor assigned to this cabin!");
                }
                Console.WriteLine("Choose counselor to add by number:");
                foreach (var c in context.Counselors)
                {
                    Console.WriteLine($"{c.CounselorId}. {c.FirstName} {c.LastName}");
                }
                int counselorId = int.Parse(Console.ReadLine());
                DateTime startDate = DateTime.Today;
                context.Add(new CounselorInCabin { CabinId = cabinId, CounselorId = counselorId, StartDate = startDate });
                context.SaveChanges();
                Console.WriteLine("Success");
            }
        }
        #endregion
        #region NextofkinMethods
        private static void FindNextOfKin()
        {
            Console.WriteLine("Enter firstname:");
            string name = Console.ReadLine();
            var nextofkin = context.NextOfKins.Where(s => s.FirstName == name).FirstOrDefault();
            if (nextofkin is NextOfKin)
            {
                var nextofkin2 = context.NextOfKins.Where(c => c.FirstName == name).ToList();
                Console.WriteLine("Next of kin found:\n");
                foreach (var n in nextofkin2)
                {
                    Console.WriteLine($"{n.FirstName} {n.LastName} {n.PhoneNo}");
                }
            }
            else
            {
                Console.WriteLine("Next of kin not found.");
            }
        }
        private static void UpdateNextOfKin()
        {
            Console.WriteLine("Enter the first name of the next of kin you wish to update:");
            string name = Console.ReadLine();
            var nextOfKin = context.NextOfKins.Where(c => c.FirstName == name).FirstOrDefault();
            if (nextOfKin is NextOfKin)
            {
                Console.WriteLine("Enter new name:");
                string nokNewName = Console.ReadLine();
                nextOfKin.FirstName = nokNewName;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Next of kin not found.");
            }
        }
        private static void InsertNextOfKin()
        {
            Console.WriteLine("Enter firstname:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter phone number (###-###-####):");
            string phoneNo = Console.ReadLine();
            var nextOfKin = new NextOfKin { FirstName = fname, LastName = lName, PhoneNo = phoneNo };
            context.NextOfKins.Add(nextOfKin);
            context.SaveChanges();
            Console.WriteLine($"Next of kin added: {fname} {lName} {phoneNo}");
        }
        private static void RemoveNextOfKin()
        {
            Console.WriteLine("Enter firstname:");
            string name = Console.ReadLine();
            var nextOfKin = context.NextOfKins.Where(c => c.FirstName == name).FirstOrDefault();
            int id = nextOfKin.NextOfKinId;
            var nextOfKinCamper = context.NextOfKins.Where(c => c.NextOfKinId == id).FirstOrDefault();
            if (nextOfKinCamper is NextOfKin)
            {
                Console.WriteLine("This next of kin cannot be removed.");
            }
            else
            {
                context.Remove(nextOfKin);
                context.SaveChanges();
                Console.WriteLine("Next of kin removed.");
            }
        }
        private static void AddNextOfKinToCamper()
        {
            Console.WriteLine("Select a next of kin by number:");
            foreach (var n in context.NextOfKins)
            {
                Console.WriteLine($"{n.NextOfKinId}. {n.FirstName} {n.LastName}");
            }
            int nextOfKinId= int.Parse(Console.ReadLine());

            Console.WriteLine("Select a camper by number:");
            foreach (var c in context.Campers)
            {
                Console.WriteLine($"{c.CamperId}. {c.FirstName} {c.LastName}");
            }
            int camperId = int.Parse(Console.ReadLine());

            context.Add(new CamperNextOfKin { CamperId = camperId, NextOfKinId = nextOfKinId });
            context.SaveChanges();
            Console.WriteLine("Success");
        }
        #endregion
        #region HistoryMethods
        private static void ShowAllCabins()
        {
            var query = from c in context.Campers
                         join cic in context.CampersInCabins on c.CamperId equals cic.CamperId
                         join ca in context.Cabins on cic.CabinId equals ca.CabinId
                         select new
                         {
                             c.FirstName,
                             c.LastName,
                             ca.Name,
                             cic.StartDate,
                             cic.EndDate
                         };
            var query2 = from co in context.Counselors
                          join coic in context.CounselorsInCabins on co.CounselorId equals coic.CounselorId
                          join ca in context.Cabins on coic.CabinId equals ca.CabinId
                          select new
                          {
                              co.FirstName,
                              co.LastName,
                              ca.Name,
                              coic.StartDate,
                              coic.EndDate
                          };
            Console.WriteLine("NAME:               CABIN:                 STARDATE             ENDDATE");
            foreach (var c in query)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName} --- {c.Name} --- {c.StartDate} --- {c.EndDate}");
            }
            foreach (var co in query2)
            {
                Console.WriteLine($"{co.FirstName} {co.LastName} --- {co.Name} --- {co.StartDate} --- {co.EndDate}");
            }
        }
        private static void FindCamperByCabin()
        {
            Console.WriteLine("Select a cabin by number:");
            foreach (var c in context.Cabins)
            {
                Console.WriteLine($"{c.CabinId}. {c.Name}");
            }
            int input = int.Parse(Console.ReadLine());
            var query = from c in context.Campers
                        join cic in context.CampersInCabins on c.CamperId equals cic.CamperId
                        join ca in context.Cabins on cic.CabinId equals ca.CabinId
                        where ca.CabinId == input
                        select new
                        {
                            c.FirstName,
                            c.LastName,
                            ca.Name,
                            cic.StartDate,
                            cic.EndDate
                        };
            var counselorCabin = context.CounselorsInCabins.Where(c => c.CabinId == input).ToList();
            if (counselorCabin.Count == 0)
            {
                Console.WriteLine("WARNING! There is no counselor assigned to this cabin!");
            }
            Console.WriteLine("NAME:               CABIN:                 STARDATE             ENDDATE");
            foreach (var c in query)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName} --- {c.Name} --- {c.StartDate} --- {c.EndDate}");
            }
        }
        private static void FindNextOfKinByCabin()
        {
            Console.WriteLine("Select a cabin by number:");
            foreach (var c in context.Cabins)
            {
                Console.WriteLine($"{c.CabinId}. {c.Name}");
            }
            int input = int.Parse(Console.ReadLine());
            var query = from nok in context.NextOfKins
                        join cnok in context.CamperNextOfKins on nok.NextOfKinId equals cnok.NextOfKinId
                        join cam in context.Campers on cnok.CamperId equals cam.CamperId
                        join cic in context.CampersInCabins on cam.CamperId equals cic.CamperId
                        join cab in context.Cabins on cic.CabinId equals cab.CabinId
                        where cab.CabinId == input
                        select new
                        {
                            cam.CamperId,
                            FirstNameCamper = cam.FirstName,
                            LastNameCamper = cam.LastName,
                            cab.Name,
                            nok.FirstName,
                            nok.LastName,
                            nok.PhoneNo
                        };
            if (query.ToList().Count == 0)
            {
                Console.WriteLine("No results found");
            }
            else
            {
                Console.WriteLine("CABIN:   ---      CAMPER NAME:     ---      NEXT OF KIN   ---    PHONE");
                foreach (var i in query)
                {
                    Console.WriteLine($"{i.Name}  ---  {i.FirstNameCamper} {i.LastNameCamper}  ---  {i.FirstName} {i.LastName} --- {i.PhoneNo}");
                }
            }

        }
        #endregion
        #region MenuMethods
        private static void Menu()
        {
            Console.WriteLine("Choose an option:\n");
            bool stop = true;
            do
            {
                MenuAlternativesMain();
                int input = MenuInputHandler3();
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        MenuAlternativesCamper();
                        break;
                    case 2:
                        Console.Clear();
                        MenuAlternativesCounselor();
                        break;
                    case 3:
                        Console.Clear();
                        MenuAlternativesCabin();
                        break;
                    case 4:
                        Console.Clear();
                        MenuAlternativesNextOfKin();
                        break;
                    case 5:
                        Console.Clear();
                        MenuAlternativesHistory();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("WARNING! Seeding more than once will double the amount of entries in the database");
                        Console.WriteLine("Continue? y/n");
                        string input2 = Console.ReadLine().ToLower();
                        if (input2 == "y")
                        {
                            Console.WriteLine("Seeding database...");
                            SeedAddData();
                            SeedPopulateCabins();
                            SeedAddNextOfKins();
                            Console.WriteLine("Success!");
                        }
                        else if (input2 == "n")
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Press any key to exit...");
                        stop = false;
                        break;
                }
            } while (stop == true);
        }
        private static void MenuAlternativesMain()
        {
            Console.WriteLine
                    ("-------------------------\n" +
                    "Camp Sleepaway\n" +
                    "-------------------------\n" +
                    "1. Campers\n" +
                    "2. Counselors\n" +
                    "3. Cabins\n" +
                    "4. Next of kins\n" +
                    "5. Show history\n" +
                    "6. Seed database\n" +
                    "7. Exit program\n" +
                    "-------------------------");
        }
        private static void MenuAlternativesCamper()
        {
            bool stop = true;
            do
            {
                Console.WriteLine
                    ("-------------------------\n" +
                    "Camp Sleepaway - Campers\n" + 
                    "-------------------------\n" +
                    "1. Show camper\n" +
                    "2. Update camper\n" +
                    "3. Insert new camper\n" +
                    "4. Remove camper\n" +
                    "5. Add camper to cabin\n" +
                    "6. Return\n" +
                    "-------------------------");
                int input = MenuInputHandler();
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        FindCamper();
                        break;
                    case 2:
                        Console.Clear();
                        UpdateCamper();
                        break;
                    case 3:
                        Console.Clear();
                        InsertCamper();
                        break;
                    case 4:
                        Console.Clear();
                        RemoveCamper();
                        break;
                    case 5:
                        Console.Clear();
                        AddCamperToCabin();
                        break;
                    case 6:
                        Console.Clear();
                        stop = false;
                        break;
                }
            } while (stop == true);
        }
        private static void MenuAlternativesCounselor()
        {
            bool stop = true;
            do
            {
                Console.WriteLine
                         ("-------------------------\n" +
                         "Camp Sleepaway - Counselors\n" + 
                         "-------------------------\n" +
                         "1. Show counselor\n" +
                         "2. Update counselor\n" +
                         "3. Insert new counselor\n" +
                         "4. Remove counselor\n" +
                         "5. Add counselor to cabin\n" +
                         "6. Return\n" +
                         "-------------------------");
                int input = MenuInputHandler();
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        FindCounselor();
                        break;
                    case 2:
                        Console.Clear();
                        UpdateCounselor();
                        break;
                    case 3:
                        Console.Clear();
                        InsertCounselor();
                        break;
                    case 4:
                        Console.Clear();
                        RemoveCounselor();
                        break;
                    case 5:
                        Console.Clear();
                        AddCounselorToCabin();
                        break;
                    case 6:
                        Console.Clear();
                        stop = false;
                        break;
                }
            } while (stop == true);
        }
        private static void MenuAlternativesCabin()
        {
            bool stop = true;
            do
            {
                Console.WriteLine
                         ("-------------------------\n" +
                         "Camp Sleepaway - Cabins\n" + 
                         "-------------------------\n" +
                         "1. Show cabin\n" +
                         "2. Update cabin\n" +
                         "3. Insert new cabin\n" +
                         "4. Return\n" +
                         "-------------------------");
                int input = MenuInputHandler2();
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        FindCabin();
                        break;
                    case 2:
                        Console.Clear();
                        UpdateCabin();
                        break;
                    case 3:
                        Console.Clear();
                        AddCabin();
                        break;
                    case 4:
                        Console.Clear();
                        stop = false;
                        break;
                }
            } while (stop == true);
        }
        private static void MenuAlternativesHistory()
        {
            bool stop = true;
            do
            {
                Console.WriteLine
                         ("-------------------------\n" +
                         "Camp Sleepaway - History\n" +
                         "-------------------------\n" +
                         "1. Show all cabins history\n" +
                         "2. Show campers in cabins\n" +
                         "3. Show campers next of kin\n" +
                         "4. Return\n" +
                         "-------------------------");
                int input = MenuInputHandler2();
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        ShowAllCabins();
                        break;
                    case 2:
                        Console.Clear();
                        FindCamperByCabin();
                        break;
                    case 3:
                        Console.Clear();
                        FindNextOfKinByCabin();
                        break;
                    case 4:
                        Console.Clear();
                        stop = false;
                        break;
                }
            } while (stop == true);
        }
        private static void MenuAlternativesNextOfKin()
        {
            bool stop = true;
            do
            {
                Console.WriteLine
                    ("-------------------------\n" +
                    "Camp Sleepaway - Next of kins\n" +
                    "-------------------------\n" +
                    "1. Show next of kin\n" +
                    "2. Update next of kin\n" +
                    "3. Insert new next of kin\n" +
                    "4. Remove next of kin\n" +
                    "5. Add next of kin to camper\n" +
                    "6. Return\n" +
                    "-------------------------");
                int input = MenuInputHandler();
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        FindNextOfKin();
                        break;
                    case 2:
                        Console.Clear();
                        UpdateNextOfKin();
                        break;
                    case 3:
                        Console.Clear();
                        InsertNextOfKin();
                        break;
                    case 4:
                        Console.Clear();
                        RemoveNextOfKin();
                        break;
                    case 5:
                        Console.Clear();
                        AddNextOfKinToCamper();
                        break;
                    case 6:
                        Console.Clear();
                        stop = false;
                        break;
                }
            } while (stop == true);
        }
        private static int MenuInputHandler()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 6)
            {
                Console.WriteLine("Invalid input, please try again...\n");
            }
            return input;
        }
        private static int MenuInputHandler2()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 4)
            {
                Console.WriteLine("Invalid input, please try again...\n");
            }
            return input;
        }
        private static int MenuInputHandler3()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 7)
            {
                Console.WriteLine("Invalid input, please try again...\n");
            }
            return input;
        }
        #endregion
    }
}
