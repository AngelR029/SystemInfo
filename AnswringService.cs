using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnsweringService
{
    class Program
    {
        static void Main(string[] args)
        {
            bool parsed;
            int numValue;
            int state = 0;
            do
            { 
                do
                {
                    numValue = -1;
                    Console.WriteLine("Welcome to the automated answering service. \nPress 1 to speak to a sales representative.\nPress 3 to leave a message.\nPress 5 to hang up.\nOr press 0 to speak to an opperator.");
                    var userchoice = Console.ReadLine();
                    parsed = Int32.TryParse(userchoice, out numValue);
                    if (!parsed)
                        Console.WriteLine("'{0}' is not a number.\n", userchoice);
                } while (!parsed);

                switch (numValue)
                {
                    case 0:
                            Console.WriteLine("We’re transferring you to an operator...\n");
                            state = 1;
                            break;

                    case 1:
                            Console.WriteLine("Our sales offices are closed at this time...\n");
                            state = 1;
                            break;

                        case 3:
                            Console.WriteLine("Please record your message now...\n");
                            state = 1;
                            break;

                        case 5:
                            Console.WriteLine("Good bye...\n");
                            state = 1;
                            break;

                    default:
                            Console.WriteLine("Sorry. you’ve entered an invalid option.\n");
                            break;
                } 
            } while (state == 0);
            Console.ReadLine();
        }
    }
}
