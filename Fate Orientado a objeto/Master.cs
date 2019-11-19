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

        public void Master_Creation(int p)
        {
            Console.WriteLine("Então registraremos nosso {0}º mestre.", p);
            bool choice;
            do
            {
                Console.WriteLine("Qual seu nome?");
                Name = Console.ReadLine();
                Console.WriteLine("Seu nome é {0}?\nSim - s ou Não - n", Name);
                char l = char.ToLower(Convert.ToChar(Console.ReadLine()));
                choice = l == 's' ? false : true;
                Console.Clear();
            } while (choice);
        }
    }
}
