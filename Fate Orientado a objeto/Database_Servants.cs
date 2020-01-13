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
                        new Movimentos("Buster"),
                        new Movimentos("Buster"),
                        new Movimentos("Arts"),
                        new Movimentos("Arts"),
                        new Movimentos("Quick")
                    }
                },
                new Servants("Ishtar", 4000, 2000, 200)
                {
                    Moves = new List<Movimentos>()
                    {
                        new Movimentos("Buster"),
                        new Movimentos("Buster"),
                        new Movimentos("Arts"),
                        new Movimentos("Arts"),
                        new Movimentos("Quick")
                    }
                }
                //Jalter Avenger
                //Jalter Berserk
                //Jeanne Ruler
                //Salter Saber
                //Artoria Saber
                //Nitocris Caster
                //Merlin Caster
                //Heracles Berserk
                //Ibaraki Douji Berserk
                //Shuten Douji Berserk
                //Cu Lancer
                //Jake The Ripper Assassin
                //Queen Medb Rider
                //Martha Rider
                //Martha Ruler
                //Musashi Saber
                //Gilgamesh Caster
                //Gilgamesh Archer
                //MHX Foreigner
                //MHX Assassin
                //Nitocris Assassin
                //Caster Of Midrash
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