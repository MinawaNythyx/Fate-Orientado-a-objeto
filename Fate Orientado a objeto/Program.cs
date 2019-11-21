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
            Master Player2 = new Master();
            data.Servants_creation();
            Player.Master_Creation(1);
            Player2.Master_Creation(2);
            Console.WriteLine("Hora de escolher um servo para começar a batalha, começaremos pelo jogador 1, {0}", Player.Name);
            Console.WriteLine("Escolha um por favor");
            Player.Servants_mas = new List<Servants>();
            /*Player.Servants_mas.Add(data.List_of_servants)*/;
            data.List_of_servants();
            Console.WriteLine("Hora de escolher um servo para começar a batalha, começaremos pelo jogador 2, {0}", Player2.Name);
            Console.WriteLine("Escolha um por favor");
            data.List_of_servants();

            Console.ReadLine();










            
        }
    }
}
