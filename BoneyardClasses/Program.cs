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
        Console.WriteLine("2 = Draw a Domino from the boneyard");
        Console.WriteLine("3 = Shuffle the boneyard");
        Console.WriteLine("4 = Check if the boneyard is empty");
        Console.WriteLine("5 = Check the number of Dominos remaining in the boneyard");
        Console.WriteLine("6 = Print the boneyard");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("How many dots would you like on each side?");
                int maxDots = Convert.ToInt32(Console.ReadLine());
                boneyard.BoneYard(maxDots);
                Console.WriteLine("New boneyard created with " + maxDots + " max dots on each side.");
                break;
            case 2:
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
            case 3:
                boneyard.Shuffle();
                Console.WriteLine("Boneyard shuffled.");
                break;
            case 4:
                if (boneyard.IsEmpty())
                {
                    Console.WriteLine("The boneyard is empty.");
                }
                else
                {
                    Console.WriteLine("The boneyard is not empty.");
                }
                break;
            case 5:
                Console.WriteLine("There are " + boneyard.DominosRemaining + " Dominos remaining in the boneyard.");
                break;
            case 6:
                Console.WriteLine(boneyard.ToString());
                break;
            default:
                Console.WriteLine("Not a valid choice. Please try again.");
                break;
        }
        Start();
    }
}