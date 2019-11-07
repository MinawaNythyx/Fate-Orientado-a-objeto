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
        public void Servants_creation()
        {
            servos = new List<Servants>
            {
                new Servants()
                {
                    Name = "Nero",
                    MaxHeal = 5000,
                    Atk = 1500,
                    Def = 800
                }
            };
        }
    }
}