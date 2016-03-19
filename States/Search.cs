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
            Robot.SetTurnRadarRight(10);
            Robot.SetTurnGunRight(10);
            Robot.steeringBehavior("Wander");
            Robot.Execute();
            return null;
		}
	}
}
