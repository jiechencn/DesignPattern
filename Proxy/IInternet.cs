using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IInternet
    {
        public void Connect(string url);
    }

    public class RealInternet : IInternet
    {
        public void Connect(string url)
        {
            Console.WriteLine("connected to " + url);
        }
    }

    public class ProxyInternet: IInternet
    {
        private IInternet realInternet = new RealInternet();
        public void Connect(string url)
        {
            RejectBadUrl(url);
            realInternet.Connect(url);
            LogAccess(url);
        }

        private void LogAccess(string url)
        {
            Console.WriteLine("someone is accessing " + url);
        }

        private void RejectBadUrl(string url)
        {
            // 检查有害网址，抛异常;
            if (url.Contains("bad"))
            {
                throw new Exception("bad url");
            }
        }
    }
}
