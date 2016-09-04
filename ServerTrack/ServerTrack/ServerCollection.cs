using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTrack
{
    class ServerCollection
    {
        private Object CollectionLock;
        private Dictionary<string, Server> ServerDict;

        public ServerCollection()
        {
            CollectionLock = new Object();
            ServerDict = new Dictionary<string, Server>();
        }

        public void CreateOrAppend(string ServerName, double CPULoad, double RAMLoad)
        {
            Server server;
            lock(CollectionLock)
            {
                if (!ServerDict.TryGetValue(ServerName, out server))                    
                    ServerDict.Add(ServerName, new Server(CPULoad = CPULoad, RAMLoad = RAMLoad));
            }
        }
    }
}
