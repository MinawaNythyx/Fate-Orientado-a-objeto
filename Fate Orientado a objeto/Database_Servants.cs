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
        public List<Movimentos> muve;
        public void Servants_creation()
        {
            servos = new List<Servants>
            {
                new Servants()
                {
                    Name = "Nero",
                    MaxHeal = 5000,
                    Charge_spe = 0,
                    Atk = 1500,
                    Def = 800,
                    Health = 5000,
                    Moves = new List<Movimentos>()
                    {
                        new Movimentos()
                        {
                            Name_move = "Buster",
                            Special = false,
                            Atk_bonus = 500,
                            Def_bonus = 0,
                            Charge_bonus= 0
                        },
                        new Movimentos()
                        {
                            Name_move = "Arts",
                            Special = false,
                            Atk_bonus = 100,
                            Def_bonus = 200,
                            Charge_bonus = 25
                        },
                        new Movimentos()
                        {
                            Name_move = "Quick",
                            Special = false,
                            Atk_bonus = 200,
                            Def_bonus = 100,
                            Charge_bonus = 10
                        },
                        new Movimentos()
                        {
                            Name_move = "Noble Phatasma",
                            Special = true,
                            Atk_bonus = 3000,
                            Def_bonus = 0,
                            Charge_bonus = -100
                        }
                    }
                }
            };
        }
    }
}