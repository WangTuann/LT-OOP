using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoccerPlayer
{
    class TestSoccerPlayer
    {
        static void Main(string[] args)
        {
            SoccerPlayer sP = new SoccerPlayer("Cong Phuong", 10, 3, 1);
            Console.WriteLine("Name : {0} \nJessey Number {1} \nGoals: {2} \nAssist : {3}",sP.name,sP.jesseyNumber,sP.goals,sP.assist);
            Console.ReadKey();
        }
    }
    class SoccerPlayer
    {
        public string name { get; set; }
        public int jesseyNumber { get; set; }
        public int goals { get; set; }
        public int assist { get; set; }

        public SoccerPlayer(string n, int num, int goal, int asst)
        {
            name = n;
            jesseyNumber = num;
            goals = goal;
            assist = asst;
        }

    }

}
