using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8BallFrameWork
{
    class Program
    {
        static Random randomObject = new Random();
        static void Main(string[] args)
        {
            QuestionLoop();
        }
        static String GetQuestionFromUser()
        {                                                                                                
            Console.Write("What question do you have? ");
            string questionString = Console.ReadLine();
            return questionString;
        }
        static void QuestionLoop()
        {
            while (true)
            {
                int numberOfSecondsToSleep = randomObject.Next((5) + 1);
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                string questionString = GetQuestionFromUser();
                Console.WriteLine("Hmmm... Let me think...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);
                int randomNumber = randomObject.Next(10);
                if (questionString.ToLower() == "quit")
                {
                    break;
                }

                if (questionString.ToLower() == "what is the meaning of life")
                {
                    Console.WriteLine("The answer is 42 my child...");
                    break;
                }

                if (questionString.ToLower() == "ninjafiveo")
                {
                    Console.WriteLine("Shh We do not speak of the invisible.");
                    break;
                }
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Bad Idea!");
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("That's A Mystery For The Ages!");
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("I would make donuts instead.");
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Your teacher is a ninja. Be nice.");
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("I dunno man.");
                            break;
                        }
                    case 7:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Stop asking me questions and make me a pizza.");
                            break;
                        }
                    case 8:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Maybe.");
                            break;
                        }
                    case 9:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("This isn't canada. Speak english.");
                            break;
                        }
                }
            }
            Console.ReadLine();
        }
    }
}
