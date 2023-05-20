namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInternet internet = new ProxyInternet();
            internet.Connect("https://google.com");

            internet.Connect("https://bad.com");
        }
    }
}