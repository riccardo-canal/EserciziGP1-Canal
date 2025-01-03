namespace Enum__Struct_e_Cast
{
    internal class EnumStructCastFunctions
    {
        // Esercizio 1: Creare un enum per rappresentare i giorni della settimana e iterare sui valori.
        public enum WeekDays
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        public static void IterateWeekDays()
        {
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
        }

        // Esercizio 2: Dichiarare un enum per rappresentare i livelli di priorità di un task.
        public enum TaskPriority
        {
            Low = 1, Medium = 2, High = 3
        }

        public static void ShowTaskPriority()
        {
            TaskPriority priority = TaskPriority.Medium;
            Console.WriteLine($"Task Priority: {priority}");
        }

        // Esercizio 3: Usare un enum per selezionare un'opzione in uno switch-case.
        public enum Options
        {
            Start, Stop, Pause, Resume
        }

        public static void SwitchCaseEnum()
        {
            Options option = Options.Start;
            switch (option)
            {
                case Options.Start:
                    Console.WriteLine("Starting...");
                    break;
                case Options.Stop:
                    Console.WriteLine("Stopping...");
                    break;
                case Options.Pause:
                    Console.WriteLine("Paused.");
                    break;
                case Options.Resume:
                    Console.WriteLine("Resumed.");
                    break;
                default:
                    Console.WriteLine("Unknown option.");
                    break;
            }
        }

        // Esercizio 4: Dichiarare una struct per rappresentare un punto 2D e calcolare la distanza tra due punti.
        public struct Point2D
        {
            public int X, Y;

            public Point2D(int x, int y)
            {
                X = x;
                Y = y;
            }

            public double CalculateDistance(Point2D otherPoint)
            {
                return Math.Sqrt(Math.Pow(otherPoint.X - X, 2) + Math.Pow(otherPoint.Y - Y, 2));
            }
        }

        public static void CalculateDistance()
        {
            Point2D point1 = new Point2D(3, 4);
            Point2D point2 = new Point2D(7, 1);
            double distance = point1.CalculateDistance(point2);
            Console.WriteLine($"Distance: {distance}");
        }

        // Esercizio 5: Creare una struct per rappresentare un rettangolo e calcolarne l'area.
        public struct Rectangle
        {
            public int Width, Height;

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public int Area()
            {
                return Width * Height;
            }
        }

        public static void CalculateRectangleArea()
        {
            Rectangle rect = new Rectangle(5, 10);
            Console.WriteLine($"Rectangle Area: {rect.Area()}");
        }

        // Esercizio 6: Utilizzare un enum per rappresentare i tipi di un veicolo in un programma.
        public enum VehicleType
        {
            Car, Truck, Motorcycle, Bicycle
        }

        public static void VehicleTypeExample()
        {
            VehicleType vehicle = VehicleType.Car;
            Console.WriteLine($"Selected vehicle: {vehicle}");
        }

        // Esercizio 7: Dichiarare una struct con un costruttore e un metodo.
        public struct Circle
        {
            public double Radius;

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public static void CalculateCircleArea()
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
        }

        // Esercizio 8: Scrivere un programma che converte un valore int in un enum usando il casting.
        public enum ErrorCodes
        {
            NotFound = 404,
            Unauthorized = 401,
            InternalServerError = 500
        }

        public static void ConvertIntToEnum()
        {
            int errorCode = 404;
            ErrorCodes error = (ErrorCodes)errorCode;
            Console.WriteLine($"Error code {errorCode} corresponds to: {error}");
        }

        // Esercizio 9: Dichiarare un enum con valori personalizzati e verificarne l'uso.
        public enum Status
        {
            Pending = 1,
            InProgress = 2,
            Completed = 10,
            Cancelled = -1
        }

        public static void CustomEnumValues()
        {
            Status status = Status.Completed;
            Console.WriteLine($"Task Status: {status} with value {(int)status}");
        }

        // Esercizio 10: Creare una struct per rappresentare un colore in formato RGB.
        public struct ColorRGB
        {
            public int Red, Green, Blue;

            public ColorRGB(int red, int green, int blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }

            public void DisplayColor()
            {
                Console.WriteLine($"RGB Color: ({Red}, {Green}, {Blue})");
            }
        }

        public static void DisplayColorExample()
        {
            ColorRGB color = new ColorRGB(255, 0, 0);
            color.DisplayColor();
        }

        // Esercizio 11: Utilizzare un enum in una funzione per selezionare un'opzione.
        public enum Operation
        {
            Add, Subtract, Multiply, Divide
        }

        public static void SelectOperation(Operation op)
        {
            switch (op)
            {
                case Operation.Add:
                    Console.WriteLine("Performing Addition.");
                    break;
                case Operation.Subtract:
                    Console.WriteLine("Performing Subtraction.");
                    break;
                case Operation.Multiply:
                    Console.WriteLine("Performing Multiplication.");
                    break;
                case Operation.Divide:
                    Console.WriteLine("Performing Division.");
                    break;
            }
        }

        public static void SelectOperationExample()
        {
            SelectOperation(Operation.Multiply);
        }

        // Esercizio 12: Dichiarare una struct con proprietà readonly.
        public struct ImmutablePoint
        {
            public readonly int X, Y;

            public ImmutablePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public static void ReadOnlyStructExample()
        {
            ImmutablePoint point = new ImmutablePoint(10, 20);
            Console.WriteLine($"Immutable Point: ({point.X}, {point.Y})");
        }

        // Esercizio 13: Creare un enum per rappresentare i mesi dell'anno.
        public enum Month
        {
            January = 1, February, March, April, May, June, July, August, September, October, November, December
        }

        public static void DisplayMonth()
        {
            Month month = Month.March;
            Console.WriteLine($"Selected Month: {month}");
        }

        // Esercizio 14: Dichiarare una struct per rappresentare una persona con nome e età.
        public struct Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        public static void CreatePerson()
        {
            Person person = new Person("John", 30);
            Console.WriteLine($"Person: {person.Name}, Age: {person.Age}");
        }

        // Esercizio 15: Scrivere un programma che utilizza il casting esplicito tra tipi numerici.
        public static void ExplicitCastingExample()
        {
            double number = 9.8;
            int integerNumber = (int)number;
            Console.WriteLine($"Cast from double to int: {integerNumber}");
        }

        // Esercizio 16: Dichiarare un enum per rappresentare i tipi di errore di un'app.
        public enum AppError
        {
            None = 0, NotFound = 1, Unauthorized = 2, ServerError = 3
        }

        public static void AppErrorExample()
        {
            AppError error = AppError.ServerError;
            Console.WriteLine($"App Error: {error}");
        }

        // Esercizio 17: Creare una struct per rappresentare una posizione 3D e calcolarne la distanza.
        public struct Point3D
        {
            public int X, Y, Z;

            public Point3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public double CalculateDistance(Point3D other)
            {
                return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2) + Math.Pow(other.Z - Z, 2));
            }
        }

        public static void Calculate3DDistance()
        {
            Point3D point1 = new Point3D(1, 2, 3);
            Point3D point2 = new Point3D(4, 5, 6);
            double distance = point1.CalculateDistance(point2);
            Console.WriteLine($"3D Distance: {distance}");
        }

        // Esercizio 18: Utilizzare un enum per definire i tipi di permesso di un'app.
        public enum Permission
        {
            Admin, User, Guest
        }

        public static void PermissionExample()
        {
            Permission userPermission = Permission.Admin;
            Console.WriteLine($"User Permission: {userPermission}");
        }

        // Esercizio 19: Dichiarare una struct per rappresentare una data personalizzata.
        public struct CustomDate
        {
            public int Day, Month, Year;

            public CustomDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public void DisplayDate()
            {
                Console.WriteLine($"Custom Date: {Day}/{Month}/{Year}");
            }
        }

        public static void DisplayCustomDate()
        {
            CustomDate date = new CustomDate(10, 5, 2025);
            date.DisplayDate();
        }

        // Esercizio 20: Creare una struct per rappresentare una carta da gioco (valore e seme).
        public struct PlayingCard
        {
            public string Suit;
            public string Value;

            public PlayingCard(string suit, string value)
            {
                Suit = suit;
                Value = value;
            }

            public void DisplayCard()
            {
                Console.WriteLine($"Card: {Value} of {Suit}");
            }
        }

        public static void DisplayPlayingCard()
        {
            PlayingCard card = new PlayingCard("Hearts", "Ace");
            card.DisplayCard();
        }

        // Esercizio 21: Utilizzare un enum in un'istruzione condizionale.
        public static void ConditionalEnum()
        {
            AppError error = AppError.Unauthorized;
            if (error == AppError.Unauthorized)
            {
                Console.WriteLine("Unauthorized access!");
            }
        }

        // Esercizio 22: Dichiarare una struct che contiene un array come proprietà.
        public struct Container
        {
            public int[] Numbers;

            public Container(int[] numbers)
            {
                Numbers = numbers;
            }
        }

        public static void ContainerExample()
        {
            Container container = new Container([1, 2, 3, 4]);
            Console.WriteLine($"Container numbers: {string.Join(", ", container.Numbers)}");
        }

        // Esercizio 23: Scrivere un programma che converte un valore double in float usando il casting esplicito.
        public static void DoubleToFloatCasting()
        {
            double value = 9.87654321;
            float floatValue = (float)value;
            Console.WriteLine($"Cast from double to float: {floatValue}");
        }

        // Esercizio 24: Utilizzare un enum per rappresentare i tipi di file supportati da un'app.
        public enum FileType
        {
            Text, Image, Video, Audio
        }

        public static void FileTypeExample()
        {
            FileType file = FileType.Image;
            Console.WriteLine($"Selected file type: {file}");
        }

        // Esercizio 25: Creare una struct per rappresentare un vettore e calcolare il prodotto scalare.
        public struct Vector
        {
            public int X, Y, Z;

            public Vector(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public int DotProduct(Vector other)
            {
                return X * other.X + Y * other.Y + Z * other.Z;
            }
        }

        public static void VectorDotProduct()
        {
            Vector vector1 = new Vector(1, 2, 3);
            Vector vector2 = new Vector(4, 5, 6);
            int dotProduct = vector1.DotProduct(vector2);
            Console.WriteLine($"Dot product of the vectors: {dotProduct}");
        }
    }
}
