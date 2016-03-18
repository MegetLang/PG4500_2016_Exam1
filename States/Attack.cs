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
            Robot.Out.WriteLine("The enemy is "+ Robot.Enemy.BearingDegrees +  " From me");
        }

        public override string ProcessState()
		{
            double radarTurn = Robot.Heading + Robot.Enemy.BearingDegrees - Robot.RadarHeading;
            Robot.SetTurnRadarRight(Utils.NormalRelativeAngle(radarTurn));
            return null;
		}
	}
}
