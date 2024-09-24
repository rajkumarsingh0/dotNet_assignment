using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Question number = ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Enter your name: ");
                    String name = Console.ReadLine();

                    Console.WriteLine("Enter your age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your name: ");
                    int salary = Convert.ToInt32(Console.ReadLine());

                    Employee obj = new Employee(name, age, salary);
                    obj.employee_Detail();

                    break;

                case 2:
                    BankAccount account = new BankAccount(123456, "John Doe", 5000);                    
                    account.AccountDetail();                  
                    account.Deposit(1000);                   
                    account.Withdrawal(2000);                 
                    account.AccountDetail();
                    break;

                case 3:
                    int[] arr = {1, 2, 3 , 4 ,5};
                    MathHelper.average(arr);
                    break;

                case 4:
                    Logger.logMassage(Console.ReadLine());
                    break;

                case 5:
                    Person obj5 = new Person();
                    obj5.FirstName = "Ram";
                    obj5.LastName = "Sharma";
                    obj5.DisplayFullName();
                    break;

                case 6:
                    Console.WriteLine("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Salary: ");
                    int salary = Convert.ToInt32(Console.ReadLine());
                  
                    Employee6 employee = new Employee6(name, age, salary);                    
                    employee.CalculatingSalary(10);
                    break;

                case 7:
                    Shape obj7 = new Circle(5);
                    obj7.calculateArea();
                    Shape obj7_2 = new Rectangle(5, 5);
                    obj7_2.calculateArea();
                    break;

                case 8:
                    Animal obj8 = new Dog();
                    obj8.age();
                    obj8.name();
                    

                    Animal obj8_2 = new Cat();
                    obj8_2.age();
                    obj8_2.name();
                    break;

                case 9:
                    Vehicle obj9 = new Car();
                    obj9.StartEngine();
                    obj9.StopEngine();

                    break;

                case 10:
                    SavingsAccount mySavings = new SavingsAccount("SA123456", 1000, 5);
                    mySavings.DisplayAccountInfo();
                    mySavings.Deposit(500);
                    mySavings.Withdraw(200); 
                    mySavings.CalculateInterest();
                    mySavings.AddInterest(); 
                    mySavings.DisplayAccountInfo(); 

                    break;

                default: Console.WriteLine("Question does not found");
                    break;
            }


            Console.ReadLine();

        }
    }


    class Employee
    {
        String name;
        int age;
        int salary;

        public Employee(String name, int age, int salary) {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void employee_Detail()
        {
            Console.WriteLine($"Employee name is {name} and its age is {age} and the salary is {salary}");
        }
    }

    class BankAccount
    {       
        private int account_no;
        private string account_Holder;
        private int balance;        
        public BankAccount(int account_no, string account_Holder, int balance)
        {
            this.account_no = account_no;
            this.account_Holder = account_Holder;
            this.balance = balance;
        }        
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{amount} deposited successfully. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }      
        public void Withdrawal(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully. Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }      
        public void AccountDetail()
        {
            Console.WriteLine($"Account Number: {account_no}");
            Console.WriteLine($"Account Holder: {account_Holder}");
            Console.WriteLine($"Balance: {balance}");
        }
    }




    //static class

    public static class MathHelper
    {
        public static void average(int[] arr)
        {
            int count = arr.Length;
            int sum = 0;
            for (int i = 0; i < count; i++) { 
                sum = sum + arr[i];
            }

            Console.WriteLine(sum / count);
        }
    }

    public static class Logger
    {
        public static void logMassage(String message)
        {
            Console.WriteLine($"{message}");
        }
    }



    // partial class 

    public partial class Person
    {
        public string FirstName;
        public string LastName;
    }

    public partial class Person
    {
        public void DisplayFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }


    /////////////////////////////////////////////////////


    
    public partial class Employee6
    {
        public string Name;
        public int Age;
        public int Salary;
        
        public Employee6(string name, int age, int salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }
    }


    public partial class Employee6
    {
        public void CalculatingSalary(double bonusPercentage)
        {
            double bonus = Salary * (bonusPercentage / 100);
            double totalSalary = Salary + bonus;
            Console.WriteLine($"Total Salary after applying a bonus of {bonusPercentage}%: {totalSalary}");
        }
    }




    // Abstract Class

    public abstract class Shape
    {
        public abstract void calculateArea();
    }

    public class Circle: Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void calculateArea()
        {
            Console.WriteLine(Math.PI* Math.Pow(radius, 2));
        }

    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override void calculateArea()
        {
            Console.WriteLine(length * width);
        }

    }


   // ====================SECOND========================

    public abstract class Animal
    {
        public abstract void name();
        public abstract void age();

        internal void MakeSound()
        {
            throw new NotImplementedException();
        }
    }

    public class Dog : Animal
    {
        public override void age()
        {
            Console.WriteLine("5 year");
        }

        public override void name()
        {
            Console.WriteLine("Dog");
        }
        public void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    public class Cat : Animal
    {
        public override void age()
        {
            Console.WriteLine("3 year");
        }

        public override void name()
        {
            Console.WriteLine("Cat");
        }

        public void MakeSound() => Console.WriteLine("Meow!");

    }



    //===================== Sealed Class ===================//

    public class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine is Starting.....");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine is Stoping.....");
        }
    }

    public sealed class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Engine is Starting!!.....");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Engine is Stoping!!.....");
        }
    }

    //========Second =================


    public class BankAccount
    {
        public string AccountNumber;
        public double Balance;

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }        
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
        }
    }


    public sealed class SavingsAccount : BankAccount
    {
        public double InterestRate;

        
        public SavingsAccount(string accountNumber, double initialBalance, double interestRate)
            : base(accountNumber, initialBalance)
        {
            InterestRate = interestRate;
        }

        
        public void CalculateInterest()
        {
            double interest = Balance * (InterestRate / 100);
            Console.WriteLine($"Interest amount: {interest}");
        }

        public void AddInterest()
        {
            double interest = Balance * (InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"Added {interest} interest. New Balance: {Balance}");
        }
    }

}
