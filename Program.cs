using System;

namespace CONDITIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            string difficulty = null;
            string ans = null;
            string a = null;
            int b = 0;
            int c = 0;
            int d = 0;
            
            Console.WriteLine("Hello! Welcome to my Musical Quotes Trivia!");
            Console.WriteLine("Press Enter to continue ...");
            Console.ReadKey();
            Console.Clear();
            
            Outer:
            Console.WriteLine("In what difficulty do you want to play in?\nEasy, Medium, or Hard?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Leave blank to exit\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Answer: ");
            difficulty = Console.ReadLine();
            difficulty = difficulty.ToLower();
            Here:
            Console.Clear();

            if (difficulty == "easy")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'I took a shot of cocaine and I shot my woman down I went right home and I went to bed...'"); 
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Where does this come from?");
                Console.Write("Answer: ");
                ans = Console.ReadLine();
                ans = ans.ToLower();
                Console.Clear();
                if (ans == "johnny" || ans == "cash" || ans == "johnny cash")
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine("Press Enter to continue ...");
                    b = 1;
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Would you like to advance to the (N)ext level or would you like to (E)xit?");
                    a = Console.ReadLine();
                    a = a.ToLower();
                    Console.Clear();
                    if (a == "n")
                    {
                        difficulty = "medium";
                        goto Here;
                    }
                    else if (a == "e")
                    {
                        Console.WriteLine("Thanks For Playing");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Well that was neither N or E LOL. I'll just kick you out.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("\nWrong\nThe answer was Avenged Sevenfold");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Game Over");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press (T) to try again or (E) to exit");
                    a = Console.ReadLine();
                    a = a.ToLower();
                    Console.Clear();
                    if (a == "t")
                    {
                        goto Outer;
                    }
                    else if (a == "e")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Well that was neither e or t LOL. I'll just kick you out.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }

            }
            else if (difficulty == "medium")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'Can't you help me as I'm startin' to burn (all alone) Too many doses and I'm starting to get an attraction'"); 
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Where does this come from?");
                Console.Write("Answer: ");
                ans = Console.ReadLine();
                ans = ans.ToLower();
                Console.Clear();
                if (ans == "avenged" || ans == "sevenfold" || ans == "avenged sevenfold")
                {
                    Console.WriteLine("Correct!");
                    c = 1;
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Would you like to advance to the (N)ext level or would you like to (E)xit?");
                    a = Console.ReadLine();
                    a = a.ToLower();
                    Console.Clear();
                    if (a == "n")
                    {
                        difficulty = "hard";
                        goto Here;
                    }
                    else if (a == "e")
                    {
                        Console.WriteLine("Thanks For Playing");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else{
                        Console.WriteLine("Well that was neither N or E LOL. I'll just kick you out.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("\nWrong\nThe answer was Avenged Sevenfold.");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Game Over");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press (T) to try again or (E) to exit");
                    a = Console.ReadLine();
                    a = a.ToLower();
                    if (a == "t")
                    {
                        goto Outer;
                    }
                    else if (a == "e")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Well that was neither e or t LOL. I'll just exit you out.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            else if (difficulty == "hard")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'You can take me to paradise and then you can be cold as ice. I'm over my head (over my head) But it sure feels nice'"); 
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Where does this come from?");
                Console.Write("Answer: ");
                ans = Console.ReadLine();
                ans = ans.ToLower();
                Console.Clear();
                if (ans == "fleetwood" || ans == "mac" || ans == "fleetwood mac")
                {
                    Console.WriteLine("Correct!");
                    d = 1;
                    Console.ReadKey();
                    if (b == 1 && c == 1 && d == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Wow you're kinda insane. Thanks for playing.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Would you like to try (A)nother level or (E)xit?");
                        ans = Console.ReadLine();
                        ans = ans.ToLower();
                        if (ans == "a")
                        {
                            goto Outer;
                        }
                        else if (ans == "e")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Well that was neither A or E LOL. I'll just exit you out.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nWrong\nThe answer was Fleetwood Mac.");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Game Over");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press T to try again or E to exit");
                    a = Console.ReadLine();
                    a = a.ToLower();
                    if (a == "t")
                    {
                        goto Outer;
                    }
                    else if (a == "e")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Well that was neither e or t LOL. I'll just exit you out.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            else if (difficulty == "")
            {
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("Please input an appropriate difficulty.");
                Console.WriteLine("Press Enter to continue ...\n");
                Console.ReadKey();
                Console.Clear();
                goto Outer;
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}