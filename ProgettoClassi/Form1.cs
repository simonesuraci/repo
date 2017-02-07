using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoClassi;
using System.Collections.Generic;

namespace ProgettoClassi
{
    public partial class Form1 : Form
    {
        private List<Monster> monsters;

        public Form1()
        {
            InitializeComponent();
            monsters = Deserializer.deserializeMonster();
            Console.WriteLine(monsters[0].describe());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addMonster(new Monster("tizio", 200, 100));
            Console.WriteLine(monsters[0].describe());
        }

        private Monster addMonster(Monster m)
        {
            monsters.Add(m);
            return m;
        }
    }
}
