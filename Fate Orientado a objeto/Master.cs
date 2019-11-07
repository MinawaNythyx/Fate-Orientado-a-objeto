using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate_Orientado_a_objeto
{
    class Master
    {
        private string name;
        private List<Servants> servos;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public List<Servants> Servants_mas
        {
            get => servos;
            set => servos = value;
        }
    }
}
