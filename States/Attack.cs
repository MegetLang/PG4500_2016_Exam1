using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG4500_2016_Exam1.Robocode;
using Robocode.Util;

namespace PG4500_2016_Exam1.States
{
	public class Attack : State
	{
        private EnemyData target { get; set; }

        public Attack()
			:base("Attack")
		{
		}
        public override void EnterState()
        {
            base.EnterState();
        }

        public override string ProcessState()
		{
            string nextState = null;
            double radarTurn = Robot.Heading + Robot.Enemy.BearingDegrees - Robot.RadarHeading;
            Robot.SetTurnRadarRight(Utils.NormalRelativeAngle(radarTurn));
            Robot.SetTurnGunRight(Utils.NormalRelativeAngle(radarTurn));
            
            Robot.steeringBehavior("Seek");
            Robot.steeringBehavior("Arrive");

            if (Robot.Time - Robot.Enemy.Time > 40)
                nextState = "Search";
            

            if (Robot.Energy < 70 && Robot.Energy < Robot.Enemy.Energy)
            {
                //Enemy is too clever, employ smarter tactics
                //nextState = "EvasiveMode";
            }
            if (Robot.Time - Robot.Enemy.Time < 5)
                Robot.SetFire(2);
                     
            return nextState;
		}
	}
}
