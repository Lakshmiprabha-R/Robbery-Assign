// See https://aka.ms/new-console-template for more information
using System;

class ShootGame
{
    static void Main()
    {
        Console.Write("Enter Number of Robbers: ");
        int numRobbers = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Robber with whom Sam will start shooting: ");
        int startRobber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the gap between the Robbers: ");
        int gap = Convert.ToInt32(Console.ReadLine());
        int currentRobber = startRobber;
        int liveTargets = numRobbers;
        int ShotsTaken = 0;
        string shootSequence = "";
        while (liveTargets > 0)
        {
            ShotsTaken++;
            shootSequence += currentRobber.ToString() + ",";
            Console.WriteLine("Target={0},{1} Shots completed", currentRobber, ShotsTaken);
            liveTargets--;
            int nextRobber = currentRobber + gap;
            if (nextRobber > numRobbers)
            {
                nextRobber -= numRobbers;
            }
            currentRobber = nextRobber;
        }
        Console.WriteLine("\n{0} shots taken", ShotsTaken);
        Console.Write("The shootout sequence was ");
        shootSequence = shootSequence.Remove(shootSequence.Length - 1);

    }
}
