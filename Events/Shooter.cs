using System;
using System.Threading;

namespace Events
{
    public class Shooter
    {

        public delegate void KillingHandler(object sender, EventArgs e);
        //public event KillingHandler ShotsFired;
        public event EventHandler ShotsFired;
        // Event to be invoked upon successful kill
        //public event EventHandler<ShotsFiredEventArgs> ShotsFired;

        private Random rng = new Random();

        public void OnShoot()
        {
            while (true)
            {
                if (rng.Next(0, 100) % 2 == 0)
                {
                    ShotsFired.Invoke(this, EventArgs.Empty);
                    //ShotsFired?.Invoke(this, new ShotsFiredEventArgs(DateTime.Now)); // EventName? means if Event is not Null (if it has subscribers)
                }
                else
                {
                    Console.WriteLine("I Missed!");
                }

                Thread.Sleep(1000);
            }
        }
    }
}
