using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate_Orientado_a_objeto
{
    public class Movimentos
    {
        private string name_move;
        private bool special;
        private float atk_bonus;
        private float def_bonus;
        private float charge_bonus;
        public Movimentos(string name_move)
        {
            this.name_move = name_move;
        }
        public string Name_move
        {
            get => name_move;
            set => name_move = value;
        }
        public bool Special
        {
            get => special;
            set => special = value;
        }
        public float Atk_bonus
        {
            get => atk_bonus;
            set => atk_bonus = value;
        }
        public float Def_bonus
        {
            get => def_bonus;
            set => def_bonus = value;
        }
        public float Charge_bonus
        {
            get => charge_bonus;
            set => charge_bonus = value;
        }
    }
}
