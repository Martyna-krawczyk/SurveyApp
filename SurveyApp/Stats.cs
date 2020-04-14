using System;

namespace Survey
{
    public class Stats
    {
        public void Start()
        {
            Program.Posted += HasPosted; //the HasPosted function is triggered when the Posted function has been executed
        }

        void HasPosted()
        {
            Console.WriteLine("Survey Posted - Run Stats");
        }
    }
}