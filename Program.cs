using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = "y";
            while (yesNo == "y")
            {
                Console.Clear();
                List<List<string>> studentInfo = EnterData(); //Fill 
                int whichStudent = GetInput("Which student? (Enter a number between 1 and 6): ", "That student doesn't exist!. Please enter a valid student number. ", 1, 6);
                List <string> selected = SelectStudent(studentInfo, whichStudent);
                int whatData = GetInput("What would you like to know? Type 1 for name, 2 for hometown, or 3 for favorite food, or 4 for full info: ", "Please enter 1,2,3 or 4: ", 1, 4);
                if (whatData == 4)
                {
                    foreach (string i in selected)
                    {
                        Console.Write(i + "\t ");
                    }
                }
                else
                {
                    Console.WriteLine(selected[(whatData - 1)]);
                }
                yesNo = ynInput();
            }

        }
        public static List<List<string>> EnterData()
        {
            List<List<string>> studentInfo = new List<List<string>>();
//                studentInfo.Add(new List<string> { a, b, c, d });
            studentInfo.Add(new List<string> { "Tori", "Marne, MI", "Chocolate" });
            studentInfo.Add(new List<string> { "Megan", "Lansing, MI", "Salad" });
            studentInfo.Add(new List<string> { "Steph", "Highland", "Seafood" });
            studentInfo.Add(new List<string> { "Jillane", "Rockford", "Sushi" });
            studentInfo.Add(new List<string> { "JJ", "Lake Orion, MI", "Strawberries" });
            studentInfo.Add(new List<string> { "Tommy", "Raleigh, NC AKA Rough Raleigh", "Chicken Curry" });
            return studentInfo;
        }
        public static List<string> SelectStudent(List<List<string>> info, int selectNum)
        {
            List<string> attributes = info[(selectNum-1)];
            return attributes;
        }
        public static int GetInput(string question, string error, int bottomNum, int topNum)
        {
            bool validInput = false;
            int exitNum = 0;
            while (!validInput)
            {
                Console.Write(question);
                bool inp = int.TryParse(Console.ReadLine(), out exitNum);
                if (!inp || exitNum < bottomNum || exitNum > topNum)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    validInput = true;
                }
            }
            return exitNum;
        }
        public static string ynInput()
        // Gets a y or n.
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                Console.Write("\n\nMore student info? (y/n): ");
                input = Console.ReadLine();
                input = input.ToLower();
                if (input == "y" || input == "n")
                {
                    invalid = false;
                }
                else
                {
                    Console.WriteLine("\nPlease enter y or n.");
                }
            }
            return input;
        }
    }
}
