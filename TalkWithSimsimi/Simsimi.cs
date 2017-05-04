using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TalkWithSimsimi
{
    class Simsimi
    {
        /// <summary>
        /// Lấy câu trả lời từ Simsimi
        /// </summary>
        /// <param name="t"></param>
        public  void SIMSIMI(string t)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://simsimi.com/getRealtimeReq?uuid=8ACtyn1WIRLFvpzhNC6P00QS4sfiqXRa4fz7pbacy23&lc=vi&ft=0&reqText=" + t);
                WebResponse response = request.GetResponse();
                Stream data = response.GetResponseStream();
                string text = "";
                using (StreamReader sr = new StreamReader(data))
                    text = sr.ReadToEnd();
                text = text.Replace(@"{""status"":200,""respSentence"":""", "");
                text = text.Replace(@"""}", "");
                Console.Write("Simsimi: {0}\n",text);
            }
            catch (Exception e)
            {
                Console.Write("Da co loi, vui long kiem tra ket noi mang!\n");
            }
        }
    }
}
