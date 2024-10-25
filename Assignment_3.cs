using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Bank Account Management");
                Console.WriteLine("2. Student Grade Calculation");
                Console.WriteLine("3. Temperature Conversion");
                Console.WriteLine("4. Employee Management");
                Console.WriteLine("5. Simple Calculator");
                Console.WriteLine("6. Library Management");
                Console.WriteLine("7. Prime Number Checker");
                Console.WriteLine("8. Car Rental System");
                Console.WriteLine("9. E-commerce Order Management");
                Console.WriteLine("10. Movie Ticket Booking");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BankAccountManagement();
                        break;
                    case "2":
                        StudentGradeCalculation();
                        break;
                    case "3":
                        TemperatureConversion();
                        break;
                    case "4":
                        EmployeeManagement();
                        break;
                    case "5":
                        SimpleCalculator();
                        break;
                    case "6":
                        LibraryManagement();
                        break;
                    case "7":
                        PrimeNumberCheck();
                        break;
                    case "8":
                        CarRentalSystem();
                        break;
                    case "9":
                        ECommerceOrderManagement();
                        break;
                    case "10":
                        MovieTicketBooking();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void BankAccountManagement()
        {
            var account = new BankAccount("John Doe", 1000m);
            account.Deposit(500);
            account.Withdraw(300);
            account.DisplayBalance();
        }

        static void StudentGradeCalculation()
        {
            GradeCalculator.Main(null);
        }

        static void TemperatureConversion()
        {
            var converter = new TemperatureConverter();
            converter.Convert();
        }

        static void EmployeeManagement()
        {
            try
            {
                var employee = new Employee("Alice", 30, "IT", 50000m);
                employee.DisplayEmployeeInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SimpleCalculator()
        {
            Calculator.Main(null);
        }

        static void LibraryManagement()
        {
            var book = new Book { Title = "C# Programming", Author = "John Smith", ISBN = "1234567890", CopiesAvailable = 5 };
            book.IssueBook();
            book.ReturnBook();
        }

        static void PrimeNumberCheck()
        {
            PrimeChecker.Main(null);
        }

        static void CarRentalSystem()
        {
            var car = new Car { Model = "Toyota", DailyRate = 100, IsAvailable = true };
            car.RentCar(5);
        }

        static void ECommerceOrderManagement()
        {
            var order = new Order(1, "John", 150);
            order.DisplayOrderDetails();
            order.UpdateOrderStatus("Shipped");
            order.DisplayOrderDetails();
        }

        static void MovieTicketBooking()
        {
            var ticket = new MovieTicket { MovieName = "Inception", ShowTime = DateTime.Now.AddHours(3), SeatNumber = 12, TicketPrice = 120 };
            ticket.BookTicket();
        }
    }



    public class BankAccount
    {
        public string AccountHolder { get; set; }
        private decimal Balance { get; set; }

        public BankAccount(string accountHolder, decimal initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposit successful! New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawal successful! New Balance: {Balance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance:C}");
        }
    }


    /// <summary>
    /// ////////////////////////////////////////////////
    /// </summary>

 

public class GradeCalculator
    {
        public static void Main(string[] args)
        {
            int[] marks = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks for subject {i + 1} (0-100): ");
                while (!int.TryParse(Console.ReadLine(), out marks[i]) || marks[i] < 0 || marks[i] > 100)
                {
                    Console.WriteLine("Invalid input. Please enter marks between 0 and 100.");
                }
                sum += marks[i];
            }

            double average = sum / 5.0;
            char grade;

            if (average >= 90)
                grade = 'A';
            else if (average >= 80)
                grade = 'B';
            else if (average >= 70)
                grade = 'C';
            else if (average >= 60)
                grade = 'D';
            else
                grade = 'F';

            Console.WriteLine($"Average Marks: {average}, Grade: {grade}");
        }
    }

    ////////////////////////////////////
    ///



public class TemperatureConverter
    {
        public double Celsius { get; set; }
        public double Fahrenheit => (Celsius * 9 / 5) + 32;

        public double ConvertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public void Convert()
        {
            char choice;
            do
            {
                Console.WriteLine("Choose Conversion: (1) Celsius to Fahrenheit, (2) Fahrenheit to Celsius");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write("Enter Celsius: ");
                    Celsius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Fahrenheit: {Fahrenheit}");
                }
                else if (option == 2)
                {
                    Console.Write("Enter Fahrenheit: ");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Celsius: {ConvertToCelsius(fahrenheit)}");
                }

                Console.WriteLine("Do you want another conversion? (y/n)");
                choice = char.Parse(Console.ReadLine());
            } while (choice == 'y');
        }
    }




    ///////////////////////////////////////////////
    ///


    public class Employee
    {
        public string Name { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
                else
                    throw new Exception("Age must be positive.");
            }
        }
        public string Department { get; set; }
        private decimal Salary { get; set; }

        private int _age;

        public Employee(string name, int age, string department, decimal salary)
        {
            Name = name;
            Age = age;
            Department = department;
            Salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }





    ///////////////////////
    ///


public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Select operation (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());

            try
            {
                double v = operation switch
                {
                    '+' => num1 + num2,
                    '-' => num1 - num2,
                    '*' => num1 * num2,
                    '/' when num2 != 0 => num1 / num2,
                    '/' => throw new DivideByZeroException(),
                    _ => throw new InvalidOperationException("Invalid operation")
                };
                double result = v;

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    //////////////////////////////////////////
    ///

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }

        public void IssueBook()
        {
            if (CopiesAvailable > 0)
            {
                CopiesAvailable--;
                Console.WriteLine("Book issued successfully.");
            }
            else
            {
                Console.WriteLine("No copies available.");
            }
        }

        public void ReturnBook()
        {
            CopiesAvailable++;
            Console.WriteLine("Book returned successfully.");
        }
    }


    /////////////////////////////////////
    ///


    public class PrimeChecker
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive integer.");
            }

            bool isPrime = true;
            if (number == 1)
                isPrime = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPrime ? "The number is prime." : "The number is not prime.");
        }
    }



    //////////////////////////////////////////
    ///



    public class Car
    {
        public string Model { get; set; }
        public decimal DailyRate { get; set; }
        public bool IsAvailable { get; set; }

        public void RentCar(int days)
        {
            if (IsAvailable)
            {
                decimal totalCost = DailyRate * days;
                IsAvailable = false;
                Console.WriteLine($"Car rented successfully. Total cost: {totalCost:C}");
            }
            else
            {
                Console.WriteLine("Car is not available for rent.");
            }
        }
    }


    /////////////////////////////////////////////
    ///




    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public string OrderStatus { get; private set; }

        public Order(int orderId, string customerName, decimal amount)
        {
            OrderID = orderId;
            CustomerName = customerName;
            Amount = amount;
            OrderStatus = "Placed";
        }

        public void UpdateOrderStatus(string newStatus)
        {
            OrderStatus = newStatus;
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderID}, Customer: {CustomerName}, Amount: {Amount:C}, Status: {OrderStatus}");
        }
    }





    ///////////////////////////////////////////
    ///

    public class MovieTicket
    {
        public string MovieName { get; set; }
        public DateTime ShowTime { get; set; }
        public int SeatNumber { get; set; }
        public decimal TicketPrice { get; set; }
        public bool IsBooked { get; private set; }

        public void BookTicket()
        {
            if (!IsBooked)
            {
                IsBooked = true;
                decimal finalPrice = TicketPrice > 100 ? TicketPrice * 0.9m : TicketPrice;
                Console.WriteLine($"Ticket booked successfully. Final Price: {finalPrice:C}");
            }
            else
            {
                Console.WriteLine("Seat already booked.");
            }
        }
    }


}


