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
        private void ScanForEnemy()
        {
            while (Robot.Enemy.Name == null)
            {
                Robot.TurnRadarRight(15);
            }
            //Med mer tid ville jeg en mer optimal måte å scanne etter fiender på.
        }

		public Search()
			:base("Search")
		{
		}
        public override void EnterState()
        {
            base.EnterState();
            ScanForEnemy();

        }
        public override string ProcessState()
		{
            return null;
		}
	}
}
