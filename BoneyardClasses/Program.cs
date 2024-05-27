using System;
using System.Collections.Generic;
using System.Linq;
using BoneyardClasses;

class Program
{
    public static Boneyard boneyard = new Boneyard();
    public static void Main(string[] args)
    {
        Start();
    }

    public static void Start()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1 = Make a new boneyard of Dominos");
        Console.WriteLine("2 = Get the number of dominos remaining");
        Console.WriteLine("3 = Get a domino based on its index in the boneyard");
        Console.WriteLine("4 = Draw a Domino from the boneyard");
        Console.WriteLine("5 = Check if the boneyard is empty");
        Console.WriteLine("6 = Shuffle the boneyard");
        Console.WriteLine("7 = Print the boneyard");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("How many dots would you like on each side?");
                int maxDots = Convert.ToInt32(Console.ReadLine());
                boneyard.BoneYard(maxDots);
                Console.WriteLine("New boneyard created with " + maxDots + " max dots on each side.");
                break;
            case 4:
                Domino drawnDomino = boneyard.Draw();
                if (drawnDomino != null)
                {
                    Console.WriteLine("You drew a " + drawnDomino.ToString());
                }
                else
                {
                    Console.WriteLine("The boneyard is empty and nothing to draw.");
                }
                break;
            case 6:
                boneyard.Shuffle();
                Console.WriteLine("Boneyard shuffled.");
                break;
            case 5:
                if (boneyard.IsEmpty())
                {
                    Console.WriteLine("The boneyard is empty.");
                }
                else
                {
                    Console.WriteLine("The boneyard is not empty.");
                }
                break;
            case 2:
                Console.WriteLine("There are " + boneyard.DominosRemaining + " Dominos remaining in the boneyard.");
                break;
            case 7:
                Console.WriteLine(boneyard.ToString());
                break;
            case 3:
                Console.WriteLine("Which index would you like to get?");
                int index = Convert.ToInt32(Console.ReadLine());
                Domino domino = boneyard[index];
                if (domino != null)
                {
                    Console.WriteLine("The domino at index " + index + " is " + domino.ToString());
                }
                else
                {
                    Console.WriteLine("There is no domino at index " + index);
                }
                break;
            default:
                Console.WriteLine("Not a valid choice. Please try again.");
                break;
        }
        Start();
    }
}