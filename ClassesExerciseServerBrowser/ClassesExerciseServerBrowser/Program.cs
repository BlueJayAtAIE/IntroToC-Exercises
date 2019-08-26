using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExerciseServerBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerBrowserService sbs = new ServerBrowserService();
            ServerInfo s1;
            s1.ping = 1;
            s1.regionID = 2;
            s1.currentPlayerCount = 4;
            s1.maxPlayers = 5;
            sbs.registerServer(s1);

            s1.ping = 8;
            s1.regionID = 5;
            s1.currentPlayerCount = 8;
            s1.maxPlayers = 10;
            sbs.registerServer(s1);

            s1.ping = 15;
            s1.regionID = 3;
            s1.currentPlayerCount = 4;
            s1.maxPlayers = 8;
            sbs.registerServer(s1);

            s1.ping = 5;
            s1.regionID = 1;
            s1.currentPlayerCount = 2;
            s1.maxPlayers = 5;
            sbs.registerServer(s1);

            ServerInfo[] tmp0p = new ServerInfo[0];
            int NumberSrvrs = sbs.getServers(ref tmp0p, 10);

            Console.ReadKey();
        }
    }
}
