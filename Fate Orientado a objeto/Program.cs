using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate_Orientado_a_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste
            Database_Servants data = new Database_Servants();
            Master Player = new Master();
            Master Player2 = new Master();
            data.Servants_creation();
            int y = 1;
            foreach(var serv in data.servos)
            {
                Console.WriteLine("{0} - {1}", y, serv.Name);
                y++;
            }
            Console.ReadKey();
        }
    }
}
