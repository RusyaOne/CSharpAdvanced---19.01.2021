using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DelegatesExamples
{
    public class Agent
    {
        public void DoMission(Func<bool, string> sendMissionResult) 
        {
            Console.WriteLine(sendMissionResult(true));
        }
    }

    public static class Curator 
    { 
        public static void SendAgentForMission()
        {
            Agent agent = new Agent();

            agent.DoMission(result => result ? "Mission complete" : "Mission falied");
        }
    }
}