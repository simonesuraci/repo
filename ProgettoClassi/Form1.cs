using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoClassi;

namespace ProgettoClassi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Monster gunnarson = new Monster("Gunnarson", 100, 20);
            Monster pepe = new Monster("Pepe", 60, 20, 10);

            gunnarson.attack(pepe);
            pepe.attack(gunnarson);
            gunnarson.heal();
            gunnarson.curHp = 20;
            pepe.heal(gunnarson);
            gunnarson.attack(pepe);
            gunnarson.attack(pepe);
        }
    }
}
