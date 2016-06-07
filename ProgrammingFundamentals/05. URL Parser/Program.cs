using System;

namespace _05.URL_Parser
{
    class Program
    {
        static void Main()
        {
            string url = Console.ReadLine();
            string protocol = "";
            string server = "";
            string resource = "";
            string sep1 = "://";
            string sep2 = "/";
            int indexProt = 0;
            int indexRes;

            indexProt = url.IndexOf(sep1);
            if (indexProt > 0)
            {
                protocol = url.Substring(0, indexProt);
            }
            indexRes = url.IndexOf(sep2, indexProt+3);
            if (indexRes > 0)
            {
                resource = url.Substring(indexRes+1);
            }
            // 4 scenarios for server
            if (indexProt > 0 && indexRes > 0)
            {
                server = url.Substring(indexProt + 3, indexRes - (indexProt + 3));
            }
            else if(indexProt > 0 && indexRes < 0)
            {
                server = url.Substring(indexProt + 3);
            }
            else if (indexProt < 0 && indexRes > 0)
            {
                server = url.Substring(0, indexRes);
            }
            else
            {
                server = url;
            }
            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }
}
