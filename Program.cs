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
            while (yesNo == "Y" || yesNo == "y")
            {
                Console.Clear();
                int whichStudent = GetInput("Which student? ", 1, 20);
                //   int data = FindStudent(whichStudent); //TODO
                EnterData();
                yesNo = ynInput();

            }

        }
        public static void EnterData()
        {
            int inputNum = 10;
            string a = "1";
            string b = "2";
            string c = "3";
            string d = "4";

            List<List<string>> studentInfo = new List<List<string>>();
            for (int i = 0; i < inputNum; i++)
            {
                studentInfo.Add(new List<string> { a, b, c, d });
               // Console.WriteLine(studentInfo[i]);
                //foreach(string j in studentInfo[i])
                //{
                //    Console.WriteLine(j);
                //}
            }
            Hashtable info = new Hashtable();
            for (int i = 0; i < inputNum; i++)
            {
                info.Add(i, studentInfo[i]);
   //            Console.WriteLine(studentInfo[i]);
                Console.WriteLine(info[i]);
            }
            Console.WriteLine(info[0]);
        }
        public static int GetInput(string question, int bottomNum, int topNum)
        {
            bool validInput = false;
            int exitNum = 0;
            while (!validInput)
            {
                Console.Write(question);
                bool inp = int.TryParse(Console.ReadLine(), out exitNum);
                if (!inp || exitNum < bottomNum || exitNum > topNum)
                {
                    Console.WriteLine("That student doesn't exist!. Please enter a valid student number. ");
                }
                else
                {
                    validInput = true;
                }
            }
            return exitNum;
        }
        public static string GetInputString(string question)
        {
            bool input = false;
            string exitString = "";
            while (!input)
            {
                Console.Write(question);
                exitString = Console.ReadLine();
                if (exitString == "")
                {
                    Console.WriteLine("\nPlease enter some text.\n");
                }
                else
                {
                    input = true;
                }
            }
            return exitString;
        }
        public static string ynInput()
        // Gets a y or n.
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                Console.Write("\n\nTranslate another line? (y/n): ");
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
