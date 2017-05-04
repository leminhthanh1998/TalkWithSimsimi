using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkWithSimsimi
{
    class Control
    {

        public  void CONTROL()
        {
            GoTiengViet vn=new GoTiengViet();
            Simsimi sim =new Simsimi();
            string text="";
            Console.Write("Tui: " + text);
            text = vn.ReadLine();
            text = text.Replace(" ", "%20");
            sim.SIMSIMI(text);
        }
    }
}
