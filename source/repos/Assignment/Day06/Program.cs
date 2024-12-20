namespace Day06
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    enum Season
    {
        Spring,
        Summer,
        Autumn=2,
        Winter,
        Fall=2
    }

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }


    enum Colors
    {
        Red,
        Green,
        Blue
    }

    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    struct Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, OOP 01 !");

            #region Quest 1
            //Console.WriteLine("Days of the week:");

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //} 
            #endregion

            #region Quest 2
            //Person[] people = new Person[3];

            //people[0] = new Person { Name = "Alice", Age = 25 };
            //people[1] = new Person { Name = "Bob", Age = 30 };
            //people[2] = new Person { Name = "Charlie", Age = 35 };

            //// Display the details of all persons
            //Console.WriteLine("Details of all persons:");
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}
            #endregion

            #region Quest 3
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");

            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season selectedSeason))
            //{
            //    // Display the month range based on the season
            //    switch (selectedSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter one of the following: Spring, Summer, Autumn, Winter.");
            //}

            #endregion

            #region Quest 4
            //Permissions userPermissions = Permissions.None;

            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;
            //Console.WriteLine($"Permissions after adding Read and Write: {userPermissions}");

            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Permissions after removing Write: {userPermissions}");

            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read permission exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Read permission does not exist.");
            //}

            //if ((userPermissions & Permissions.Execute) == Permissions.Execute)
            //{
            //    Console.WriteLine("Execute permission exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Execute permission does not exist.");
            //}
            #endregion

            #region Quest 5
            //Console.WriteLine("Enter a color name (Red, Green, Blue):");

            //string input = Console.ReadLine();


            //if (Enum.TryParse(input, true, out Colors selectedColor))
            //{
            //    // Check if the color is a primary color
            //    switch (selectedColor)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{selectedColor} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{selectedColor} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter one of the following: Red, Green, Blue.");
            //}


            #endregion

            #region Quest 6
            //Console.WriteLine("Enter the coordinates for the first point (X Y):");
            //string[] input1 = Console.ReadLine().Split(' ');
            //Point point1 = new Point
            //{
            //    X = double.Parse(input1[0]),
            //    Y = double.Parse(input1[1])
            //};
            //Console.WriteLine("Enter the coordinates for the second point (X Y):");


            //string[] input2 = Console.ReadLine().Split(' ');


            //Point point2 = new Point
            //{
            //    X = double.Parse(input2[0]),
            //    Y = double.Parse(input2[1])
            //};

            //double distance = CalculateDistance(point1, point2);


            //Console.WriteLine($"The distance between the two points is: {distance:F2}");


            #endregion

            #region Quest 7
            //Person2[] persons = new Person2[3];

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    persons[i].Name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    while (!int.TryParse(Console.ReadLine(), out persons[i].Age) || persons[i].Age < 0)
            //    {
            //        Console.Write("Please enter a valid age: ");
            //    }
            //}
            //#endregion
            //Person2 oldestPerson = persons[0];
            //for (int i = 1; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = persons[i];
            //    }
            //}

            //Console.WriteLine($"\nThe oldest person is {oldestPerson.Name}, who is {oldestPerson.Age} years old.");

        }
        static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

    }
}
