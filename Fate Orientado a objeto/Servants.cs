using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate_Orientado_a_objeto
{
    public class Servants
    {
        private string name;
        private float maxHeal;
        private float health;
        private float atk;
        private float def;
        private List<Movimentos> moves;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public float MaxHeal
        {
            get => maxHeal;
            set => maxHeal = value;
        }
        public float Health
        {
            get => health;
            set => health = value;
        }
        public float Atk
        {
            get => atk;
            set => atk = value;
        }
        public float Def
        {
            get => def;
            set => def = value;
        }
        public List<Movimentos> Moves
        {
            get => moves;
            set => moves = value;
        }
    }
}
