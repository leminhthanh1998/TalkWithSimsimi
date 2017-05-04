using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
/// TalkWithSimsimi-----Code by LMT-----http://lêminhthành.vn
namespace TalkWithSimsimi
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Console.Title = "Chat with Simsimi!";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Control ctrl = new Control();
            Console.Write("CHAT WITH SIMSIMI!-Code by LMT \n");
            while (true)
            {
                ctrl.CONTROL();
                //Console.ReadKey();
            }

        }

    }
}
