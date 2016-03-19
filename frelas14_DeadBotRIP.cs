using System.Drawing;
using Robocode;
using Robocode.Util;
using PG4500_2016_Exam1.Robocode;
using PG4500_2016_Exam1.States;

namespace PG4500_2016_Exam1
{
	class frelas14_DeadBotRIP : AdvancedRobotEx
	{

		private readonly FiniteStateMachine fsm;

		public frelas14_DeadBotRIP()
		{
			fsm = new FiniteStateMachine(new State[] { new Search(), new Attack(), new Escape() });
		}
       
		public override void Run()
		{
			InitBot();

            while (true)
			{
                fsm.Update();
                Execute();
			}
		}

		public override void OnScannedRobot(ScannedRobotEvent evnt)
		{
            Enemy.SetEnemyData(evnt);
            fsm.Queue("Attack");
        }
        public override void OnHitWall(HitWallEvent evnt)
        {
            SetTurnRight(180);
        }

        private void InitBot()
		{
            SetAllColors(Color.Green);
            IsAdjustGunForRobotTurn = true;
            IsAdjustRadarForGunTurn = true;
            fsm.Init(this);
        }
	}
}
