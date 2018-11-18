    using System;

    namespace _06.Account_Balance
    {
        class Program
        {
            static void Main(string[] args)
            {
                int purpose = 10000;
                int stepsSum = 0;

                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "Going home")
                    {
                        int stepsGoingHome = int.Parse(Console.ReadLine());
                        stepsSum += stepsGoingHome;
                        break;
                    }
                    else
                    {
                        int currentSteps = int.Parse(command);
                        stepsSum += currentSteps;
                        if (stepsSum >= purpose)
                        {
                            break;
                        }
                    }
                }
                if (stepsSum >= purpose)
                {
                    Console.WriteLine("Goal reached!Good job!");
                }
                else
                {
                    Console.WriteLine($"{purpose - stepsSum} more steps to reach goal.");

                }

            }
        }
    }