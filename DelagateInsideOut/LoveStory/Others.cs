using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveStory
{
    public delegate void SendLoveMessageDelegate();
    //You : void NhanEm()
    //Me : void TellHer()
    public class Others
    {
        public static void MeetSweetheart()
        {
            Console.WriteLine("Hello, my love.");
            SendLoveMessageDelegate sendLoveMessage = new SendLoveMessageDelegate(Me.TellHer);
            sendLoveMessage += new SendLoveMessageDelegate(You.NhanEm);
            Console.WriteLine("By the way, you have message form...");
            sendLoveMessage();
        }
    }
}
