using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG4500_2016_Exam1.Robocode;
using Robocode;

namespace PG4500_2016_Exam1.States
{
    
	public class Search : State
	{
		public Search()
			:base("Search")
		{
		}
        public override void EnterState()
        {
            base.EnterState();
     
        }
        public override string ProcessState()
		{
            Random r = new Random();

            Robot.SetTurnRadarRight(10);
            Robot.SetAhead(20);
            double angle = r.NextDouble() - 90 + (r.NextDouble() * 180);
            int turncheck = r.Next(1, 6);
            if (turncheck == 2)
            {
                Robot.SetTurnLeft(angle);
            }
            //Med mer tid ville jeg en mer optimal måte å scanne etter fiender på.
            Robot.Execute();
            return null;
		}
	}
}
