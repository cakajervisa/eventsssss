using System;

namespace Events
{
    public class EntryPoint
    {
        static int score = 0;

        static void Main(string[] args)
        {
            Shooter shooter = new Shooter();

            shooter.ShotsFired += KilledEnemy;
            //shooter.ShotsFired += KilledEnemy;
            //shooter.ShotsFired += AddScore;

            shooter.OnShoot();
        }

        // Subscriber methods to the event
        static void KilledEnemy(object source, EventArgs e)
        {
            Console.WriteLine($"I killed an enemy ");
  
        }
    




        static void AddScore(object source, EventArgs e)
        {
            score++;
        }

      
    }
}
