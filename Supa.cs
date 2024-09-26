using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreMandsGruppe
{
    internal class Supa
    {
        protected string _class;
        protected string _armor;
        protected string _weapon;

        public Supa(string _class, string _armor, string _weapon)
        {
            this._class = _class;
            this._armor = _armor;
            this._weapon = _weapon;
        }

        public void SupaStats()
        {
            Console.WriteLine("Supa Stats:");
            Console.WriteLine("Class: " + _class);
            Console.WriteLine("Armor: " + _armor);
            Console.WriteLine("Weapon: " + _weapon);
        }
    }

}
