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
            Database_Servants data = new Database_Servants();
            Master Player = new Master();
            Player.Servants_mas = new List<Servants>();
            Master Player2 = new Master();
            Player2.Servants_mas = new List<Servants>();
            data.Servants_creation();
            Player.Master_Creation(1);
            Player2.Master_Creation(2);
            #region Players Choice
            Console.WriteLine("Hora de escolher um servo para começar a batalha, começaremos pelo jogador 1, {0}", Player.Name);
            Console.WriteLine("Escolha um por favor");
            int y = 1;
            foreach (var serv in data.servos)
            {
                Console.WriteLine("{0} - {1}", y, serv.Name);
                y++;
            }
            int escolha = Convert.ToInt32(Console.ReadLine());
            Player.Servants_mas.Add(data.servos[escolha - 1]);
            Console.WriteLine("Agora é a vez do jogador 2, {0} por favor escolha", Player2.Name);
            Console.WriteLine("Escolha um por favor");
            y = 1;
            foreach (var serv in data.servos)
            {
                Console.WriteLine("{0} - {1}", y, serv.Name);
                y++;
            }
            escolha = Convert.ToInt32(Console.ReadLine());
            Player2.Servants_mas.Add(data.servos[escolha - 1]);


            #endregion
            #region Battle
            #endregion
            y = 1;
            foreach(var serv in Player.Servants_mas)
            {
                foreach (var serv2 in Player2.Servants_mas)
                {
                    Console.WriteLine("{0} - {1}", y, serv.Name);
                    Console.WriteLine("{0} - {1}", y, serv2.Name);
                }
            }

            Console.ReadLine();










            
        }
    }
}
