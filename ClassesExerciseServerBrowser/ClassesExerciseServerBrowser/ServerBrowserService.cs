using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExerciseServerBrowser
{
    struct ServerInfo
    {
        public int regionID;             // region
        public int currentPlayerCount;   // current player count
        public int maxPlayers;           // max player count
        public int ping;                 // ping
    }
    class ServerBrowserService
    {
        // An array of all servers registered with the system.
        private ServerInfo[] servers = new ServerInfo[50]; // note: this is hard-coded for 50 servers

        // A count of all servers currently registered.
        private int serverCount;

        // Registers a server with the service
        // Returns success if server has been added
        // No more than 50 servers can be added
        public bool registerServer(ServerInfo newServer)
        {
            if (serverCount > 49)
                return false;

            servers[serverCount] = newServer;
            serverCount++;
            return true;
        }

        //public int getServers(ref ServerInfo[] dstArray) //OLD FUNCTION, HERE JUST AS AN EXAMPLE FOR MYSELF
        //{
        //    int srvsCopied = 0;
        //    foreach (ServerInfo svr in servers)
        //    {
        //        dstArray[srvsCopied] = svr;
        //        srvsCopied++;
        //    }
        //    return srvsCopied;
        //}

        // Copies server entries into the given array.
        // Returns the total number of servers provided to the array.
        public int getServers(ref ServerInfo[] dstArray, int pingLimit)
        {
            dstArray = new ServerInfo[50];
            int srvrsCopied;
            int dstIndex = 0;
            for (srvrsCopied = 0; srvrsCopied < serverCount; srvrsCopied++)
            {
                if (servers[srvrsCopied].ping > pingLimit)
                {
                    dstArray[srvrsCopied] = servers[srvrsCopied];
                    dstIndex++;
                }
            }
            return srvrsCopied;
        }
    }
}
