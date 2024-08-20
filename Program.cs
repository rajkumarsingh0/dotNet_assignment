using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Not_consider_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A1Q1.FinancialCalculator();
            A1Q2.AnalyticsTool();
            A1Q3.InventoryManagement();
            A1Q4.SurveyReport();
            A1Q5.AppFeature();
            A1Q6.SimulationTool();
            A1Q7.LibrarySystem();
            A1Q8.AcademicProject();
            A1Q9.DataCleanup();
            A1Q10.AnalyticsApplication();
        }
    }

    class A1Q1
    {
        public static void FinancialCalculator()
        {
            int[] transactions = { 200, -150, 340, 500, -100 };
            int sum = 0;

            foreach (int transaction in transactions)
            {
                sum += transaction;
            }

            Console.WriteLine("Total sum of all transactions: " + sum);
        }
    }

    class A1Q2
    {
        public static void AnalyticsTool()
        {
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0;

            foreach (float score in scores)
            {
                sum += score;
            }

            float average = sum / scores.Length;
            Console.WriteLine("Average score: " + average);
        }
    }

    class A1Q3
    {
        public static void InventoryManagement()
        {
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int maxPrice = prices[0];

            foreach (int price in prices)
            {
                if (price > maxPrice)
                {
                    maxPrice = price;
                }
            }

            Console.WriteLine("Most expensive item price: " + maxPrice);
        }
    }

    class A1Q4
    {
        public static void SurveyReport()
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int maleCount = 0, femaleCount = 0;

            foreach (int code in participantCodes)
            {
                if (code % 2 == 0)
                {
                    maleCount++;
                }
                else
                {
                    femaleCount++;
                }
            }

            Console.WriteLine("Number of males: " + maleCount);
            Console.WriteLine("Number of females: " + femaleCount);
        }
    }

    class A1Q5
    {
        public static void AppFeature()
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };

            Console.WriteLine("Search history in reverse order:");
            for (int i = searchHistory.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(searchHistory[i]);
            }
        }
    }

    class A1Q6
    {
        public static void SimulationTool()
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;

            Console.WriteLine("Measurements after adjustment:");
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] *= factor;
                Console.WriteLine(measurements[i]);
            }
        }
    }

    class A1Q7
    {
        public static void LibrarySystem()
        {
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            int index = -1;

            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (bookCodes[i] == searchCode)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine("Book code " + searchCode + " found at index: " + index);
            }
            else
            {
                Console.WriteLine("Book code not found.");
            }
        }
    }

    class A1Q8
    {
        public static void AcademicProject()
        {
            int[] grades = { 56, 78, 89, 45, 67 };
            Array.Sort(grades);
            int secondSmallest = grades[1];  // Second element after sorting

            Console.WriteLine("Second smallest grade: " + secondSmallest);
        }
    }

    class A1Q9
    {
        public static void DataCleanup()
        {
            int[] ids = { 102, 215, 102, 324, 215 };
            HashSet<int> uniqueIds = new HashSet<int>();

            foreach (int id in ids)
            {
                uniqueIds.Add(id);
            }

            Console.WriteLine("Unique IDs:");
            foreach (int id in uniqueIds)
            {
                Console.WriteLine(id);
            }
        }
    }

    class A1Q10
    {
        public static void AnalyticsApplication()
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };
            List<int> commonElements = new List<int>();

            foreach (int element1 in dataset1)
            {
                foreach (int element2 in dataset2)
                {
                    if (element1 == element2)
                    {
                        if (!commonElements.Contains(element1))
                        {
                            commonElements.Add(element1);
                        }
                    }
                }
            }

            Console.WriteLine("Common elements:");
            foreach (int element in commonElements)
            {
                Console.WriteLine(element);
            }
        }
    }

}
