using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTrack
{
    class Server
    {
        public String ServerName { get; set; }
        private List<ServerPerformanceStats> statsList;

        public Server(double CPULoad, double RAMLoad)
        {
            statsList = new List<ServerPerformanceStats>();
            statsList.Add(new ServerPerformanceStats(CPULoad, RAMLoad))
        }
    }

    class ServerPerformanceStats
    {
        public Double CPULoad { get; set; }
        public Double RAMLoad { get; set; }
        private DateTime TimeStamp { get; set; }

        public ServerPerformanceStats(double CPULoad, double RAMLoad)
        {
            this.CPULoad = CPULoad;
            this.RAMLoad = RAMLoad;
            TimeStamp = DateTime.Now;
        }
    }
}
