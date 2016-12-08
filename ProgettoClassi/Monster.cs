using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoClassi
{
    class Monster
    {
        private string _name; 
        public string name
        {
            get
            {
                return _name;
            }
        }  
        private int _maxHp; 
        public int maxHp 
        {
            get 
            { 
                 return _maxHp; 
            } 
        } 
        private int _curHp; 
        public int curHp
        { 
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > _maxHp)
                {
                    value = _maxHp;
                    curHp = value;
                }     
            }  
            get 
            { 
                return _curHp; 
            } 
        } 
        public int damage;
        public int healFactor;
        public Monster(string name, int maxHp, int damage , int healFactor = 0)
        {
            _name = name;
            if (maxHp < 1) 
            {
                maxHp = 1;
                _maxHp = maxHp;
            }
            curHp = maxHp;
            this.damage = damage;
            this.healFactor = healFactor;
            describe();
        }

        public string describe()
        {
            string output = "Questo è" + name + "r/n";
            output += "HP" + _curHp + "r/n";
            output += "DAMAGE" + damage + "r/n";
            return output;
        }

        public void describe(TextBox t)
        {
            t.Text = describe();
        }
        public void heal(Monster target)
        {
            if (healFactor == 0)
            {
                Console.WriteLine("Non hai il potere di curare nessuno");
                return;
            }

            if (_curHp <= 0)
            {
                Console.WriteLine("Non puoi curare nessuno da morto");
                return;
            }

            if (target._curHp <= 0)
            {
                Console.WriteLine(target.name + " è esausto e non puoi resuscitarlo con la cura.");
                return;
            }

            target._curHp += healFactor;

            if (target._curHp > target._maxHp)
            {
                target._curHp = target._maxHp;
            }

            Console.WriteLine(name + " usa cura su " + target.name);
            Console.WriteLine(target.name + " è stato curato e ora ha " + target._curHp + "/" + target._maxHp + " HP");
        }

        public void heal()
        {
            heal(this);
        }

        public void attack(Monster target)
        {
            if (target._curHp <= 0)
            {
                Console.WriteLine("Non puoi attaccare nessuno da morto a meno che tu non sia uno zombie");
                return;
            }
            if (target._curHp <= 0)
            {
                Console.WriteLine(target.name + " è già esasuto, non infierire");
                return;
            }
            Console.WriteLine(name + " attacca " + target.name);
            Console.WriteLine(name + " fa " + damage + " danni a "  + target.name);
            target._curHp -= damage;
            if (target._curHp <= 0)
            {
                target._curHp = 0;
                Console.WriteLine(target.name + " è esausto");
            }
            else
            {
                Console.WriteLine("a " + target.name + " rimangono " + target._curHp + "/" + target._maxHp);
            }
        }
    }
}
