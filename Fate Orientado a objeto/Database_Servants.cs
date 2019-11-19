using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate_Orientado_a_objeto
{
    public class Database_Servants
    {
        public List<Servants> servos;
        #region Servants
        public void Servants_creation()
        {
            servos = new List<Servants>
            {
                new Servants("Nero", 5000, 1500, 800)
                {
                    Moves = new List<Movimentos>()
                    {
                        new Movimentos("Buster", false, 500, 0, 0),
                        new Movimentos("Arts", false, 100, 200, 25),
                        new Movimentos("Quick", false, 200, 100, 10),
                        new Movimentos("Noble Phantasma", true, 3000, 0, -100)
                    }
                },
                new Servants("Ishtar", 4000, 2000, 200)
                {
                    Moves = new List<Movimentos>()
                    {
                        new Movimentos("Buster", false, 400, 0, 0),
                        new Movimentos("Arts", false, 200, 200, 30),
                        new Movimentos("Quick", false, 200, 100, 10),
                        new Movimentos("Noble Phantasma", true, 2000, 0, -100)
                    }
                }
            };
        }
        #endregion
        #region List of Servants Call
        public void List_of_servants()
        {
            int y = 1;
            foreach(var serv in servos)
            {
                Console.WriteLine("{0} - {1}", y, serv.Name);
                y++;
            }
        }
        #endregion
    }
}