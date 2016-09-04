using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ServerTrack
{
    class ServerTrackController : ApiController
    {
        private ServerCollection Servers;

        public ServerTrackQueryResults Get(string ServerName)
        {
            return null;
        }

        public void Post([FromBody]string ServerName, double CPULoad, double RAMLoad)
        {
            Servers.CreateOrAppend(ServerName, CPULoad, RAMLoad);
        }
    }
}
