using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A1Q1 obj1 = new A1Q1();
            //obj1.ShoppingCart();

            // A1Q2 obj2 = new A1Q2();
            //obj2.temp();

            //A1Q3 obj3 = new A1Q3();
            //obj3.atm();

            // A1Q4 obj4 = new A1Q4();
            //obj4.marksAverage();

            // A1Q5 obj5 = new A1Q5();
            //obj5.password();


            //A1Q6 obj6 = new A1Q6();
            //obj6.fareTaxiRide();

            // A1Q7 obj7 = new A1Q7();
            //obj7.attendance();

            // A1Q8 obj8 = new A1Q8();
            //obj8.expenses();

            A1Q9 obj9 = new A1Q9();
            obj9.shopping_Cart();

            //A1Q10 obj10 = new A1Q10();
            //obj10. monthlySalary();

        }

    }
        class A1Q1
        {
            int[] arr = { 1000, 150, 3000, 1000, 500 };
            public void ShoppingCart()
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                if(sum > 3000)
                {
                    Console.WriteLine((sum - (sum * 10) / 100));
                }
                else
                {
                    Console.WriteLine(sum);
                }

            }
        }


        class A1Q2
        {
            public void temp()
            {
                Console.Write("Enter Temperatute in celcious : ");
                double celsius = Convert.ToDouble(Console.Read());
                if (celsius > 0)
                {
                   Console.WriteLine((celsius* 9.0 / 5.0) + 32);
                }
                else
                {
                    Console.WriteLine("freezing temperatures");
                }
            }
        }

        class A1Q3
        {
            public void atm()
            {
                decimal balance = 1000.00m;
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("ATM Main Menu:");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Exit");
                    Console.Write("Select an option: ");

                    string option = Console.ReadLine();
                    Console.Clear();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine($"Your current balance is: ${balance:F2}");
                            break;

                        case "2":
                            Console.Write("Enter amount to deposit: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal deposit))
                            {
                                balance += deposit;
                                Console.WriteLine($"You have successfully deposited ${deposit:F2}. Your new balance is: ${balance:F2}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Please try again.");
                            }
                            break;

                        case "3":
                            Console.Write("Enter amount to withdraw: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawal))
                            {
                                if (withdrawal <= balance)
                                {
                                    balance -= withdrawal;
                                    Console.WriteLine($"You have successfully withdrawn ${withdrawal:F2}. Your new balance is: ${balance:F2}");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds. Please try again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Please try again.");
                            }
                            break;

                        case "4":
                            exit = true;
                            Console.WriteLine("Thank you for using the ATM. Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please select a valid option from the menu.");
                            break;
                    }

                    Console.WriteLine();
                }

            }
        }

        class A1Q4
        {
            public void marksAverage()
            {
                char grade;
                Console.WriteLine("Enter the length of array : ");

                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter the value at index " + i + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                int average = sum / n;
                

                if (average >= 90)
                {
                    grade = 'A';
                }   
                else if (average >= 80 && average < 90)
                {
                    grade = 'B';
                }
                else if (average >= 70 && average < 80)
                {
                    grade = 'C';
                }
                else if (average >= 60 && average < 70)
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'E';
                }
                    
                Console.WriteLine(grade);
            }
        }


        class A1Q5
        {
            public void password()
            {
                Console.WriteLine("Enter the Password: ");
                String password = Console.ReadLine();
                if (password.Any(char.IsUpper) &&
                     password.Any(char.IsLower) &&
                     password.Any(char.IsDigit) && (password.Length >= 8))
                {
                    Console.WriteLine("Valid Passworl");
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
            }
        }

        class A1Q6
        {
            public void fareTaxiRide()
            {
                const double flatRate = 20.0;
                const double perKilometerRate = 10.0;
                const double nightSurchargeRate = 1.5;


                Console.Write("Enter the distance traveled in kilometers: ");
                double distance = Convert.ToDouble(Console.ReadLine());


                Console.Write("Enter the time of the ride: ");
                int hour = Convert.ToInt32(Console.ReadLine());


                double fare;
                if (distance <= 2)
                {
                    fare = flatRate;
                }
                else
                {
                    fare = flatRate + (distance - 2) * perKilometerRate;
                }

                // 10 == 22
                if (hour >= 22)
                {
                    fare *= nightSurchargeRate;
                }

                Console.WriteLine($"The total fare for the ride is: Rs. {fare}");
            }
        }


        class A1Q7
        {
            public void attendance()
            {
                // attendance put in 1 or 0 fome
                int[] arr = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter the attendance of Day: "+ (i+1));
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if( arr[i] == 1)
                    {
                        count++;
                    }
                }

                if(count == arr.Length)
                {
                    Console.WriteLine("Perfect Attendance");
                }
                else
                {
                    Console.WriteLine("Your attendance is = "+ count);
                }
            }
        }

        class A1Q8 { 
            public void expenses()
            {
                string[] months = new string[12]
                {
                    "January", "February", "March", "April", "May", "June",
                    "July", "August", "September", "October", "November", "December"
                };


                double[] monthExpenses = new double[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter the month " + (i+1) + " expenses: ");
                    monthExpenses[i] = Convert.ToDouble(Console.ReadLine());
                }

                double total_expenses = 0;
                for (int i = 0; i < monthExpenses.Length; i++)
                {
                    total_expenses += monthExpenses[i];
                }

                Console.WriteLine("total expenses of the Year is: " + total_expenses);


                int max = 0;
                for (int i = 0; i < monthExpenses.Length; i++)
                {
                    if (monthExpenses[i] > max)
                    {
                        max = i;
                    }
                }

                Console.WriteLine("month highest expenses: " + max);

                int min = 0;
                for (int i = 1; i < monthExpenses.Length; i++)
                {
                    if (monthExpenses[i] <  min)
                    {
                        min = i;
                    }
                }

                Console.WriteLine("month lowest expenses: " + min);
//                Console.WriteLine("Highest expenses in month: " + months[max] + " lowest expenses is month:  " + months[min]);

            }
        }

        class A1Q9
        {
            public void shopping_Cart()
            {
                string itemName1 = null, itemName2 = null, itemName3 = null;
                decimal itemPrice1 = 0m, itemPrice2 = 0m, itemPrice3 = 0m;
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("Shopping Cart Menu:");
                    Console.WriteLine("1. Add Item");
                    Console.WriteLine("2. Remove Item");
                    Console.WriteLine("3. View Total Price");
                    Console.WriteLine("4. Exit");
                    Console.Write("Select an option: ");

                    string option = Console.ReadLine();
                    Console.Clear();

                    if (option == "1")
                    {
                        if (itemName1 == null)
                        {
                            Console.Write("Enter item name: ");
                            itemName1 = Console.ReadLine();
                            Console.Write("Enter item price: ");
                            if (decimal.TryParse(Console.ReadLine(), out itemPrice1))
                            {
                                Console.WriteLine($"Added {itemName1} to the cart with price ${itemPrice1:F2}.");
                            }
                        }
                        else if (itemName2 == null)
                        {
                            Console.Write("Enter item name: ");
                            itemName2 = Console.ReadLine();
                            Console.Write("Enter item price: ");
                            if (decimal.TryParse(Console.ReadLine(), out itemPrice2))
                            {
                                Console.WriteLine($"Added {itemName2} to the cart with price ${itemPrice2:F2}.");
                            }
                        }
                        else if (itemName3 == null)
                        {
                            Console.Write("Enter item name: ");
                            itemName3 = Console.ReadLine();
                            Console.Write("Enter item price: ");
                            if (decimal.TryParse(Console.ReadLine(), out itemPrice3))
                            {
                                Console.WriteLine($"Added {itemName3} to the cart with price ${itemPrice3:F2}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cart is full. Remove an item before adding another.");
                        }
                    }
                    else if (option == "2")
                    {
                        Console.Write("Enter item name to remove: ");
                        string removeItemName = Console.ReadLine();

                        if (removeItemName == itemName1)
                        {
                            itemName1 = null;
                            itemPrice1 = 0m;
                            Console.WriteLine($"Removed {removeItemName} from the cart.");
                        }
                        else if (removeItemName == itemName2)
                        {
                            itemName2 = null;
                            itemPrice2 = 0m;
                            Console.WriteLine($"Removed {removeItemName} from the cart.");
                        }
                        else if (removeItemName == itemName3)
                        {
                            itemName3 = null;
                            itemPrice3 = 0m;
                            Console.WriteLine($"Removed {removeItemName} from the cart.");
                        }
                        else
                        {
                            Console.WriteLine("Item not found in the cart.");
                        }
                    }
                    else if (option == "3")
                    {
                        decimal totalPrice = itemPrice1 + itemPrice2 + itemPrice3;

                        Console.WriteLine("Items in your cart:");
                        if (itemName1 != null) Console.WriteLine($"- {itemName1}: ${itemPrice1:F2}");
                        if (itemName2 != null) Console.WriteLine($"- {itemName2}: ${itemPrice2:F2}");
                        if (itemName3 != null) Console.WriteLine($"- {itemName3}: ${itemPrice3:F2}");

                        Console.WriteLine($"Total Price: ${totalPrice:F2}");
                    }
                    else if (option == "4")
                    {
                        exit = true;
                        Console.WriteLine("Thank you for shopping with us. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please select a valid option from the menu.");
                    }

                    Console.WriteLine(); // Blank line for spacing
                }
            }
        }
 

        class A1Q10
        {
            public void monthlySalary()
            {
                Console.Write("Enter the hourly wage: ");
                decimal hourlyWage = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the number of hours worked in a week: ");
                int hoursPerWeek = Convert.ToInt32(Console.ReadLine());

                decimal weeklySalary = hourlyWage * hoursPerWeek;

                decimal monthlySalary = weeklySalary * 4;

                Console.WriteLine($"\nThe monthly salary is: {monthlySalary:C}");
            }
        }
}
